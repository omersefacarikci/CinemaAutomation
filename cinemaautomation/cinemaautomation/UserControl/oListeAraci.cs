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
    public partial class oListeAraci : UserControl
    {
        public oListeAraci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");

        private void lbladi_Click(object sender, EventArgs e)
        {
            if (lbladi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lbladi.ForeColor = Color.FromArgb(249, 164, 26);


                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Secilenler (KISI,TUR) VALUES (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "Oyuncu");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                lbladi.ForeColor = Color.FromArgb(249, 164, 26);


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Secilenler WHERE KISI=@kisi AND TUR=@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lbladi.Text);
                komut.Parameters.AddWithValue("@tur", "Oyuncu");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void oListeAraci_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Secilenler WHERE KISI=@kisi AND TUR=@tur", baglanti);
            komut.Parameters.AddWithValue("@kisi", lbladi.Text);
            komut.Parameters.AddWithValue("@tur", "Oyuncu");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lbladi.ForeColor = Color.FromArgb(249, 164, 26);

            }
            else
            {
                lbladi.ForeColor = Color.FromArgb(17, 28, 43);
            }
            baglanti.Close();
        }
    }
}
