using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FilterApp
{
    public partial class UserControl2 : UserControl
    {
        Capture video;
        Image<Bgr, Byte> currentFrame;
        Bitmap temp;
        string selected;

        public UserControl2()
        {
            InitializeComponent();
            cbFiltervid.Items.Add("Laplaciano");
            cbFiltervid.Items.Add("Substracción de Media");
            cbFiltervid.Items.Add("Direccional NS");
            cbFiltervid.Items.Add("Sobel");
            cbFiltervid.Items.Add("Menos-Laplaciano");
            cbFiltervid.Items.Add("Negativo");
        }

        private void btnImpvid_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Files (*.mp4)|*.mp4";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                video = new Capture(ofd.FileName);
                currentFrame = video.QueryFrame().Resize(700, 394, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                imageBox1.Image = currentFrame;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (currentFrame != null)
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("No se agregó ningún video.", "Advertencia");
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentFrame = video.QueryFrame();
            if (currentFrame != null)
            {
                if (selected == null)
                {
                    imageBox1.Image = currentFrame;
                }
                else
                {
                    temp = currentFrame.Bitmap;
                    var classVideo = new Video(temp, imageBox1);
                    classVideo.addFilter(selected);
                }
            }
            else
            {
                timer1.Enabled = false;
            }


        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void btnAddvid_Click(object sender, EventArgs e)
        {
            selected = this.cbFiltervid.GetItemText(this.cbFiltervid.SelectedItem);
            lbFiltervid.Items.Add(selected);
        }

        private void btnClearvid_Click(object sender, EventArgs e)
        {
            lbFiltervid.Items.Clear();
            selected = null;
        }
    }
}
