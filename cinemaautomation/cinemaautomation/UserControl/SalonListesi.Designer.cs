namespace cinemaautomation
{
    partial class SalonListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalonListesi));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lblsalonadi = new Label();
            lblkoltuksayisi = new Label();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 52);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(30, 106);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblsalonadi
            // 
            lblsalonadi.AutoSize = true;
            lblsalonadi.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblsalonadi.ForeColor = Color.Black;
            lblsalonadi.Location = new Point(167, 21);
            lblsalonadi.Name = "lblsalonadi";
            lblsalonadi.Size = new Size(47, 20);
            lblsalonadi.TabIndex = 1;
            lblsalonadi.Text = "label1";
            // 
            // lblkoltuksayisi
            // 
            lblkoltuksayisi.AutoSize = true;
            lblkoltuksayisi.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblkoltuksayisi.ForeColor = Color.Black;
            lblkoltuksayisi.Location = new Point(261, 69);
            lblkoltuksayisi.Name = "lblkoltuksayisi";
            lblkoltuksayisi.Size = new Size(47, 20);
            lblkoltuksayisi.TabIndex = 2;
            lblkoltuksayisi.Text = "label2";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 52);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(303, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(30, 106);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(167, 69);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 4;
            label1.Text = "Koltuk Sayısı:";
            // 
            // SalonListesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(lblkoltuksayisi);
            Controls.Add(lblsalonadi);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "SalonListesi";
            Size = new Size(333, 106);
            MouseLeave += ayrıl;
            MouseMove += gel;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        public Label lblsalonadi;
        public Label lblkoltuksayisi;
        private Panel panel2;
        private Label label1;
    }
}
