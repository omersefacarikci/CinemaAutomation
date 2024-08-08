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
using System.ComponentModel.DataAnnotations;
namespace cinemaautomation
{
    public partial class FrmSalonKayit : Form
    {
        public FrmSalonKayit()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSalonAdi.Text != "" && cbKoltukSayisi.Text != "")
            {
                baglanti.Open();
                SqlCommand kaydet = new SqlCommand("insert into Salonlar (SalonAdi,KoltukSayisi) values (@SalonAdi,@KoltukSayisi)", baglanti);
                kaydet.Parameters.AddWithValue("@SalonAdi", txtSalonAdi.Text.ToUpper());
                kaydet.Parameters.AddWithValue("@KoltukSayisi", cbKoltukSayisi.Text);
                kaydet.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Salon kaydı başarılı bir şekilde gerçekleşti.");
                txtSalonAdi.Text = "";
                cbKoltukSayisi.Text = "";
                txtSalonAdi.Focus();
                listeGetir();
            }
            else
            {

                MessageBox.Show("Lütfen zorunlu alanları doldurunuz.");
            }

        }

        private void FrmSalonKayit_Load(object sender, EventArgs e)
        {
            listeGetir();
        }
        
        void listeGetir()
        {
            panelsalon.Controls.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Salonlar order by SalonAdi", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                SalonListesi arac = new SalonListesi();
                arac.lblsalonadi.Text = oku["SalonAdi"].ToString();
                arac.lblkoltuksayisi.Text = oku["KoltukSayisi"].ToString();
                panelsalon.Controls.Add(arac);
            }
            baglanti.Close();
        }
    }
}
