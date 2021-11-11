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
    public partial class UserControl1 : UserControl
    {
        Bitmap img1;
        Bitmap img2;
        public UserControl1()
        {
            InitializeComponent();
            cbFilter.Items.Add("Lapiciano");
            cbFilter.Items.Add("Substracción de Media");
            cbFilter.Items.Add("Direccional NS");
            cbFilter.Items.Add("Sobel");
            cbFilter.Items.Add("Menos-Lapiciano");
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";

            if (DialogResult.OK == ofile.ShowDialog())
            {
                img1 = new Bitmap(ofile.FileName, true);
                var classImage = new Image(img1, lbFormat, imgOriginal);
                classImage.getImage();
                imgFilter.Image = imgOriginal.Image;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string selected = this.cbFilter.GetItemText(this.cbFilter.SelectedItem);
            lbFilter.Items.Add(selected);
            img2 = new Bitmap(imgFilter.Image);
            var classFilter = new Image(img2, lbFormat, imgFilter);
            classFilter.addFilter(selected);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbFilter.Items.Clear();
            imgFilter.Image = imgOriginal.Image;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "JPG(*.JPG)|*.jpg";
            if(sf.ShowDialog() == DialogResult.OK)
            {
                imgFilter.Image.Save(sf.FileName);
            }
        }
    }
}
