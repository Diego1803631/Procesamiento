using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilterApp
{
    class Image
    {
        Bitmap image;
        Label label;
        PictureBox pictureBox;

        public static object ExtBitmap { get; private set; }

        public Image(Bitmap img, Label lab, PictureBox pic)
        {
            image = img;
            label = lab;
            pictureBox = pic;
        }
        public void getImage()
        {
            try
            {
                label.Text = "Pixel format: " + image.PixelFormat.ToString();
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
            int[,] matrix = new int[,] {
                { 0, 1, 0, },
                { 1, -4, 1, },
                { 0, 1, 0, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1, true);
            pictureBox.Image = resultBitmap;
        }
        //Substracción de Media
        private void SubstracciónMedia()
        {
            int[,] matrix = new int[,] {
                { -1, -1, -1, },
                { -1, 8, -1, },
                { -1, -1, -1, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1, true);
            pictureBox.Image = resultBitmap;
        }
        //Direccional NS
        private void DireccionalNS()
        {
            int[,] matrix = new int[,] {
                { 1,  1,  1, },
                { 1,  -2,  1, },
                { -1,  -1,  -1, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1, true);
            pictureBox.Image = resultBitmap;
        }
        //Sobel
        private void Sobel()
        {
            int[,] matrix = new int[,] {
                { -1,  0,  1, },
                { -2,  0,  2, },
                { -1,  0,  1, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1, true);
            pictureBox.Image = resultBitmap;
        }
        //Menos-Lapiciano
        private void MenosLaplaciano()
        {
            int[,] matrix = new int[,] {
                { 0, -1, 0, },
                { -1, 5, -1, },
                { 0, -1, 0, }
            };
            Bitmap resultBitmap = Convulation(image, matrix, 1, false);
            pictureBox.Image = resultBitmap;
        }
        //Circunvolución
        public static Bitmap Convulation(Bitmap sourceBitmap, int[,] matrixFiltro, int div, bool gris)
        {
            Bitmap img = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            Color imgPixel;
            int Red, Green, Blue;
            int pixelGris;

            if (gris)
            {
                for (int x = 0; x < img.Width; x++)
                {
                    for (int y = 0; y < img.Height; y++)
                    {
                        imgPixel = sourceBitmap.GetPixel(x, y);

                        Red = imgPixel.R;
                        Green = imgPixel.G;
                        Blue = imgPixel.B;

                        pixelGris = (Red + Green + Blue) / 3;

                        if (pixelGris > 255)
                            pixelGris = 255;
                        else if (pixelGris < 0)
                            pixelGris = 0;

                        img.SetPixel(x, y, Color.FromArgb(pixelGris, pixelGris, pixelGris));
                    }
                }
            }

            for (int x = 1; x < img.Width - 1; x++)
            {
                for (int y = 1; y < img.Height - 1; y++)
                {
                    Color[] color = {
                        sourceBitmap.GetPixel(x - 1, y - 1),
                        sourceBitmap.GetPixel(x, y - 1),
                        sourceBitmap.GetPixel(x + 1, y - 1),
                        sourceBitmap.GetPixel(x - 1, y),
                        sourceBitmap.GetPixel(x, y),
                        sourceBitmap.GetPixel(x + 1, y),
                        sourceBitmap.GetPixel(x - 1, y + 1),
                        sourceBitmap.GetPixel(x, y + 1),
                        sourceBitmap.GetPixel(x + 1, y + 1)
                    };

                    color[0] = sourceBitmap.GetPixel(x - 1, y - 1);
                    color[1] = sourceBitmap.GetPixel(x, y - 1);
                    color[2] = sourceBitmap.GetPixel(x + 1, y - 1);
                    color[3] = sourceBitmap.GetPixel(x - 1, y);
                    color[4] = sourceBitmap.GetPixel(x, y);
                    color[5] = sourceBitmap.GetPixel(x + 1, y);
                    color[6] = sourceBitmap.GetPixel(x - 1, y + 1);
                    color[7] = sourceBitmap.GetPixel(x, y + 1);
                    color[8] = sourceBitmap.GetPixel(x + 1, y + 1);

                    //rojo
                    int sumaRojo = color[0].R * matrixFiltro[0, 0]
                                 + color[1].R * matrixFiltro[1, 0]
                                 + color[2].R * matrixFiltro[2, 0]
                                 + color[3].R * matrixFiltro[0, 1]
                                 + color[4].R * matrixFiltro[1, 1]
                                 + color[5].R * matrixFiltro[2, 1]
                                 + color[6].R * matrixFiltro[0, 2]
                                 + color[7].R * matrixFiltro[1, 2]
                                 + color[8].R * matrixFiltro[2, 2];

                    sumaRojo = sumaRojo / div;
                    if (sumaRojo > 255)
                    {
                        sumaRojo = 255;
                    }
                    else if (sumaRojo < 0)
                    {
                        sumaRojo = 0;
                    }

                    //verde
                    int sumaVerde = color[0].R * matrixFiltro[0, 0]
                                  + color[1].R * matrixFiltro[1, 0]
                                  + color[2].R * matrixFiltro[2, 0]
                                  + color[3].R * matrixFiltro[0, 1]
                                  + color[4].R * matrixFiltro[1, 1]
                                  + color[5].R * matrixFiltro[2, 1]
                                  + color[6].R * matrixFiltro[0, 2]
                                  + color[7].R * matrixFiltro[1, 2]
                                  + color[8].R * matrixFiltro[2, 2];

                    sumaVerde = sumaVerde / div;
                    if (sumaVerde > 255)
                    {
                        sumaVerde = 255;
                    }
                    else if (sumaVerde < 0)
                    {
                        sumaVerde = 0;
                    }

                    //azul
                    int sumaAzul = color[0].R * matrixFiltro[0, 0]
                                 + color[1].R * matrixFiltro[1, 0]
                                 + color[2].R * matrixFiltro[2, 0]
                                 + color[3].R * matrixFiltro[0, 1]
                                 + color[4].R * matrixFiltro[1, 1]
                                 + color[5].R * matrixFiltro[2, 1]
                                 + color[6].R * matrixFiltro[0, 2]
                                 + color[7].R * matrixFiltro[1, 2]
                                 + color[8].R * matrixFiltro[2, 2];

                    sumaAzul = sumaAzul / div;
                    if (sumaAzul > 255)
                    {
                        sumaAzul = 255;
                    }
                    else if (sumaAzul < 0)
                    {
                        sumaAzul = 0;
                    }

                    int xyGris = 0;
                    if (gris)
                    {
                        xyGris = (sumaRojo + sumaAzul + sumaVerde) / 3;
                        img.SetPixel(x, y, Color.FromArgb(xyGris, xyGris, xyGris));
                    }
                    else
                    {
                        img.SetPixel(x, y, Color.FromArgb(sumaRojo, sumaAzul, sumaVerde));
                    }

                }
            }

            return img;
        }


    }
}
