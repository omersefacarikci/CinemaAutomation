namespace cinemaautomation
{
    partial class frmacilis
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmacilis));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtkullaniciadi = new TextBox();
            txtkullaniciparola = new TextBox();
            label3 = new Label();
            btntemizle = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(779, 51);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 52);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(729, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 51);
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
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(183, 24);
            label1.TabIndex = 0;
            label1.Text = "Sinema Otomasyonu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(113, 137);
            label2.Name = "label2";
            label2.Size = new Size(113, 24);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı";
            // 
            // txtkullaniciadi
            // 
            txtkullaniciadi.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkullaniciadi.Location = new Point(79, 166);
            txtkullaniciadi.Name = "txtkullaniciadi";
            txtkullaniciadi.Size = new Size(241, 29);
            txtkullaniciadi.TabIndex = 2;
            // 
            // txtkullaniciparola
            // 
            txtkullaniciparola.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtkullaniciparola.Location = new Point(79, 253);
            txtkullaniciparola.Name = "txtkullaniciparola";
            txtkullaniciparola.Size = new Size(241, 29);
            txtkullaniciparola.TabIndex = 4;
            txtkullaniciparola.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(113, 224);
            label3.Name = "label3";
            label3.Size = new Size(138, 24);
            label3.TabIndex = 3;
            label3.Text = "Kullanıcı Parola";
            // 
            // btntemizle
            // 
            btntemizle.BackColor = Color.FromArgb(50, 50, 52);
            btntemizle.Cursor = Cursors.Hand;
            btntemizle.FlatAppearance.BorderSize = 0;
            btntemizle.FlatStyle = FlatStyle.Flat;
            btntemizle.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btntemizle.ForeColor = Color.WhiteSmoke;
            btntemizle.Location = new Point(561, 193);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(131, 45);
            btntemizle.TabIndex = 6;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = false;
            btntemizle.Click += btntemizle_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(50, 50, 52);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(405, 193);
            button2.Name = "button2";
            button2.Size = new Size(125, 45);
            button2.TabIndex = 7;
            button2.Text = "Giriş";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 216);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 34);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // frmacilis
            // 
            AutoScaleDimensions = new SizeF(15F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 61, 85);
            ClientSize = new Size(779, 378);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(btntemizle);
            Controls.Add(txtkullaniciparola);
            Controls.Add(label3);
            Controls.Add(txtkullaniciadi);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "frmacilis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox txtkullaniciadi;
        private TextBox txtkullaniciparola;
        private Label label3;
        private Button btntemizle;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
