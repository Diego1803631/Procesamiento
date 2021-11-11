
namespace FilterApp
{
    partial class UserControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.imgOriginal = new System.Windows.Forms.PictureBox();
            this.imgFilter = new System.Windows.Forms.PictureBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbFilter = new System.Windows.Forms.ListBox();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.pPhoto = new System.Windows.Forms.Panel();
            this.lbFormat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFilter)).BeginInit();
            this.pPhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgOriginal
            // 
            this.imgOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgOriginal.Image = ((System.Drawing.Image)(resources.GetObject("imgOriginal.Image")));
            this.imgOriginal.Location = new System.Drawing.Point(20, 20);
            this.imgOriginal.Margin = new System.Windows.Forms.Padding(20);
            this.imgOriginal.Name = "imgOriginal";
            this.imgOriginal.Size = new System.Drawing.Size(500, 281);
            this.imgOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOriginal.TabIndex = 0;
            this.imgOriginal.TabStop = false;
            // 
            // imgFilter
            // 
            this.imgFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgFilter.Image = ((System.Drawing.Image)(resources.GetObject("imgFilter.Image")));
            this.imgFilter.Location = new System.Drawing.Point(560, 20);
            this.imgFilter.Margin = new System.Windows.Forms.Padding(20);
            this.imgFilter.Name = "imgFilter";
            this.imgFilter.Size = new System.Drawing.Size(500, 281);
            this.imgFilter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFilter.TabIndex = 1;
            this.imgFilter.TabStop = false;
            // 
            // btnImport
            // 
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.Location = new System.Drawing.Point(20, 343);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 2;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(560, 343);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(257, 372);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(176, 372);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbFilter
            // 
            this.lbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.lbFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbFilter.ForeColor = System.Drawing.Color.White;
            this.lbFilter.FormattingEnabled = true;
            this.lbFilter.Location = new System.Drawing.Point(20, 399);
            this.lbFilter.Name = "lbFilter";
            this.lbFilter.Size = new System.Drawing.Size(400, 145);
            this.lbFilter.TabIndex = 1;
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbFilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbFilter.ForeColor = System.Drawing.Color.White;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Location = new System.Drawing.Point(20, 372);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(150, 21);
            this.cbFilter.TabIndex = 0;
            // 
            // pPhoto
            // 
            this.pPhoto.Controls.Add(this.lbFormat);
            this.pPhoto.Controls.Add(this.imgFilter);
            this.pPhoto.Controls.Add(this.btnClear);
            this.pPhoto.Controls.Add(this.btnImport);
            this.pPhoto.Controls.Add(this.btnAdd);
            this.pPhoto.Controls.Add(this.btnSave);
            this.pPhoto.Controls.Add(this.lbFilter);
            this.pPhoto.Controls.Add(this.imgOriginal);
            this.pPhoto.Controls.Add(this.cbFilter);
            this.pPhoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPhoto.Location = new System.Drawing.Point(0, 0);
            this.pPhoto.Name = "pPhoto";
            this.pPhoto.Size = new System.Drawing.Size(1080, 680);
            this.pPhoto.TabIndex = 5;
            // 
            // lbFormat
            // 
            this.lbFormat.AutoSize = true;
            this.lbFormat.ForeColor = System.Drawing.Color.White;
            this.lbFormat.Location = new System.Drawing.Point(17, 288);
            this.lbFormat.Name = "lbFormat";
            this.lbFormat.Size = new System.Drawing.Size(0, 13);
            this.lbFormat.TabIndex = 5;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Controls.Add(this.pPhoto);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1080, 680);
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFilter)).EndInit();
            this.pPhoto.ResumeLayout(false);
            this.pPhoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgOriginal;
        private System.Windows.Forms.PictureBox imgFilter;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.ListBox lbFilter;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pPhoto;
        private System.Windows.Forms.Label lbFormat;
    }
}
