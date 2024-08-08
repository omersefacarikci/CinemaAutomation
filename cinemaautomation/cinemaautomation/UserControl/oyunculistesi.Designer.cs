namespace cinemaautomation
{
    partial class oyunculistesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oyunculistesi));
            button1 = new Button();
            lblcinsiyet = new Label();
            pbCinsiyet = new PictureBox();
            button2 = new Button();
            lblsayi = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pbCinsiyet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(885, 54);
            button1.Name = "button1";
            button1.Size = new Size(67, 31);
            button1.TabIndex = 15;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblcinsiyet
            // 
            lblcinsiyet.AutoSize = true;
            lblcinsiyet.ForeColor = Color.SlateGray;
            lblcinsiyet.Location = new Point(355, 37);
            lblcinsiyet.Name = "lblcinsiyet";
            lblcinsiyet.Size = new Size(50, 20);
            lblcinsiyet.TabIndex = 14;
            lblcinsiyet.Text = "label2";
            lblcinsiyet.Visible = false;
            // 
            // pbCinsiyet
            // 
            pbCinsiyet.ErrorImage = (Image)resources.GetObject("pbCinsiyet.ErrorImage");
            pbCinsiyet.Image = (Image)resources.GetObject("pbCinsiyet.Image");
            pbCinsiyet.Location = new Point(189, 16);
            pbCinsiyet.Name = "pbCinsiyet";
            pbCinsiyet.Size = new Size(28, 41);
            pbCinsiyet.SizeMode = PictureBoxSizeMode.Zoom;
            pbCinsiyet.TabIndex = 13;
            pbCinsiyet.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 50, 52);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(722, 54);
            button2.Name = "button2";
            button2.Size = new Size(157, 31);
            button2.TabIndex = 12;
            button2.Text = "Görüntüle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblsayi
            // 
            lblsayi.AutoSize = true;
            lblsayi.Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblsayi.ForeColor = Color.SlateGray;
            lblsayi.Location = new Point(936, 3);
            lblsayi.Name = "lblsayi";
            lblsayi.Size = new Size(25, 23);
            lblsayi.TabIndex = 11;
            lblsayi.Text = "ID";
            lblsayi.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(223, 34);
            label1.Name = "label1";
            label1.Size = new Size(98, 22);
            label1.TabIndex = 9;
            label1.Text = "Ad ve Soyad";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 61, 85);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(20, 88);
            panel1.TabIndex = 16;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 61, 85);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(967, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(20, 88);
            panel2.TabIndex = 17;
            // 
            // oyunculistesi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(lblcinsiyet);
            Controls.Add(pbCinsiyet);
            Controls.Add(button2);
            Controls.Add(lblsayi);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "oyunculistesi";
            Size = new Size(987, 88);
            Load += oyunculistesi_Load;
            ((System.ComponentModel.ISupportInitialize)pbCinsiyet).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label lblcinsiyet;
        private PictureBox pbCinsiyet;
        private Button button2;
        public Label lblsayi;
        public PictureBox pictureBox1;
        public Label label1;
        private Panel panel1;
        private Panel panel2;
    }
}
