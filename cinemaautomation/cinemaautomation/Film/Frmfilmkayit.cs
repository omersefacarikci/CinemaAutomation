using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cinemaautomation
{
    public partial class Frmfilmkayit : Form
    {
        public Frmfilmkayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Secilenler", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        string resimyolu = "";
        private void button3_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seçme";
            ofd.Filter = "PNG | *.png | JPG-JPEG | *.jpg; *.jpeg | All Files | *.*";
            ofd.FilterIndex = 3;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = textBox3.Text.Length;
            int geri = 300 - karaktersayisi;
            label2.Text = geri.ToString();
        }

        private void Frmfilmkayit_Load(object sender, EventArgs e)
        {
            yListeAraci();
            oListeAraci();
            bugununtarihi();
        }
        void bugununtarihi()
        {
            numericUpDown1.Value = DateTime.Today.Day;
            numericUpDown2.Value = DateTime.Today.Month;
            numericUpDown3.Value = DateTime.Today.Year;
        }
        void yListeAraci()
        {
            string sorgu = "select * from Yonetmenler ORDER BY AdveSoyad ASC";
            panel2.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = oku["AdveSoyad"].ToString();
                panel2.Controls.Add(arac);
            }
            baglanti.Close();
        }
        void oListeAraci()
        {
            string sorgu = "select * from Oyuncular ORDER BY AdveSoyad ASC";
            foyuncupaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lbladi.Text = oku["AdveSoyad"].ToString();
                foyuncupaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            OyuncuAra();

        }
        void OyuncuAra()
        {

            string sorgu = "select * from Oyuncular WHERE AdveSoyad like '%" + textBox5.Text + "%' collate Turkish_CI_AS";
            foyuncupaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oListeAraci arac = new oListeAraci();
                arac.lbladi.Text = oku["AdveSoyad"].ToString();
                foyuncupaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
        void YonetmenAra()
        {

            string sorgu = "select * from Yonetmenler WHERE AdveSoyad like '%" + textBox1.Text + "%' collate Turkish_CI_AS";
            //COLLATE TURKISH_CI_AS İLE TÜRKÇE KARAKTERLE ARAMA SORUNUNU ORTADAN KALDIRDI.
            panel2.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yListeAraci arac = new yListeAraci();
                arac.lblAdi.Text = oku["AdveSoyad"].ToString();
                panel2.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            YonetmenAra();
        }

        private void lblaksiyon_Click(object sender, EventArgs e)
        {
            if (lblaksiyon.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblaksiyon.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblaksiyon.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblkorku_Click(object sender, EventArgs e)
        {
            if (lblkorku.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblkorku.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblkorku.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblgerilim_Click(object sender, EventArgs e)
        {
            if (lblgerilim.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblgerilim.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblaksiyon.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblromantik_Click(object sender, EventArgs e)
        {
            if (lblromantik.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblromantik.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblromantik.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblkomedi_Click(object sender, EventArgs e)
        {
            if (lblkomedi.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblkomedi.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblkomedi.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblmacera_Click(object sender, EventArgs e)
        {
            if (lblmacera.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblmacera.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblmacera.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblturkce_Click(object sender, EventArgs e)
        {
            if (lblturkce.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblturkce.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblturkce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblingilizce_Click(object sender, EventArgs e)
        {
            if (lblingilizce.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblingilizce.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblingilizce.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblaltyazı_Click(object sender, EventArgs e)
        {
            if (lblaltyazı.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblaltyazı.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblaltyazı.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblsiddet_Click(object sender, EventArgs e)
        {
            if (lblsiddet.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblsiddet.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblsiddet.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lblcinsellik_Click(object sender, EventArgs e)
        {

            if (lblcinsellik.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lblcinsellik.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lblcinsellik.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl7_Click(object sender, EventArgs e)
        {

            if (lbl7.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lbl7.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lbl7.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            if (lbl13.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lbl13.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lbl13.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            if (lbl18.ForeColor == Color.FromArgb(84, 110, 122))

            {
                lbl18.ForeColor = Color.FromArgb(249, 164, 26);
            }
            else
            {
                lbl18.ForeColor = Color.FromArgb(84, 110, 122);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            vizyontarihihesaplaması();
        }
        string vtarih = "";
        string durum = "0";
        void vizyontarihihesaplaması()
        {
            vtarih = numericUpDown1.Value + "-" + numericUpDown2.Value + "-" + numericUpDown3.Value;
            DateTime dvtarih = Convert.ToDateTime(vtarih);
            DateTime buguntarih = DateTime.Today;

            TimeSpan tspan = dvtarih - buguntarih;
            if (tspan.TotalDays < 0)
            {
                MessageBox.Show("Geçmiş tarihlere ait film eklenmesini yapılamaz!");
                bugununtarihi();
            }
            else if (tspan.TotalDays == 0)
            {
                durum = "1";
                MessageBox.Show(textBox4.Text.ToUpper() + " Filmi bugün vizyona girdi.");

            }
            else
            {
                durum = "0";
                MessageBox.Show(textBox4.Text.ToUpper() + " " + tspan.TotalDays.ToString() + " gün sonra vizyona girecektir.");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltarih.Text = DateTime.Now.ToShortDateString();

        }
        string yonetmen = "";
        string oyuncu = "";
        void secilenYonetmen()
        {
            yonetmen = "";
            string sorgu = "select * from Secilenler Where Tur='Yonetmen'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@p", "Yönetmen");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmen += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        void secilenOyuncu()
        {
            oyuncu = "";
            string sorgu = "select * from Secilenler Where Tur='Oyuncu'";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            //komut.Parameters.AddWithValue("@Oyuncu", "oyuncu");
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyuncu += " ," + oku["KISI"].ToString();
            }
            baglanti.Close();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SlateGray;
        }
        string secilenTur = "";
        string secilenozellik = "";
        string secilenBicim = "";
     
        
        private void button2_Click(object sender, EventArgs e)
        {
            secilenYonetmen();
            secilenOyuncu();
            tur();
            ozellik();
            bicim();
            if (textBox4.Text != "" && textBox3.Text != "")
            {
                string sorgu = "insert into Filmler (Adı,Turu,Özellik,Bicimi,Yonetmen,Oyuncu,Detay,Puan,Afis,Tarih,Durum) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)";
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", textBox4.Text.ToUpper());
                if (secilenTur.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p2", secilenTur);
                }
                if (secilenozellik.Length > 10)
                {
                    komut.Parameters.AddWithValue("@p3", secilenozellik.Substring(10));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p3", secilenozellik);
                }
                if (secilenBicim.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p4", secilenBicim);
                }
                if (yonetmen.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p5", yonetmen);
                }
                if (oyuncu.Length > 2)
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu.Substring(2));

                }
                else
                {
                    komut.Parameters.AddWithValue("@p6", oyuncu);
                }

                komut.Parameters.AddWithValue("@p7", textBox3.Text);
                komut.Parameters.AddWithValue("@p8", comboBox1.Text);
                komut.Parameters.AddWithValue("@p9", resimyolu);
                komut.Parameters.AddWithValue("@p10", vtarih);
                komut.Parameters.AddWithValue("@p11", durum);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Film kaydı başarılı bir şekilde kayıt edildi.");
                textBox4.Text = "";
                textBox3.Text = "";
                comboBox1.Text = "";
                textBox4.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen zorunlu alanları doldurunuz.");
            }
            void tur()
            {
                foreach (Control arac in groupBox2.Controls)
                {
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                        {

                        }
                        else
                        {
                            secilenTur += " ," + arac.Text.ToString();
                        }
                    }

                }
            }
            void ozellik()
            {
                foreach (Control arac in groupBox3.Controls)
                {
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                        {

                        }
                        else
                        {
                            secilenozellik += " ," + arac.Text.ToString();
                        }
                    }

                }
            }
            void bicim()
            {
                foreach (Control arac in groupBox4.Controls)
                {
                    if (arac is Label)
                    {
                        if (arac.ForeColor == Color.FromArgb(84, 110, 122))
                        {

                        }
                        else
                        {
                            secilenBicim += " ," + arac.Text.ToString();
                        }
                    }

                }
            }

        }

        
    }

}
