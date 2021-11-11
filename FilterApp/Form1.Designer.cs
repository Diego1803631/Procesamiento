
namespace FilterApp
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pMain = new System.Windows.Forms.Panel();
            this.pSize = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFormCamera = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.activebar2 = new System.Windows.Forms.Panel();
            this.btnImpVid = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImpImg = new System.Windows.Forms.Button();
            this.activebar1 = new System.Windows.Forms.Panel();
            this.ucLoadVideo = new FilterApp.UserControl2();
            this.ucLoadImage = new FilterApp.UserControl1();
            this.activebar3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pMain.SuspendLayout();
            this.pSize.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pMain.Controls.Add(this.pSize);
            this.pMain.Controls.Add(this.panel1);
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(0, 0);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(1280, 720);
            this.pMain.TabIndex = 1;
            // 
            // pSize
            // 
            this.pSize.Controls.Add(this.ucLoadVideo);
            this.pSize.Controls.Add(this.ucLoadImage);
            this.pSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSize.Location = new System.Drawing.Point(200, 0);
            this.pSize.Name = "pSize";
            this.pSize.Size = new System.Drawing.Size(1080, 720);
            this.pSize.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 720);
            this.panel1.TabIndex = 0;
            // 
            // btnFormCamera
            // 
            this.btnFormCamera.BackColor = System.Drawing.Color.Transparent;
            this.btnFormCamera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormCamera.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormCamera.FlatAppearance.BorderSize = 0;
            this.btnFormCamera.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnFormCamera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFormCamera.ForeColor = System.Drawing.Color.White;
            this.btnFormCamera.Image = ((System.Drawing.Image)(resources.GetObject("btnFormCamera.Image")));
            this.btnFormCamera.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFormCamera.Location = new System.Drawing.Point(0, 0);
            this.btnFormCamera.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormCamera.Name = "btnFormCamera";
            this.btnFormCamera.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.btnFormCamera.Size = new System.Drawing.Size(200, 38);
            this.btnFormCamera.TabIndex = 2;
            this.btnFormCamera.Text = "Open Camera";
            this.btnFormCamera.UseVisualStyleBackColor = false;
            this.btnFormCamera.Click += new System.EventHandler(this.btnFormCamera_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.activebar2);
            this.panel3.Controls.Add(this.btnImpVid);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 38);
            this.panel3.TabIndex = 1;
            // 
            // activebar2
            // 
            this.activebar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(153)))));
            this.activebar2.Dock = System.Windows.Forms.DockStyle.Left;
            this.activebar2.Location = new System.Drawing.Point(0, 0);
            this.activebar2.Name = "activebar2";
            this.activebar2.Size = new System.Drawing.Size(0, 38);
            this.activebar2.TabIndex = 1;
            // 
            // btnImpVid
            // 
            this.btnImpVid.BackColor = System.Drawing.Color.Transparent;
            this.btnImpVid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpVid.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImpVid.FlatAppearance.BorderSize = 0;
            this.btnImpVid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnImpVid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpVid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImpVid.ForeColor = System.Drawing.Color.White;
            this.btnImpVid.Image = ((System.Drawing.Image)(resources.GetObject("btnImpVid.Image")));
            this.btnImpVid.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpVid.Location = new System.Drawing.Point(0, 0);
            this.btnImpVid.Margin = new System.Windows.Forms.Padding(0);
            this.btnImpVid.Name = "btnImpVid";
            this.btnImpVid.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.btnImpVid.Size = new System.Drawing.Size(200, 38);
            this.btnImpVid.TabIndex = 3;
            this.btnImpVid.Text = "Import Videos";
            this.btnImpVid.UseVisualStyleBackColor = false;
            this.btnImpVid.Click += new System.EventHandler(this.btnImpVid_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btnImpImg);
            this.panel2.Controls.Add(this.activebar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 40);
            this.panel2.TabIndex = 1;
            // 
            // btnImpImg
            // 
            this.btnImpImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImpImg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnImpImg.FlatAppearance.BorderSize = 0;
            this.btnImpImg.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.btnImpImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImpImg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImpImg.ForeColor = System.Drawing.Color.White;
            this.btnImpImg.Image = ((System.Drawing.Image)(resources.GetObject("btnImpImg.Image")));
            this.btnImpImg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImpImg.Location = new System.Drawing.Point(0, 0);
            this.btnImpImg.Margin = new System.Windows.Forms.Padding(0);
            this.btnImpImg.Name = "btnImpImg";
            this.btnImpImg.Padding = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.btnImpImg.Size = new System.Drawing.Size(200, 40);
            this.btnImpImg.TabIndex = 1;
            this.btnImpImg.Text = "Import Images";
            this.btnImpImg.UseVisualStyleBackColor = true;
            this.btnImpImg.Click += new System.EventHandler(this.btnImpImg_Click);
            // 
            // activebar1
            // 
            this.activebar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(153)))));
            this.activebar1.Dock = System.Windows.Forms.DockStyle.Left;
            this.activebar1.Location = new System.Drawing.Point(0, 0);
            this.activebar1.Name = "activebar1";
            this.activebar1.Size = new System.Drawing.Size(0, 40);
            this.activebar1.TabIndex = 2;
            // 
            // ucLoadVideo
            // 
            this.ucLoadVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ucLoadVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoadVideo.Location = new System.Drawing.Point(0, 0);
            this.ucLoadVideo.Name = "ucLoadVideo";
            this.ucLoadVideo.Size = new System.Drawing.Size(1080, 720);
            this.ucLoadVideo.TabIndex = 1;
            // 
            // ucLoadImage
            // 
            this.ucLoadImage.BackColor = System.Drawing.Color.Transparent;
            this.ucLoadImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLoadImage.Location = new System.Drawing.Point(0, 0);
            this.ucLoadImage.Name = "ucLoadImage";
            this.ucLoadImage.Size = new System.Drawing.Size(1080, 720);
            this.ucLoadImage.TabIndex = 0;
            // 
            // activebar3
            // 
            this.activebar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(85)))), ((int)(((byte)(153)))));
            this.activebar3.Dock = System.Windows.Forms.DockStyle.Left;
            this.activebar3.Location = new System.Drawing.Point(0, 0);
            this.activebar3.Name = "activebar3";
            this.activebar3.Size = new System.Drawing.Size(0, 38);
            this.activebar3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.activebar3);
            this.panel4.Controls.Add(this.btnFormCamera);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 38);
            this.panel4.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FilterApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pMain.ResumeLayout(false);
            this.pSize.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnImpImg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel activebar1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel activebar2;
        private System.Windows.Forms.Button btnImpVid;
        private System.Windows.Forms.Panel pSize;
        private UserControl1 ucLoadImage;
        private UserControl2 ucLoadVideo;
        private System.Windows.Forms.Button btnFormCamera;
        private System.Windows.Forms.Panel activebar3;
        private System.Windows.Forms.Panel panel4;
    }
}

