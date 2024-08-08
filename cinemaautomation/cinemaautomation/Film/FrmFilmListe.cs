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
using System.Runtime.Versioning;

namespace cinemaautomation
{
    public partial class FrmFilmListe : Form
    {
        public FrmFilmListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmFilmListe_Load(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            string sorgu = "select * from Filmler ORDER BY ADI ";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                filmlistesi arac = new filmlistesi();
                
                arac.lblFilmadi.Text = oku["Adı"].ToString();
                arac.pictureBox1.ImageLocation = oku["Afis"].ToString();
                arac.lblıd.Text = oku["ID"].ToString();
                listepaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Filmler Where Adı LIKE '%" + txtarama.Text + "%' collate Turkish_CI_AS", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                filmlistesi arac = new filmlistesi();
                arac.lblFilmadi.Text = oku["Adı"].ToString();
                arac.pictureBox1.ImageLocation = oku["Afis"].ToString();
                arac.lblıd.Text = oku["ID"].ToString();
                listepaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }
    }
}
