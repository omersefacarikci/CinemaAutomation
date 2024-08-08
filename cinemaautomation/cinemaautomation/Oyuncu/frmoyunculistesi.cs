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
    public partial class frmoyunculistesi : Form
    {
        public frmoyunculistesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void frmoyunculistesi_Load(object sender, EventArgs e)
        {
            listepaneli.Controls.Clear();
            baglanti.Open();
            string sorgu = "select * from Oyuncular ORDER BY AdveSoyad ASC";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                oyunculistesi arac = new oyunculistesi();
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
            SqlCommand ara = new SqlCommand("select * from Oyuncular WHERE AdveSoyad like '%" + txtarama.Text + "%'", baglanti);
            SqlDataReader oku = ara.ExecuteReader();
            while (oku.Read())
            {
                oyunculistesi arac = new oyunculistesi();
                arac.label1.Text = oku["AdveSoyad"].ToString();
                arac.lblsayi.Text = oku["ID"].ToString();
                arac.pictureBox1.ImageLocation = oku["Resim"].ToString();
                listepaneli.Controls.Add(arac);
            }

            baglanti.Close();
        }
    }
}
