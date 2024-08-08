
using Microsoft.Data.SqlClient; //SQL veritabanýna ait kütüphane
using System.Data;
using System.Data.SqlTypes;

namespace cinemaautomation
{
    public partial class frmacilis : Form
    {
        public frmacilis()
        {
            InitializeComponent();
        }
        //connectionstring dediðimiz database yolunu projeye eklemeliyiz.
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sorgula = new SqlCommand("select * from Kullanicilar WHERE KullaniciAdi=@username and KullaniciSifre=@password", baglanti);
            sorgula.Parameters.AddWithValue("@username", txtkullaniciadi.Text);
            sorgula.Parameters.AddWithValue("@password", txtkullaniciparola.Text);
            SqlDataReader read = sorgula.ExecuteReader();
            if (read.Read()) //Eðer okuma iþlemi baþarýlý ise
            {
                frmanaform frm = new frmanaform(); //Ana formu açtýrdým.
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya Parola bilgisi hatalý.","UYARI");
            }
            baglanti.Close();
            txtkullaniciadi.Text = "";
            txtkullaniciparola.Text = "";
            txtkullaniciadi.Focus(); //Ýþlem hatalý olunca textlerin içerisini temizle kullanici adýna imleci konumla dedim.
            //baglanti.Open();
            //if (baglanti.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Giriþ Baþarýlý");
            //}
            //baglanti.Close();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = "";
            txtkullaniciparola.Text = "";
            txtkullaniciadi.Focus();
        }

        
    }
}
