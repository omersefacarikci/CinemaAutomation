
using Microsoft.Data.SqlClient; //SQL veritaban�na ait k�t�phane
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
        //connectionstring dedi�imiz database yolunu projeye eklemeliyiz.
        SqlConnection baglanti = new SqlConnection(@"Data Source=�MER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
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
            if (read.Read()) //E�er okuma i�lemi ba�ar�l� ise
            {
                frmanaform frm = new frmanaform(); //Ana formu a�t�rd�m.
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya Parola bilgisi hatal�.","UYARI");
            }
            baglanti.Close();
            txtkullaniciadi.Text = "";
            txtkullaniciparola.Text = "";
            txtkullaniciadi.Focus(); //��lem hatal� olunca textlerin i�erisini temizle kullanici ad�na imleci konumla dedim.
            //baglanti.Open();
            //if (baglanti.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Giri� Ba�ar�l�");
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
