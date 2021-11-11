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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(ucLoadImage, activebar1, btnImpImg);
        }

        private void SetActivePanel(UserControl control, Panel panel, Button button)
        {
            ucLoadImage.Visible = false;
            ucLoadVideo.Visible = false;
            activebar1.Width = 0;
            activebar2.Width = 0;
            activebar3.Width = 0;
            btnImpImg.Width = 200;
            btnImpVid.Width = 200;
            btnFormCamera.Width = 200;

            control.Visible = true;
            panel.Width = 5;
            button.Width = 195;

        }


        private void btnImpImg_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucLoadImage, activebar1, btnImpImg);
        }

        private void btnImpVid_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucLoadVideo, activebar2, btnImpVid);
        }

        private void btnFormCamera_Click(object sender, EventArgs e)
        {
            SetActivePanel(ucLoadImage, activebar3, btnFormCamera);
            Camera camera = new Camera();
            camera.Show();
        }
    }
}
