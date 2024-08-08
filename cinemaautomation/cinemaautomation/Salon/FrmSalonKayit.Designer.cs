namespace cinemaautomation
{
    partial class FrmSalonKayit
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
            label4 = new Label();
            button2 = new Button();
            cbKoltukSayisi = new ComboBox();
            label7 = new Label();
            label3 = new Label();
            txtSalonAdi = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            panelsalon = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.Size = new Size(1018, 40);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 52);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(968, 0);
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
            label1.Location = new Point(3, 7);
            label1.Name = "label1";
            label1.Size = new Size(107, 24);
            label1.TabIndex = 0;
            label1.Text = "Salon Kayıt ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(50, 50, 52);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(cbKoltukSayisi);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSalonAdi);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.SlateGray;
            groupBox1.Location = new Point(62, 183);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(302, 307);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(223, 120);
            label4.Name = "label4";
            label4.Size = new Size(15, 20);
            label4.TabIndex = 14;
            label4.Text = "*";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 61, 85);
            button2.Cursor = Cursors.Hand;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(3, 264);
            button2.Name = "button2";
            button2.Size = new Size(296, 40);
            button2.TabIndex = 13;
            button2.Text = "Kaydet";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cbKoltukSayisi
            // 
            cbKoltukSayisi.FormattingEnabled = true;
            cbKoltukSayisi.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6" });
            cbKoltukSayisi.Location = new Point(18, 121);
            cbKoltukSayisi.Name = "cbKoltukSayisi";
            cbKoltukSayisi.Size = new Size(203, 28);
            cbKoltukSayisi.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(224, 49);
            label7.Name = "label7";
            label7.Size = new Size(15, 20);
            label7.TabIndex = 11;
            label7.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(0, 95);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 2;
            label3.Text = "Koltuk Sayısı";
            // 
            // txtSalonAdi
            // 
            txtSalonAdi.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSalonAdi.Location = new Point(18, 49);
            txtSalonAdi.Name = "txtSalonAdi";
            txtSalonAdi.Size = new Size(203, 25);
            txtSalonAdi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(0, 23);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 0;
            label2.Text = "Salon Adı";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(panelsalon);
            groupBox2.Location = new Point(488, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(372, 433);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            // 
            // panelsalon
            // 
            panelsalon.AutoScroll = true;
            panelsalon.BackColor = Color.FromArgb(44, 61, 85);
            panelsalon.Dock = DockStyle.Fill;
            panelsalon.Location = new Point(3, 21);
            panelsalon.Name = "panelsalon";
            panelsalon.Size = new Size(366, 409);
            panelsalon.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._9987298;
            pictureBox1.Location = new Point(65, 89);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 104);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // FrmSalonKayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(50, 50, 52);
            ClientSize = new Size(1018, 577);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 250);
            Name = "FrmSalonKayit";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmSalonKayit";
            Load += FrmSalonKayit_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private Label label7;
        private Label label3;
        private TextBox txtSalonAdi;
        private Label label2;
        private ComboBox cbKoltukSayisi;
        private Button button2;
        private GroupBox groupBox2;
        private Label label4;
        private FlowLayoutPanel panelsalon;
        private PictureBox pictureBox1;
    }
}