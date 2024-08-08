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
    public partial class Frmbiletsorgula : Form
    {
        public Frmbiletsorgula()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsorgula_Click(object sender, EventArgs e)
        {
            if (txtbiletno.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from Biletler WHERE Bkod=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", txtbiletno.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    FrmBiletdetay frm = new FrmBiletdetay();
                    frm.biletNO = txtbiletno.Text.ToString();
                    txtbiletno.Text = "";
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kayıtlı bilet bulunamadı.", "UYARI");
                    baglanti.Close();
                }
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Lütfen bilet numarası giriniz.","UYARI");
            }
           
            
        }
    }
}
