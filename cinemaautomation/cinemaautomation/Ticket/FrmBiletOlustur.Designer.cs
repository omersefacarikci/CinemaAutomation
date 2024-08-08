namespace cinemaautomation
{
    partial class FrmBiletOlustur
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
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtadsoyad = new TextBox();
            barkod = new GroupBox();
            txtbarkod = new TextBox();
            groupBox2 = new GroupBox();
            label3 = new Label();
            txttelno = new TextBox();
            groupBox3 = new GroupBox();
            cbfilmadi = new ComboBox();
            groupBox4 = new GroupBox();
            cbtarih = new ComboBox();
            groupBox5 = new GroupBox();
            panelseans = new FlowLayoutPanel();
            lblseanssec = new Label();
            groupBox6 = new GroupBox();
            lblkoltuksayisi = new Label();
            cbsalon = new ComboBox();
            groupBox7 = new GroupBox();
            cbbiletturu = new ComboBox();
            groupBox8 = new GroupBox();
            label5 = new Label();
            txtkoltuklar = new TextBox();
            button2 = new Button();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblgelenkoltuk = new Label();
            listegelenkoltuk = new ListBox();
            lblbelirlenen = new ListBox();
            koltukpaneli = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            btntemizlee = new Button();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            barkod.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 52);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 40);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 52);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(869, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 1;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(94, 24);
            label1.TabIndex = 0;
            label1.Text = "Bilet Kayıt";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtadsoyad);
            groupBox1.Font = new Font("Calibri", 10.2F);
            groupBox1.ForeColor = Color.WhiteSmoke;
            groupBox1.Location = new Point(12, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 3, 3, 3);
            groupBox1.Size = new Size(292, 53);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ad ve Soyad";
            // 
            // txtadsoyad
            // 
            txtadsoyad.BorderStyle = BorderStyle.None;
            txtadsoyad.Location = new Point(9, 26);
            txtadsoyad.Name = "txtadsoyad";
            txtadsoyad.Size = new Size(265, 21);
            txtadsoyad.TabIndex = 0;
            // 
            // barkod
            // 
            barkod.Controls.Add(txtbarkod);
            barkod.Font = new Font("Calibri", 10.2F);
            barkod.ForeColor = Color.WhiteSmoke;
            barkod.Location = new Point(12, 62);
            barkod.Name = "barkod";
            barkod.Padding = new Padding(15, 3, 3, 3);
            barkod.Size = new Size(292, 53);
            barkod.TabIndex = 5;
            barkod.TabStop = false;
            barkod.Text = "Bilet Numarası";
            // 
            // txtbarkod
            // 
            txtbarkod.BorderStyle = BorderStyle.None;
            txtbarkod.Location = new Point(9, 26);
            txtbarkod.Name = "txtbarkod";
            txtbarkod.Size = new Size(265, 21);
            txtbarkod.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txttelno);
            groupBox2.Font = new Font("Calibri", 10.2F);
            groupBox2.ForeColor = Color.WhiteSmoke;
            groupBox2.Location = new Point(12, 181);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(15, 3, 3, 3);
            groupBox2.Size = new Size(292, 53);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Telefon Numarası";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(300, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 21);
            label3.TabIndex = 4;
            label3.Text = "*";
            // 
            // txttelno
            // 
            txttelno.BorderStyle = BorderStyle.None;
            txttelno.Location = new Point(9, 26);
            txttelno.Name = "txttelno";
            txttelno.Size = new Size(265, 21);
            txttelno.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbfilmadi);
            groupBox3.Font = new Font("Calibri", 10.2F);
            groupBox3.ForeColor = Color.WhiteSmoke;
            groupBox3.Location = new Point(12, 240);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 3, 3, 3);
            groupBox3.Size = new Size(292, 53);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Film Adı";
            // 
            // cbfilmadi
            // 
            cbfilmadi.BackColor = Color.White;
            cbfilmadi.Dock = DockStyle.Bottom;
            cbfilmadi.DropDownStyle = ComboBoxStyle.DropDownList;
            cbfilmadi.FlatStyle = FlatStyle.Flat;
            cbfilmadi.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbfilmadi.ForeColor = Color.Black;
            cbfilmadi.FormattingEnabled = true;
            cbfilmadi.Location = new Point(15, 24);
            cbfilmadi.Name = "cbfilmadi";
            cbfilmadi.Size = new Size(274, 26);
            cbfilmadi.TabIndex = 0;
            cbfilmadi.SelectedIndexChanged += cbfilmadi_SelectedIndexChanged;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(cbtarih);
            groupBox4.Font = new Font("Calibri", 10.2F);
            groupBox4.ForeColor = Color.WhiteSmoke;
            groupBox4.Location = new Point(12, 299);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(15, 3, 3, 3);
            groupBox4.Size = new Size(292, 53);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tarih";
            // 
            // cbtarih
            // 
            cbtarih.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbtarih.FormattingEnabled = true;
            cbtarih.Location = new Point(6, 23);
            cbtarih.Name = "cbtarih";
            cbtarih.Size = new Size(280, 26);
            cbtarih.TabIndex = 15;
            cbtarih.SelectedIndexChanged += cbtarih_SelectedIndexChanged;
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(panelseans);
            groupBox5.Controls.Add(lblseanssec);
            groupBox5.Font = new Font("Calibri", 10.2F);
            groupBox5.ForeColor = Color.WhiteSmoke;
            groupBox5.Location = new Point(12, 358);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(15, 3, 3, 3);
            groupBox5.Size = new Size(292, 86);
            groupBox5.TabIndex = 9;
            groupBox5.TabStop = false;
            groupBox5.Text = "Saat";
            // 
            // panelseans
            // 
            panelseans.AutoScroll = true;
            panelseans.Dock = DockStyle.Fill;
            panelseans.Location = new Point(15, 24);
            panelseans.Name = "panelseans";
            panelseans.Size = new Size(274, 59);
            panelseans.TabIndex = 0;
            panelseans.WrapContents = false;
            // 
            // lblseanssec
            // 
            lblseanssec.AutoSize = true;
            lblseanssec.Location = new Point(78, 0);
            lblseanssec.Name = "lblseanssec";
            lblseanssec.Size = new Size(50, 21);
            lblseanssec.TabIndex = 16;
            lblseanssec.Text = "Seans";
            lblseanssec.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(lblkoltuksayisi);
            groupBox6.Controls.Add(cbsalon);
            groupBox6.Font = new Font("Calibri", 10.2F);
            groupBox6.ForeColor = Color.WhiteSmoke;
            groupBox6.Location = new Point(12, 450);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(15, 3, 3, 3);
            groupBox6.Size = new Size(292, 53);
            groupBox6.TabIndex = 10;
            groupBox6.TabStop = false;
            groupBox6.Text = "Salon Adı";
            // 
            // lblkoltuksayisi
            // 
            lblkoltuksayisi.AutoSize = true;
            lblkoltuksayisi.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblkoltuksayisi.Location = new Point(205, 3);
            lblkoltuksayisi.Name = "lblkoltuksayisi";
            lblkoltuksayisi.Size = new Size(87, 18);
            lblkoltuksayisi.TabIndex = 29;
            lblkoltuksayisi.Text = "Koltuk Sayısı";
            // 
            // cbsalon
            // 
            cbsalon.Dock = DockStyle.Bottom;
            cbsalon.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbsalon.FormattingEnabled = true;
            cbsalon.Location = new Point(15, 24);
            cbsalon.Name = "cbsalon";
            cbsalon.Size = new Size(274, 26);
            cbsalon.TabIndex = 0;
            cbsalon.SelectedIndexChanged += cbsalon_SelectedIndexChanged;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(cbbiletturu);
            groupBox7.Font = new Font("Calibri", 10.2F);
            groupBox7.ForeColor = Color.WhiteSmoke;
            groupBox7.Location = new Point(12, 509);
            groupBox7.Name = "groupBox7";
            groupBox7.Padding = new Padding(15, 3, 3, 3);
            groupBox7.Size = new Size(292, 53);
            groupBox7.TabIndex = 11;
            groupBox7.TabStop = false;
            groupBox7.Text = "Bilet Türü";
            // 
            // cbbiletturu
            // 
            cbbiletturu.FlatStyle = FlatStyle.Flat;
            cbbiletturu.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbbiletturu.FormattingEnabled = true;
            cbbiletturu.Items.AddRange(new object[] { "Yetişkin", "Öğrenci" });
            cbbiletturu.Location = new Point(6, 21);
            cbbiletturu.Name = "cbbiletturu";
            cbbiletturu.Size = new Size(268, 26);
            cbbiletturu.TabIndex = 0;
            // 
            // groupBox8
            // 
            groupBox8.Controls.Add(label5);
            groupBox8.Controls.Add(txtkoltuklar);
            groupBox8.Font = new Font("Calibri", 10.2F);
            groupBox8.ForeColor = Color.WhiteSmoke;
            groupBox8.Location = new Point(12, 568);
            groupBox8.Name = "groupBox8";
            groupBox8.Padding = new Padding(15, 3, 3, 3);
            groupBox8.Size = new Size(292, 53);
            groupBox8.TabIndex = 12;
            groupBox8.TabStop = false;
            groupBox8.Text = "Koltuk Numarası";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(312, 0);
            label5.Name = "label5";
            label5.Size = new Size(18, 21);
            label5.TabIndex = 4;
            label5.Text = "*";
            // 
            // txtkoltuklar
            // 
            txtkoltuklar.BorderStyle = BorderStyle.None;
            txtkoltuklar.Location = new Point(9, 26);
            txtkoltuklar.Name = "txtkoltuklar";
            txtkoltuklar.Size = new Size(265, 21);
            txtkoltuklar.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 61, 85);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(12, 639);
            button2.Name = "button2";
            button2.Size = new Size(191, 57);
            button2.TabIndex = 15;
            button2.Text = "Oluştur";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(505, 599);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 19;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.chair__1_;
            pictureBox2.Location = new Point(633, 570);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(65, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.chair;
            pictureBox3.Location = new Point(572, 570);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(65, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.chair__3_;
            pictureBox4.Location = new Point(511, 570);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(63, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(642, 617);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 24;
            label7.Text = "Seçilen";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(520, 617);
            label8.Name = "label8";
            label8.Size = new Size(37, 20);
            label8.TabIndex = 25;
            label8.Text = "Dolu";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(589, 617);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 26;
            label9.Text = "Boş";
            // 
            // lblgelenkoltuk
            // 
            lblgelenkoltuk.AutoSize = true;
            lblgelenkoltuk.Location = new Point(663, 155);
            lblgelenkoltuk.Name = "lblgelenkoltuk";
            lblgelenkoltuk.Size = new Size(106, 20);
            lblgelenkoltuk.TabIndex = 17;
            lblgelenkoltuk.Text = "Seçili Koltuklar";
            // 
            // listegelenkoltuk
            // 
            listegelenkoltuk.FormattingEnabled = true;
            listegelenkoltuk.Location = new Point(663, 178);
            listegelenkoltuk.Name = "listegelenkoltuk";
            listegelenkoltuk.Size = new Size(150, 104);
            listegelenkoltuk.TabIndex = 27;
            // 
            // lblbelirlenen
            // 
            lblbelirlenen.FormattingEnabled = true;
            lblbelirlenen.Location = new Point(663, 299);
            lblbelirlenen.Name = "lblbelirlenen";
            lblbelirlenen.Size = new Size(150, 104);
            lblbelirlenen.TabIndex = 28;
            // 
            // koltukpaneli
            // 
            koltukpaneli.AutoScroll = true;
            koltukpaneli.Location = new Point(385, 107);
            koltukpaneli.Name = "koltukpaneli";
            koltukpaneli.Size = new Size(459, 455);
            koltukpaneli.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(44, 61, 85);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(360, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(513, 27);
            panel2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(229, 3);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 1;
            label2.Text = "Koltuklar";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(44, 61, 85);
            panel3.Location = new Point(0, 40);
            panel3.Name = "panel3";
            panel3.Size = new Size(902, 16);
            panel3.TabIndex = 32;
            // 
            // btntemizlee
            // 
            btntemizlee.BackColor = Color.Maroon;
            btntemizlee.Cursor = Cursors.Hand;
            btntemizlee.FlatAppearance.BorderSize = 0;
            btntemizlee.FlatStyle = FlatStyle.Flat;
            btntemizlee.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btntemizlee.ForeColor = Color.WhiteSmoke;
            btntemizlee.Location = new Point(213, 639);
            btntemizlee.Name = "btntemizlee";
            btntemizlee.Size = new Size(88, 57);
            btntemizlee.TabIndex = 33;
            btntemizlee.Text = "Sil";
            btntemizlee.UseVisualStyleBackColor = false;
            btntemizlee.Click += btntemizlee_Click;
            // 
            // FrmBiletOlustur
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(50, 50, 52);
            ClientSize = new Size(919, 730);
            Controls.Add(btntemizlee);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(koltukpaneli);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(groupBox8);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(barkod);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(listegelenkoltuk);
            Controls.Add(lblbelirlenen);
            Controls.Add(lblgelenkoltuk);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(600, 200);
            Name = "FrmBiletOlustur";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmBiletOlustur";
            Load += FrmBiletOlustur_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            barkod.ResumeLayout(false);
            barkod.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox8.ResumeLayout(false);
            groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtadsoyad;
        private GroupBox barkod;
        private TextBox txtbarkod;
        private GroupBox groupBox2;
        private Label label3;
        private TextBox txttelno;
        private GroupBox groupBox3;
        private ComboBox cbfilmadi;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private GroupBox groupBox6;
        private GroupBox groupBox7;
        private ComboBox cbbiletturu;
        private GroupBox groupBox8;
        private Label label5;
        private TextBox txtkoltuklar;
        private Button button2;
        private ComboBox cbtarih;
        private Label lblseanssec;
        private Label label6;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblgelenkoltuk;
        private ListBox listegelenkoltuk;
        private ListBox lblbelirlenen;
        private ComboBox cbsalon;
        private FlowLayoutPanel panelseans;
        private Label lblkoltuksayisi;
        private FlowLayoutPanel koltukpaneli;
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Button btntemizlee;
    }
}