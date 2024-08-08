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
    public partial class frmyonetmenlistes : Form
    {
        public frmyonetmenlistes()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmyonetmenlistes_Load(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Yonetmenler ORDER BY AdveSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                yonetmenlistesictrl arac = new yonetmenlistesictrl();
                arac.label1.Text = oku["AdveSoyad"].ToString();
                arac.lblsayi.Text = oku["ID"].ToString();
                arac.pictureBox1.ImageLocation = oku["Resim"].ToString();
                listepaneli.Controls.Add(arac);
            }
            baglanti.Close();
        }

        private void txtarama_TextChanged(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            SqlCommand ara = new SqlCommand("select * from Yonetmenler WHERE AdveSoyad like '%" + txtarama.Text + "%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                yonetmenlistesictrl arac = new yonetmenlistesictrl();
                arac.label1.Text = oku["AdveSoyad"].ToString();
                arac.lblsayi.Text = oku["ID"].ToString();
                arac.pictureBox1.ImageLocation = oku["Resim"].ToString();
                listepaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
