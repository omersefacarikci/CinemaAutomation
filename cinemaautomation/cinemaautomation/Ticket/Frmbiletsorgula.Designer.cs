namespace cinemaautomation
{
    partial class Frmbiletsorgula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbiletsorgula));
            panel1 = new Panel();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            txtbiletno = new TextBox();
            pictureBox1 = new PictureBox();
            btnsorgula = new Button();
            panel1.SuspendLayout();
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
            panel1.Size = new Size(669, 40);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(50, 50, 52);
            button1.Cursor = Cursors.Hand;
            button1.Dock = DockStyle.Right;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(619, 0);
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
            label1.Font = new Font("Calibri", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Bilet Sorgula";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.FromArgb(50, 50, 52);
            label2.Location = new Point(124, 97);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 3;
            label2.Text = "Bilet Numarası";
            // 
            // txtbiletno
            // 
            txtbiletno.BackColor = Color.LightGray;
            txtbiletno.BorderStyle = BorderStyle.FixedSingle;
            txtbiletno.ForeColor = Color.Black;
            txtbiletno.Location = new Point(242, 97);
            txtbiletno.MaxLength = 10;
            txtbiletno.Name = "txtbiletno";
            txtbiletno.Size = new Size(219, 26);
            txtbiletno.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 90);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnsorgula
            // 
            btnsorgula.BackColor = Color.FromArgb(50, 50, 52);
            btnsorgula.FlatAppearance.BorderSize = 0;
            btnsorgula.ForeColor = Color.WhiteSmoke;
            btnsorgula.Location = new Point(214, 185);
            btnsorgula.Name = "btnsorgula";
            btnsorgula.Size = new Size(288, 40);
            btnsorgula.TabIndex = 6;
            btnsorgula.Text = "Sorgula";
            btnsorgula.UseVisualStyleBackColor = false;
            btnsorgula.Click += btnsorgula_Click;
            // 
            // Frmbiletsorgula
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(669, 293);
            Controls.Add(btnsorgula);
            Controls.Add(txtbiletno);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frmbiletsorgula";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frmbiletsorgula";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox txtbiletno;
        private PictureBox pictureBox1;
        private Button btnsorgula;
    }
}