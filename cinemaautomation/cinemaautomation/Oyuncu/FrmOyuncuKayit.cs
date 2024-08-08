using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemaautomation
{
    public partial class FrmOyuncuKayit : Form
    {
        public FrmOyuncuKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public string resimyolu = "";
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Yükleme";
            ofd.Filter = "PNG | *.png | JPG | *.jpg | JPEG | *.jpeg | All Files | *.*";
            //JPG ve JPEG iki farklı şekilde tanımlamak yerine JPG-JPEG | *.jpg;*.jpeg: Şeklinde tanımlama yapabiliriz.
            ofd.FilterIndex = 4; //Başlanıçda ilk hangisini göreceğimiz indexi seçtim.
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                resimyolu = ofd.FileName.ToString();
            }
        }
        public string cinsiyet = "0";

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "0";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cinsiyet = "1";
        }
        public string bulunanyas = "0";
        void yashesapla()
        {
            string dogumtarih = numericUpDown1.Value.ToString() + "-" + numericUpDown2.Value.ToString() + "-" + numericUpDown3.Value.ToString();
            DateTime dogumtarihi = Convert.ToDateTime(dogumtarih);
            DateTime bugun = DateTime.Today;
            int yas = bugun.Year - dogumtarihi.Year;
            bulunanyas = yas.ToString();
        }
        void aractemizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox4.Text = "";
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 1;
            numericUpDown3.Value = 2023;
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            label8.Text = "300";
            cinsiyet = "0";
            bulunanyas = "00";
            pictureBox1.ImageLocation = @"C:\Users\Ömer Sefa\Desktop\resimicoo.jpg";
            textBox1.Focus();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int karaktersayisi = textBox4.Text.Length;
            int geri = 300 - karaktersayisi;
            label8.Text = geri.ToString();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button3_Click(object sender, EventArgs e)
        {
            yashesapla();
            if (textBox1.Text != "" && textBox2.Text != "" && textBox4.Text != "" && resimyolu != "")
            {

                string adsoyad = textBox1.Text.ToString().ToUpper() + " " + textBox2.Text.ToString().ToUpper();
                baglanti.Open();
                SqlCommand kayit = new SqlCommand("insert into Oyuncular (AdveSoyad,Cinsiyet,Yas,Biyografi,Resim) values (@AdveSoyad,@Cinsiyet,@Yas,@Biyografi,@Resim)", baglanti);
                kayit.Parameters.AddWithValue("@AdveSoyad", adsoyad);
                kayit.Parameters.AddWithValue("@Cinsiyet", cinsiyet);
                kayit.Parameters.AddWithValue("@Yas", bulunanyas);
                kayit.Parameters.AddWithValue("@Biyografi", textBox4.Text);
                kayit.Parameters.AddWithValue("@Resim", resimyolu);
                kayit.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt işlemi başarılı bir şekilde gerçekleşti.");
                aractemizle();
            }
            else
            {
                MessageBox.Show("Kayıt işlemi başarısız. \nLütfen zorunlu alanları doldurunuz.");

            }
        }
    }
}
