namespace cinemaautomation
{
    partial class filmlistesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filmlistesi));
            groupBox9 = new GroupBox();
            lblıd = new Label();
            lblFilmadi = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(lblıd);
            groupBox9.Controls.Add(lblFilmadi);
            groupBox9.Controls.Add(button3);
            groupBox9.Controls.Add(pictureBox1);
            groupBox9.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            groupBox9.ForeColor = Color.Black;
            groupBox9.Location = new Point(14, 14);
            groupBox9.Name = "groupBox9";
            groupBox9.Padding = new Padding(15, 3, 3, 3);
            groupBox9.Size = new Size(284, 240);
            groupBox9.TabIndex = 12;
            groupBox9.TabStop = false;
            // 
            // lblıd
            // 
            lblıd.AutoSize = true;
            lblıd.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblıd.Location = new Point(228, 0);
            lblıd.Name = "lblıd";
            lblıd.Size = new Size(52, 21);
            lblıd.TabIndex = 7;
            lblıd.Text = "label1";
            lblıd.Visible = false;
            // 
            // lblFilmadi
            // 
            lblFilmadi.AutoSize = true;
            lblFilmadi.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblFilmadi.Location = new Point(0, 0);
            lblFilmadi.Name = "lblFilmadi";
            lblFilmadi.Size = new Size(52, 21);
            lblFilmadi.TabIndex = 6;
            lblFilmadi.Text = "label1";
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(0, 206);
            button3.Name = "button3";
            button3.Size = new Size(284, 34);
            button3.TabIndex = 5;
            button3.Text = "Görüntüle";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(284, 184);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // filmlistesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(groupBox9);
            Name = "filmlistesi";
            Size = new Size(314, 267);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox9;
        private Button button3;
        public Label lblFilmadi;
        public PictureBox pictureBox1;
        public Label lblıd;
    }
}
