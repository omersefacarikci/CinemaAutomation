﻿namespace cinemaautomation
{
    partial class frmyonetmenlistes
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
            panel3 = new Panel();
            listepaneli = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            label1.Size = new Size(151, 24);
            label1.TabIndex = 0;
            label1.Text = "Yönetmen Listesi";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 52);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtarama);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1018, 40);
            panel2.TabIndex = 4;
            // 
            // txtarama
            // 
            txtarama.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtarama.Location = new Point(762, 10);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(206, 27);
            txtarama.TabIndex = 1;
            txtarama.Tag = "";
            txtarama.TextChanged += txtarama_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(listepaneli);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 80);
            panel3.Name = "panel3";
            panel3.Size = new Size(1018, 497);
            panel3.TabIndex = 5;
            // 
            // listepaneli
            // 
            listepaneli.AutoScroll = true;
            listepaneli.BackColor = Color.White;
            listepaneli.Controls.Add(pictureBox1);
            listepaneli.Dock = DockStyle.Fill;
            listepaneli.Font = new Font("Trebuchet MS", 10F, FontStyle.Regular, GraphicsUnit.Point, 162);
            listepaneli.Location = new Point(0, 0);
            listepaneli.Name = "listepaneli";
            listepaneli.Size = new Size(1018, 497);
            listepaneli.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 74);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(974, 11);
            label2.Name = "label2";
            label2.Size = new Size(39, 24);
            label2.TabIndex = 2;
            label2.Text = "Ara";
            // 
            // frmyonetmenlistes
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1018, 577);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Trebuchet MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(500, 250);
            Name = "frmyonetmenlistes";
            StartPosition = FormStartPosition.Manual;
            Text = "frmyonetmenlistes";
            Load += frmyonetmenlistes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            listepaneli.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel listepaneli;
        private PictureBox pictureBox1;
        private TextBox txtarama;
        private Label label2;
    }
}