using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace cinemaautomation
{
    public partial class FrmFilmDetay : Form
    {
        public FrmFilmDetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        public string idno = "";
        private void FrmFilmDetay_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from Filmler Where ID=@p1";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@p1",idno);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                pictureBox1.ImageLocation = oku["Afis"].ToString();
                lblfilmadi.Text = oku["Adı"].ToString();
                label3.Text = oku["Turu"].ToString();
                lblozellık.Text = oku["Özellik"].ToString();
                lblbıcım.Text = oku["Bicimi"].ToString();
                lblyonetmen.Text = oku["Yonetmen"].ToString();
                lbloyuncu.Text = oku["Oyuncu"].ToString();
                lblaciklama.Text = oku["Detay"].ToString();
                lblpuan.Text = oku["Puan"].ToString();
                lblvizyon.Text = oku["Tarih"].ToString();
                lbldurum.Text = oku["Durum"].ToString();
            }
            baglanti.Close();
            if (lbldurum.Text == "0")
            {
                lbldurum.Text = "Film vizyonda";
            }
            else
            {
                lbldurum.Text = "Film vizyonda değil";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
