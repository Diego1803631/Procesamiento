using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.VideoSurveillance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilterApp
{
    public partial class Camera : Form
    {
        HaarCascade faceDetected;
        Image<Bgr, Byte> Frame;
        Capture camera;
        Image<Gray, byte> result;
        Image<Gray, byte> grayFace = null;
        public Camera()
        {
            InitializeComponent();
            faceDetected = new HaarCascade("haarcascade_frontalface_default.xml");
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Idle -= FrameProcedure;
            Application.Idle -= FrameProcedure2;
            camera.Dispose();
            cameraBox.Image = null;
            lbFaces.Text = "0";
        }

        private void FrameProcedure(object sender, EventArgs e)
        {
            int faces = 0;
            Color[] labelcolor = {Color.Red, Color.Blue, Color.Green, Color.Yellow, Color.Aqua, Color.Black, Color.Orange, Color.BlueViolet, Color.Azure, Color.Pink};
            Frame = camera.QueryFrame().Resize(700, 394, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            grayFace = Frame.Convert<Gray, Byte>();
            MCvAvgComp[][] facesDetectedNow = grayFace.DetectHaarCascade(faceDetected, 1.2, 10, Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING, new Size(20, 20));
            foreach (MCvAvgComp f in facesDetectedNow[0])
            {
                result = Frame.Copy(f.rect).Convert<Gray, Byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                Frame.Draw(f.rect, new Bgr(labelcolor[faces]), 3);
                faces += 1;
            }
            lbFaces.Text = faces.ToString();
            cameraBox.Image = Frame;
        }

        private MotionHistory motionHistory;
        private IBGFGDetector<Bgr> forgroundDetector;
        private void btnMovement_Click(object sender, EventArgs e)
        {
            camera = new Capture();
            camera.QueryFrame();
            Application.Idle += new EventHandler(FrameProcedure2);
        }
        private void FrameProcedure2(object sender, EventArgs e)
        {
            if(camera != null)
            {
                motionHistory = new MotionHistory(1.0, 0.05, 0.5);
            }
            using (Image<Bgr, Byte> image = camera.QueryFrame().Resize(700, 394, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC))
            using (MemStorage storage = new MemStorage()) //create storage for motion components
            {
                if (forgroundDetector == null)
                {
                    forgroundDetector = new BGStatModel<Bgr>(image, Emgu.CV.CvEnum.BG_STAT_TYPE.FGD_STAT_MODEL);
                }

                forgroundDetector.Update(image);
                cameraBox.Image = image;
                motionHistory.Update(forgroundDetector.ForgroundMask);

                double[] minValues, maxValues;
                Point[] minLoc, maxLoc;
                motionHistory.Mask.MinMax(out minValues, out maxValues, out minLoc, out maxLoc);
                Image<Gray, Byte> motionMask = motionHistory.Mask.Mul(255.0 / maxValues[0]);

                Image<Bgr, Byte> motionImage = new Image<Bgr, byte>(motionMask.Size);
                motionImage[0] = motionMask;
                double minArea = 100;
                storage.Clear(); 
                Seq<MCvConnectedComp> motionComponents = motionHistory.GetMotionComponents(storage);

                foreach (MCvConnectedComp comp in motionComponents)
                {
         
                    if (comp.area < minArea) continue;
                    double angle, motionPixelCount;
                    motionHistory.MotionInfo(comp.rect, out angle, out motionPixelCount);
                    if (motionPixelCount < comp.area * 0.05) continue;
                    //DrawMotion(motionImage, comp.rect, angle, new Bgr(Color.Red));
                }
                double overallAngle, overallMotionPixelCount;
                motionHistory.MotionInfo(motionMask.ROI, out overallAngle, out overallMotionPixelCount);
                //DrawMotion(motionImage, motionMask.ROI, overallAngle, new Bgr(Color.Green));
                cameraBox.Image = motionImage;
            }
        }

        private static void DrawMotion(Image<Bgr, Byte> image, Rectangle motionRegion, double angle, Bgr color)
        {
            float circleRadius = (motionRegion.Width + motionRegion.Height) >> 2;
            Point center = new Point(motionRegion.X + motionRegion.Width >> 1, motionRegion.Y + motionRegion.Height >> 1);

            CircleF circle = new CircleF(
               center,
               circleRadius);

            int xDirection = (int)(Math.Cos(angle * (Math.PI / 180.0)) * circleRadius);
            int yDirection = (int)(Math.Sin(angle * (Math.PI / 180.0)) * circleRadius);
            Point pointOnCircle = new Point(
                center.X + xDirection,
                center.Y - yDirection);
            LineSegment2D line = new LineSegment2D(center, pointOnCircle);

            image.Draw(circle, color, 1);
            image.Draw(line, color, 2);
        }
    }
}
