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
using System.Data.SqlClient;
namespace cinemaautomation
{
    public partial class FrmBiletdetay : Form
    {
        public FrmBiletdetay()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        public string biletNO = "";
        private void FrmBiletdetay_Load(object sender, EventArgs e)
        {
            lblbiletno.Text = biletNO;
            barkodNolustur();
            bilgigetir();
        }
        void bilgigetir()
        {
            string sorgu = "select * from Biletler WHERE Bkod=@kod";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@kod", biletNO);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                lblfilm.Text = oku["Film"].ToString();
                lblfilm2.Text = oku["Film"].ToString();
                lbltel.Text = oku["Telno"].ToString();
                lblad.Text = oku["AdveSoyad"].ToString();
                lblbılet.Text = oku["Tur"].ToString();
                lblseanss.Text = oku["Salon"].ToString();
                lbbsalonadi.Text = oku["Salon"].ToString();
                lbltarih.Text = oku["Tarih"].ToString()+" "+ oku["Saat"].ToString();
                lbltarihsaat.Text = oku["Tarih"].ToString();
                lblıslemtarihi.Text = oku["IslemSaatı"].ToString();
                lblkoltuklar.Text = oku["Koltukno"].ToString();
            }
            baglanti.Close();
        }
        void barkodNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "4893753985739258934579347503845973495394593457934865239050238503475923502835034758934752958034958347639840349530467380463049093860347";
            string kod = "";

            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            lblbarkod1.Text = kod.ToString();
            lblbarkod2.Text = kod.ToString();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
