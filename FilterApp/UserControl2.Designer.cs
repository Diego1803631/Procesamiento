
namespace FilterApp
{
    partial class UserControl2
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClearvid = new System.Windows.Forms.Button();
            this.btnImpvid = new System.Windows.Forms.Button();
            this.btnAddvid = new System.Windows.Forms.Button();
            this.lbFiltervid = new System.Windows.Forms.ListBox();
            this.cbFiltervid = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageBox1);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Controls.Add(this.btnClearvid);
            this.panel1.Controls.Add(this.btnImpvid);
            this.panel1.Controls.Add(this.btnAddvid);
            this.panel1.Controls.Add(this.lbFiltervid);
            this.panel1.Controls.Add(this.cbFiltervid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 680);
            this.panel1.TabIndex = 0;
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(20, 29);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(700, 394);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(257, 429);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(176, 429);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClearvid
            // 
            this.btnClearvid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearvid.ForeColor = System.Drawing.Color.White;
            this.btnClearvid.Location = new System.Drawing.Point(257, 456);
            this.btnClearvid.Name = "btnClearvid";
            this.btnClearvid.Size = new System.Drawing.Size(75, 23);
            this.btnClearvid.TabIndex = 11;
            this.btnClearvid.Text = "Clear All";
            this.btnClearvid.UseVisualStyleBackColor = true;
            this.btnClearvid.Click += new System.EventHandler(this.btnClearvid_Click);
            // 
            // btnImpvid
            // 
            this.btnImpvid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImpvid.ForeColor = System.Drawing.Color.White;
            this.btnImpvid.Location = new System.Drawing.Point(20, 429);
            this.btnImpvid.Name = "btnImpvid";
            this.btnImpvid.Size = new System.Drawing.Size(75, 23);
            this.btnImpvid.TabIndex = 9;
            this.btnImpvid.Text = "Import";
            this.btnImpvid.UseVisualStyleBackColor = true;
            this.btnImpvid.Click += new System.EventHandler(this.btnImpvid_Click);
            // 
            // btnAddvid
            // 
            this.btnAddvid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddvid.ForeColor = System.Drawing.Color.White;
            this.btnAddvid.Location = new System.Drawing.Point(176, 456);
            this.btnAddvid.Name = "btnAddvid";
            this.btnAddvid.Size = new System.Drawing.Size(75, 23);
            this.btnAddvid.TabIndex = 10;
            this.btnAddvid.Text = "Add";
            this.btnAddvid.UseVisualStyleBackColor = true;
            this.btnAddvid.Click += new System.EventHandler(this.btnAddvid_Click);
            // 
            // lbFiltervid
            // 
            this.lbFiltervid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbFiltervid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFiltervid.ForeColor = System.Drawing.Color.White;
            this.lbFiltervid.FormattingEnabled = true;
            this.lbFiltervid.Location = new System.Drawing.Point(20, 485);
            this.lbFiltervid.Name = "lbFiltervid";
            this.lbFiltervid.Size = new System.Drawing.Size(400, 145);
            this.lbFiltervid.TabIndex = 8;
            // 
            // cbFiltervid
            // 
            this.cbFiltervid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbFiltervid.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFiltervid.ForeColor = System.Drawing.Color.White;
            this.cbFiltervid.FormattingEnabled = true;
            this.cbFiltervid.Location = new System.Drawing.Point(20, 458);
            this.cbFiltervid.Name = "cbFiltervid";
            this.cbFiltervid.Size = new System.Drawing.Size(150, 21);
            this.cbFiltervid.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.panel1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(1080, 680);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClearvid;
        private System.Windows.Forms.Button btnImpvid;
        private System.Windows.Forms.Button btnAddvid;
        private System.Windows.Forms.ListBox lbFiltervid;
        private System.Windows.Forms.ComboBox cbFiltervid;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPlay;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
