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
    public partial class Frmsalonatama : Form
    {
        public Frmsalonatama()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frmsalonatama_Load(object sender, EventArgs e)
        {
            bugununtarihi();
            filmadigetir();
            salonadigetir();
            
        }
        void filmadigetir()
        {
            string sorgu = "select * from Filmler";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                string gelentarih = oku["Tarih"].ToString();
                DateTime ftarih = Convert.ToDateTime(gelentarih);
                DateTime bugun = DateTime.Today;
                TimeSpan timee = ftarih - bugun;
                if (timee.TotalDays <= 0)
                {
                    cbfilmadi.Items.Add(oku["Adı"].ToString());
                }

            }
            baglanti.Close();
        }
        void salonadigetir()
        {
            string sorgu = "select * from Salonlar";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbsalon.Items.Add(oku["Salonadi"].ToString());
            }
            baglanti.Close();
        }
        void bugununtarihi()
        {
            numericUpDown1.Value = DateTime.Today.Day;
            numericUpDown2.Value = DateTime.Today.Month;
            numericUpDown3.Value = DateTime.Today.Year;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Tamamla")
            {
                string sorgu = "select DISTINCT Saat from Kontrol WHERE Tarih=@tarih AND Salonadi=@salonadi";
                string tarih = numericUpDown1.Value + "-" + numericUpDown2.Value + "-" + numericUpDown3.Value;
                baglanti.Open();
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("tarih", tarih);
                komut.Parameters.AddWithValue("salonadi", cbsalon.Text.ToString());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    comboBox1.Items.Add(oku["Saat"].ToString());
                }
                baglanti.Close();
                seanskontrol();
                button2.Text = "Oluştur";
                button2.BackColor = Color.FromArgb(50, 50, 52);
            }
            else
            {
                kaydet();
                temizle();
                button2.Text = "Tamamla";
                button2.BackColor = Color.FromArgb(44, 61, 85);
            }
        }
        void kaydet()
        {
            string sorgu = "insert into Kontrol (Filmadı,Tarih,Saat,Salonadi) VALUES (@filmadi,@tarih,@saat,@salonadi)";
            string tarih = numericUpDown1.Value + "-" + numericUpDown2.Text + "-" + numericUpDown3.Value;
            baglanti.Open();
            SqlCommand ekle = new SqlCommand(sorgu,baglanti);
            ekle.Parameters.AddWithValue("filmadi",cbfilmadi.Text);
            ekle.Parameters.AddWithValue("tarih",tarih);
            ekle.Parameters.AddWithValue("saat",lblsecilen.Text);
            ekle.Parameters.AddWithValue("salonadi",cbsalon.Text);
            ekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Salon atama işlemi gerçekleşti", "BİLGİ");
        }
        private void seanssaatleri(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelseans.Controls)
            {
                if (item.Checked)
                {
                    lblsecilen.Text = item.Text.ToString();
                }
            }
        }
        private void btntemizlee_Click(object sender, EventArgs e)
        {
            temizle();
        }
        void temizle()
        {
            cbfilmadi.Items.Clear();
            cbsalon.Items.Clear();
            comboBox1.Items.Clear();
            lblsecilen.Text = "";
            bugununtarihi();
            filmadigetir();
            salonadigetir();
            panelseans.Controls.Clear();
            button2.Text = "Tamamla";
        }
        void seanskontrol()
        {
            panelseans.Controls.Clear();

            for (int i = 10; i <= 22; i++)
            {
                for (int j = 0; j <= 30; j += 30)
                {
                    RadioButton rnd = new RadioButton();
                    
                    rnd.Width = 90;
                    rnd.CheckedChanged += new EventHandler(seanssaatleri);
                        
                    if (j == 0)
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString() + "0";
                    }
                    else
                    {
                        rnd.Text = i.ToString() + ":" + j.ToString();
                    }
                    rnd.Text = i.ToString() + ":" + j.ToString();
                    if (comboBox1.Items.Contains(rnd.Text))
                    {
                        rnd.Visible = false;
                    }

                    panelseans.Controls.Add(rnd);
                }
            }
        }
    }
}
