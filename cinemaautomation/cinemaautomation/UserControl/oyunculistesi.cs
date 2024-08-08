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
    public partial class oyunculistesi : UserControl
    {
        public oyunculistesi()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");

        private void oyunculistesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("p1", lblsayi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblcinsiyet.Text = oku["Cinsiyet"].ToString();
            }
            baglanti.Close();
            if (lblcinsiyet.Text == "0")
            {
                pbCinsiyet.ImageLocation = @"C:\Users\Ömer Sefa\Desktop\kadınnn.png";
            }
            else
            {
                pbCinsiyet.ImageLocation = @"C:\Users\Ömer Sefa\Desktop\erkek.png";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from Oyuncular where ID=@p1", baglanti);
            sil.Parameters.AddWithValue("@p1", lblsayi.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yönetmen bilgisi silindi");
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from Oyuncular WHERE ID=@p1";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("p1", lblsayi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                MessageBox.Show("Biyografi: " + oku["Biyografi"].ToString(), oku["AdveSoyad"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            baglanti.Close();
        }
    }
}
