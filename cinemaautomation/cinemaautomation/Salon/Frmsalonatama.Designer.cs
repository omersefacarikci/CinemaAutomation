namespace cinemaautomation
{
    partial class Frmsalonatama
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
            groupBox3 = new GroupBox();
            cbfilmadi = new ComboBox();
            groupBox4 = new GroupBox();
            numericUpDown3 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            groupBox5 = new GroupBox();
            panelseans = new FlowLayoutPanel();
            lblseanssec = new Label();
            lblsecilen = new Label();
            groupBox6 = new GroupBox();
            cbsalon = new ComboBox();
            button2 = new Button();
            btntemizlee = new Button();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox1.SuspendLayout();
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
            panel1.Size = new Size(800, 40);
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
            button1.Location = new Point(750, 0);
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
            label1.Size = new Size(128, 28);
            label1.TabIndex = 0;
            label1.Text = "Salon Atama";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cbfilmadi);
            groupBox3.Font = new Font("Calibri", 10.2F);
            groupBox3.ForeColor = Color.Black;
            groupBox3.Location = new Point(12, 64);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(15, 3, 3, 3);
            groupBox3.Size = new Size(292, 53);
            groupBox3.TabIndex = 8;
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
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(numericUpDown3);
            groupBox4.Controls.Add(numericUpDown2);
            groupBox4.Controls.Add(numericUpDown1);
            groupBox4.Font = new Font("Calibri", 10.2F);
            groupBox4.ForeColor = Color.Black;
            groupBox4.Location = new Point(16, 136);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(15, 3, 3, 3);
            groupBox4.Size = new Size(292, 53);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tarih";
            // 
            // numericUpDown3
            // 
            numericUpDown3.BorderStyle = BorderStyle.None;
            numericUpDown3.ForeColor = Color.SlateGray;
            numericUpDown3.Location = new Point(185, 19);
            numericUpDown3.Maximum = new decimal(new int[] { 2030, 0, 0, 0 });
            numericUpDown3.Minimum = new decimal(new int[] { 1990, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(66, 24);
            numericUpDown3.TabIndex = 13;
            numericUpDown3.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            // 
            // numericUpDown2
            // 
            numericUpDown2.BorderStyle = BorderStyle.None;
            numericUpDown2.ForeColor = Color.SlateGray;
            numericUpDown2.Location = new Point(110, 19);
            numericUpDown2.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDown2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(69, 24);
            numericUpDown2.TabIndex = 12;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.None;
            numericUpDown1.ForeColor = Color.SlateGray;
            numericUpDown1.Location = new Point(35, 19);
            numericUpDown1.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(69, 24);
            numericUpDown1.TabIndex = 11;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // groupBox5
            // 
            groupBox5.AutoSize = true;
            groupBox5.Controls.Add(panelseans);
            groupBox5.Controls.Add(lblseanssec);
            groupBox5.Font = new Font("Calibri", 10.2F);
            groupBox5.ForeColor = Color.Black;
            groupBox5.Location = new Point(316, 64);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(15, 3, 3, 3);
            groupBox5.Size = new Size(449, 231);
            groupBox5.TabIndex = 10;
            groupBox5.TabStop = false;
            groupBox5.Text = "Saat";
            // 
            // panelseans
            // 
            panelseans.AutoScroll = true;
            panelseans.Dock = DockStyle.Fill;
            panelseans.ForeColor = Color.Black;
            panelseans.Location = new Point(15, 24);
            panelseans.Name = "panelseans";
            panelseans.Size = new Size(431, 204);
            panelseans.TabIndex = 0;
            // 
            // lblseanssec
            // 
            lblseanssec.AutoSize = true;
            lblseanssec.Location = new Point(90, 0);
            lblseanssec.Name = "lblseanssec";
            lblseanssec.Size = new Size(50, 21);
            lblseanssec.TabIndex = 16;
            lblseanssec.Text = "Seans";
            lblseanssec.Visible = false;
            // 
            // lblsecilen
            // 
            lblsecilen.AutoSize = true;
            lblsecilen.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblsecilen.Location = new Point(650, 332);
            lblsecilen.Name = "lblsecilen";
            lblsecilen.Size = new Size(87, 18);
            lblsecilen.TabIndex = 29;
            lblsecilen.Text = "Koltuk Sayısı";
            lblsecilen.Visible = false;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(cbsalon);
            groupBox6.Font = new Font("Calibri", 10.2F);
            groupBox6.ForeColor = Color.Black;
            groupBox6.Location = new Point(12, 220);
            groupBox6.Name = "groupBox6";
            groupBox6.Padding = new Padding(15, 3, 3, 3);
            groupBox6.Size = new Size(298, 53);
            groupBox6.TabIndex = 11;
            groupBox6.TabStop = false;
            groupBox6.Text = "Salon Adı";
            // 
            // cbsalon
            // 
            cbsalon.Dock = DockStyle.Bottom;
            cbsalon.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            cbsalon.FormattingEnabled = true;
            cbsalon.Location = new Point(15, 24);
            cbsalon.Name = "cbsalon";
            cbsalon.Size = new Size(280, 26);
            cbsalon.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(44, 61, 85);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(16, 305);
            button2.Name = "button2";
            button2.Size = new Size(191, 57);
            button2.TabIndex = 16;
            button2.Text = "Tamamla";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btntemizlee
            // 
            btntemizlee.BackColor = Color.Maroon;
            btntemizlee.Cursor = Cursors.Hand;
            btntemizlee.FlatAppearance.BorderSize = 0;
            btntemizlee.FlatStyle = FlatStyle.Flat;
            btntemizlee.Font = new Font("Calibri", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btntemizlee.ForeColor = Color.WhiteSmoke;
            btntemizlee.Location = new Point(222, 305);
            btntemizlee.Name = "btntemizlee";
            btntemizlee.Size = new Size(88, 57);
            btntemizlee.TabIndex = 34;
            btntemizlee.Text = "Temizle";
            btntemizlee.UseVisualStyleBackColor = false;
            btntemizlee.Click += btntemizlee_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Font = new Font("Calibri", 10.2F);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(331, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(15, 3, 3, 3);
            groupBox1.Size = new Size(298, 53);
            groupBox1.TabIndex = 35;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dolu Saatler";
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Bottom;
            comboBox1.Font = new Font("Trebuchet MS", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(280, 26);
            comboBox1.TabIndex = 0;
            // 
            // Frmsalonatama
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 378);
            Controls.Add(lblsecilen);
            Controls.Add(groupBox1);
            Controls.Add(btntemizlee);
            Controls.Add(button2);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(panel1);
            Font = new Font("Calibri", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(600, 200);
            Name = "Frmsalonatama";
            StartPosition = FormStartPosition.Manual;
            Text = "Frmsalonatama";
            Load += Frmsalonatama_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private GroupBox groupBox3;
        private ComboBox cbfilmadi;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private FlowLayoutPanel panelseans;
        private Label lblseanssec;
        private GroupBox groupBox6;
        private Label lblsecilen;
        private ComboBox cbsalon;
        private Button button2;
        private Button btntemizlee;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private ComboBox comboBox1;
    }
}