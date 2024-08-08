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
    public partial class yListeAraci : UserControl
    {
        public yListeAraci()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");

        private void lblAdi_Click(object sender, EventArgs e)
        {
            if (lblAdi.ForeColor == Color.FromArgb(17, 28, 43))
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);


                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Secilenler (KISI,TUR) VALUES (@kisi,@tur)", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "Yönetmen");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);


                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Secilenler WHERE KISI=@kisi AND TUR=@tur", baglanti);
                komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
                komut.Parameters.AddWithValue("@tur", "Yönetmen");
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }

        private void yListeAraci_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Secilenler WHERE KISI=@kisi AND TUR=@tur", baglanti);
            komut.Parameters.AddWithValue("@kisi", lblAdi.Text);
            komut.Parameters.AddWithValue("@tur", "Yönetmen");
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblAdi.ForeColor = Color.FromArgb(249, 164, 26);

            }
            else
            {
                lblAdi.ForeColor = Color.FromArgb(17, 28, 43);
            }
            baglanti.Close();
        }
    }
}
