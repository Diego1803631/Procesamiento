using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FilterApp
{
    class Video
    {
        Bitmap image;
        PictureBox pictureBox;

        public static object ExtBitmap { get; private set; }

        public Video(Bitmap img, PictureBox pic)
        {
            image = img;

            pictureBox = pic;
        }
        public void getImage()
        {
            try
            {
                pictureBox.Image = image;
            }
            catch (ArgumentException)
            {
                MessageBox.Show("There was an error." + "Check the path to the image file.");
            }
        }
        public void addFilter(string filtername)
        {
            switch (filtername)
            {
                case "Laplaciano":
                    Laplaciano();
                    break;
                case "Substracción de Media":
                    SubstracciónMedia();
                    break;
                case "Direccional NS":
                    DireccionalNS();
                    break;
                case "Sobel":
                    Sobel();
                    break;
                case "Menos-Laplaciano":
                    MenosLaplaciano();
                    break;
                case "Negativo":
                    Negativo();
                    break;
                default:
                    break;
            }

        }

        //Negativo
        private void Negativo()
        {
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    //get pixel value
                    Color p = image.GetPixel(x, y);

                    //extract ARGB value from p
                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    //find negative value
                    r = 255 - r;
                    g = 255 - g;
                    b = 255 - b;

                    //set new ARGB value in pixel
                    image.SetPixel(x, y, Color.FromArgb(a, r, g, b));
                }
            }
            pictureBox.Image = image;
        }
        //Lapiciano
        private void Laplaciano()
        {
            double[,] matrix = new double[,] {
                { 0, 1, 0, },
                { 1, -4, 1, },
                { 0, 1, 0, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1.0, 0, true);
            pictureBox.Image = resultBitmap;
        }
        //Substracción de Media
        private void SubstracciónMedia()
        {
            double[,] matrix = new double[,] {
                { -1, -1, -1, },
                { -1, 8, -1, },
                { -1, -1, -1, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1.0, 0, true);
            pictureBox.Image = resultBitmap;
        }
        //Direccional NS
        private void DireccionalNS()
        {
            double[,] matrix = new double[,] {
                { 1,  1,  1, },
                { 1,  -2,  1, },
                { -1,  -1,  -1, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1.0, 0, true);
            pictureBox.Image = resultBitmap;
        }
        //Sobel
        private void Sobel()
        {
            double[,] matrix = new double[,] {
                { -1,  0,  1, },
                { -2,  0,  2, },
                { -1,  0,  1, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1.0, 0, true);
            pictureBox.Image = resultBitmap;
        }
        //Menos-Lapiciano
        private void MenosLaplaciano()
        {
            double[,] matrix = new double[,] {
                { 0, -1, 0, },
                { -1, 5, -1, },
                { 0, -1, 0, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1.0, 0, true);
            pictureBox.Image = resultBitmap;
        }
        private static Bitmap Convulation(Bitmap sourceBitmap, double[,] filterMatrix, double factor = 1, int bias = 0, bool grayscale = false)
        {
            BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
            byte[] resultBuffer = new byte[sourceData.Stride * sourceData.Height];
            Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(sourceData);
            if (grayscale == true)
            {
                float rgb = 0;
                for (int k = 0; k < pixelBuffer.Length; k += 4)
                {
                    rgb = pixelBuffer[k] * 0.11f;
                    rgb += pixelBuffer[k + 1] * 0.59f;
                    rgb += pixelBuffer[k + 2] * 0.3f;

                    pixelBuffer[k] = (byte)rgb;
                    pixelBuffer[k + 1] = pixelBuffer[k];
                    pixelBuffer[k + 2] = pixelBuffer[k];
                    pixelBuffer[k + 3] = 255;
                }
            }

            double blue = 0.0;
            double green = 0.0;
            double red = 0.0;

            int filterWidth = filterMatrix.GetLength(1);
            int filterHeight = filterMatrix.GetLength(0);

            int filterOffset = (filterWidth - 1) / 2;
            int calcOffset = 0;
            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY <
                sourceBitmap.Height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX <
                    sourceBitmap.Width - filterOffset; offsetX++)
                {
                    blue = 0;
                    green = 0;
                    red = 0;

                    byteOffset = offsetY * sourceData.Stride + offsetX * 4;

                    for (int filterY = -filterOffset;
                        filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset;
                            filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * sourceData.Stride);
                            blue += (double)(pixelBuffer[calcOffset]) * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                            green += (double)(pixelBuffer[calcOffset + 1]) * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                            red += (double)(pixelBuffer[calcOffset + 2]) * filterMatrix[filterY + filterOffset, filterX + filterOffset];
                        }
                    }

                    blue = factor * blue + bias;
                    green = factor * green + bias;
                    red = factor * red + bias;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    resultBuffer[byteOffset] = (byte)(blue);
                    resultBuffer[byteOffset + 1] = (byte)(green);
                    resultBuffer[byteOffset + 2] = (byte)(red);
                    resultBuffer[byteOffset + 3] = 255;
                }
            }


            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width,
                                            sourceBitmap.Height);


            BitmapData resultData =
                       resultBitmap.LockBits(new Rectangle(0, 0,
                       resultBitmap.Width, resultBitmap.Height),
                                        ImageLockMode.WriteOnly,
                                    PixelFormat.Format32bppArgb);


            Marshal.Copy(resultBuffer, 0, resultData.Scan0,
                                       resultBuffer.Length);
            resultBitmap.UnlockBits(resultData);


            return resultBitmap;
        }
    }
}

