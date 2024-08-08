namespace cinemaautomation
{
    partial class FrmFilmListe
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
            panel2 = new Panel();
            txtarama = new TextBox();
            label2 = new Label();
            listepaneli = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            listepaneli.SuspendLayout();
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
            panel1.Size = new Size(997, 40);
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
            button1.Location = new Point(947, 0);
            button1.Name = "button1";
            button1.Size = new Size(50, 40);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(88, 24);
            label1.TabIndex = 0;
            label1.Text = "Film Liste";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 52);
            panel2.Controls.Add(txtarama);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(997, 40);
            panel2.TabIndex = 6;
            // 
            // txtarama
            // 
            txtarama.BackColor = Color.White;
            txtarama.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtarama.Location = new Point(739, 10);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(206, 27);
            txtarama.TabIndex = 1;
            txtarama.Tag = "";
            txtarama.TextChanged += txtarama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(951, 11);
            label2.Name = "label2";
            label2.Size = new Size(39, 24);
            label2.TabIndex = 1;
            label2.Text = "Ara";
            // 
            // listepaneli
            // 
            listepaneli.AutoScroll = true;
            listepaneli.BackColor = Color.White;
            listepaneli.Controls.Add(pictureBox1);
            listepaneli.Dock = DockStyle.Fill;
            listepaneli.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listepaneli.Location = new Point(0, 80);
            listepaneli.Name = "listepaneli";
            listepaneli.Size = new Size(997, 497);
            listepaneli.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FrmFilmListe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(997, 577);
            Controls.Add(listepaneli);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 250);
            Name = "FrmFilmListe";
            StartPosition = FormStartPosition.Manual;
            Text = "FrmFilmListe";
            Load += FrmFilmListe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            listepaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private TextBox txtarama;
        private FlowLayoutPanel listepaneli;
        private PictureBox pictureBox1;
        private Label label2;
    }
}