
namespace FilterApp
{
    partial class Camera
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Camera));
            this.cameraBox = new Emgu.CV.UI.ImageBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbFaces = new System.Windows.Forms.Label();
            this.btnMovement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).BeginInit();
            this.SuspendLayout();
            // 
            // cameraBox
            // 
            this.cameraBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cameraBox.Location = new System.Drawing.Point(67, 34);
            this.cameraBox.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.cameraBox.Name = "cameraBox";
            this.cameraBox.Size = new System.Drawing.Size(933, 484);
            this.cameraBox.TabIndex = 3;
            this.cameraBox.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpen.ForeColor = System.Drawing.Color.White;
            this.btnOpen.Location = new System.Drawing.Point(67, 535);
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(111, 28);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Face Detection";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(305, 536);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(111, 28);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close Camera";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(860, 542);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Faces Detected:";
            // 
            // lbFaces
            // 
            this.lbFaces.AutoSize = true;
            this.lbFaces.ForeColor = System.Drawing.Color.Red;
            this.lbFaces.Location = new System.Drawing.Point(983, 542);
            this.lbFaces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFaces.Name = "lbFaces";
            this.lbFaces.Size = new System.Drawing.Size(16, 17);
            this.lbFaces.TabIndex = 7;
            this.lbFaces.Text = "0";
            // 
            // btnMovement
            // 
            this.btnMovement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMovement.ForeColor = System.Drawing.Color.White;
            this.btnMovement.Location = new System.Drawing.Point(186, 536);
            this.btnMovement.Margin = new System.Windows.Forms.Padding(4);
            this.btnMovement.Name = "btnMovement";
            this.btnMovement.Size = new System.Drawing.Size(111, 28);
            this.btnMovement.TabIndex = 8;
            this.btnMovement.Text = "Movement";
            this.btnMovement.UseVisualStyleBackColor = true;
            this.btnMovement.Click += new System.EventHandler(this.btnMovement_Click);
            // 
            // Camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1067, 594);
            this.Controls.Add(this.btnMovement);
            this.Controls.Add(this.lbFaces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.cameraBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            ((System.ComponentModel.ISupportInitialize)(this.cameraBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox cameraBox;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbFaces;
        private System.Windows.Forms.Button btnMovement;
    }
}