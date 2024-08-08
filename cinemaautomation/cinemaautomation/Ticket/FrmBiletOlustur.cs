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
using Microsoft.VisualBasic;
namespace cinemaautomation
{
    public partial class FrmBiletOlustur : Form
    {
        public FrmBiletOlustur()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=ÖMER;Initial Catalog=SinemaOtomasyonuDB;Integrated Security=True;Trust Server Certificate=True");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmBiletOlustur_Load(object sender, EventArgs e)
        {
            filmadigetir();
            biletNolustur();

        }
        void biletNolustur()
        {
            Random rastgele = new Random();
            string karakterler = "4893753985739258934579347503845973495394593457934865239050238503475923502835034758934752958034958347639840349530467380463049093860347";
            string kod = "";

            for (int i = 1; i < 11; i++)
            {
                kod += karakterler[rastgele.Next(karakterler.Length)];
            }
            txtbarkod.Text = kod.ToString();
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

        private void cbfilmadi_SelectedIndexChanged(object sender, EventArgs e)
        {

            cbtarih.Items.Clear();
            string sorgu = "SELECT DISTINCT Tarih FROM Kontrol WHERE Filmadı=@filmadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("filmadi", cbfilmadi.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cbtarih.Items.Add(oku["Tarih"].ToString());
            }
            baglanti.Close();
        }
        void biletNosorgula()
        {
            string sorgu = "select * from Biletler where Bkod=@no";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@no", txtbarkod.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            if (!oku.Read())
            {
                kaydet();
            }
            else
            {
                biletNolustur();
                baglanti.Close();
                biletNosorgula();
            }
            baglanti.Close();
        }
        void kaydet()
        {
            string sorgu = "insert into Biletler (Bkod,AdveSoyad,Telno,Koltukno,Film,Tarih,Saat,Salon,Tur,IslemSaatı) VALUES (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)";
            baglanti.Close();
            baglanti.Open();
            SqlCommand kayit = new SqlCommand(sorgu, baglanti);
            kayit.Parameters.AddWithValue("p1", txtbarkod.Text.ToString());
            kayit.Parameters.AddWithValue("p2", txtadsoyad.Text.ToUpper().ToString());
            kayit.Parameters.AddWithValue("p3", txttelno.Text.ToString());
            kayit.Parameters.AddWithValue("p4", txtkoltuklar.Text.ToString());
            kayit.Parameters.AddWithValue("p5", cbfilmadi.Text.ToString());
            kayit.Parameters.AddWithValue("p6", cbtarih.Text.ToString());
            kayit.Parameters.AddWithValue("p7", lblseanssec.Text.ToString());
            kayit.Parameters.AddWithValue("p8", cbsalon.Text.ToString());
            kayit.Parameters.AddWithValue("p9", cbbiletturu.Text.ToString());
            kayit.Parameters.AddWithValue("p10", DateTime.Now.ToString());
            kayit.ExecuteNonQuery();
            baglanti.Close();

            string sorgu2 = "UPDATE Kontrol SET Koltuklar=@numara WHERE Filmadı=@filmadi AND Tarih=@tarih AND Saat=saat AND Salonadi=@salonadi";
            baglanti.Open();
            SqlCommand güncelle = new SqlCommand(sorgu2, baglanti);
            if (lblgelenkoltuk.Text.ToString() == "")
            {
                güncelle.Parameters.AddWithValue("numara", txtkoltuklar.Text.ToString());
            }
            else
            {
                güncelle.Parameters.AddWithValue("numara", lblgelenkoltuk.Text.ToString() + "," + txtkoltuklar.Text.ToString());
            }

            güncelle.Parameters.AddWithValue("filmadi", cbfilmadi.Text.ToString());
            güncelle.Parameters.AddWithValue("tarih", cbtarih.Text.ToString());
            güncelle.Parameters.AddWithValue("saat", lblseanssec.Text.ToString());
            güncelle.Parameters.AddWithValue("salonadi", cbsalon.Text.ToString());
            güncelle.ExecuteNonQuery();
            baglanti.Close();


            MessageBox.Show("Bilet başarılı bir şekilde oluşturuldu.", "BİLGİ");
            salondurumgeldi();
            lblgelenkoltuk.Text = "";
            listegelenkoltuk.Items.Clear();
            lblbelirlenen.Items.Clear();
            txtkoltuklar.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtadsoyad.Text != "" && txtbarkod.Text != "" && txtkoltuklar.Text != "" && txttelno.Text != "" && cbbiletturu.Text != "" && cbfilmadi.Text != "")
            {
                biletNosorgula();

            }
            else
            {
                MessageBox.Show("Lütfen AdSoyad, Bilet numarası, Koltuk Numarası, Telefon numarası, Bilet Türü ve Film adı alanlarını doldurunuz!", "UYARI");

            }


        }
        void sectiklerimiz()
        {
            txtkoltuklar.Text = "";
            foreach (string item in lblbelirlenen.Items)
            {
                txtkoltuklar.Text += "," + item;

            }
            if (txtkoltuklar.Text.Length > 2)
            {
                txtkoltuklar.Text = txtkoltuklar.Text.Substring(2);
            }
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (btn.ForeColor == Color.Black)
            {
                MessageBox.Show("Bu koltuk doludur.", "UYARI");
            }
            else
            {
                if (btn.ForeColor == Color.FromArgb(79, 109, 122))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.chair);
                    btn.ForeColor = Color.WhiteSmoke;
                    lblbelirlenen.Items.Add(btn.Text);
                    sectiklerimiz();

                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.chair__1_);
                    btn.ForeColor = Color.FromArgb(79, 109, 122);
                    lblbelirlenen.Items.Remove(btn.Text);
                    sectiklerimiz();
                }

            }
        }
        private void seanssaat(object sender, EventArgs e)
        {
            foreach (RadioButton item in panelseans.Controls)
            {
                if (item.Checked)
                {
                    lblseanssec.Text = item.Text;
                    cbsalon.Items.Clear();

                    string sorgu = "SELECT DISTINCT Salonadi FROM Kontrol WHERE Filmadı=@filmadi AND Tarih=@tarih AND Saat=@saat";
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand(sorgu, baglanti);
                    komut.Parameters.AddWithValue("filmadi", cbfilmadi.Text);
                    komut.Parameters.AddWithValue("tarih", cbtarih.Text.ToString());
                    komut.Parameters.AddWithValue("saat", lblseanssec.Text.ToString());
                    SqlDataReader oku = komut.ExecuteReader();
                    while (oku.Read())
                    {
                        cbsalon.Items.Add(oku["Salonadi"].ToString());

                    }
                    baglanti.Close();
                }
            }
        }
        private void cbtarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelseans.Controls.Clear();
            string saatler = "";
            string sorgu = "SELECT DISTINCT Saat FROM Kontrol WHERE Filmadı=@filmadi AND Tarih=@tarih";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("filmadi", cbfilmadi.Text);
            komut.Parameters.AddWithValue("tarih", cbtarih.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                saatler = oku["Saat"].ToString();
                RadioButton rnd = new RadioButton();
                rnd.Text = saatler;
                rnd.CheckedChanged += new EventHandler(seanssaat);
                panelseans.Controls.Add(rnd);
            }
            baglanti.Close();
        }

        private void cbsalon_SelectedIndexChanged(object sender, EventArgs e)
        {
            salondurumgeldi();
        }
        void salondurumgeldi()
        {
            string sorgu = "SELECT * FROM Salonlar WHERE Salonadi=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("salonadi", cbsalon.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkoltuksayisi.Text = oku["KoltukSayisi"].ToString();

            }
            baglanti.Close();
            koltukgetir();
            doldur();
        }
        void doldur()
        {
            koltukpaneli.Controls.Clear();
            int sayi = Convert.ToInt16(lblkoltuksayisi.Text);
            for (int i = 1; i <= sayi; i++)
            {
                Button btn = new Button();
                if (i <= 7)
                {
                    btn.Text = "A" + i.ToString();
                    btn.Name = "A" + i.ToString();
                }
                else if (i <= 14)
                {
                    btn.Text = "B" + (i-7).ToString();
                    btn.Name = "B" + (i-7).ToString();
                }
                else if (i <= 21)
                {
                    btn.Text = "C" + (i - 14 ).ToString();
                    btn.Name = "C" + (i - 14 ).ToString();
                }
                else if (i <= 28)
                {
                    btn.Text = "C" + (i - 21 ).ToString();
                    btn.Name = "C" + (i - 21).ToString();
                }
                else if (i <= 35)
                {
                    btn.Text = "Ç" + (i - 28 ).ToString();
                    btn.Name = "Ç" + (i - 28 ).ToString();
                }
                else if (i <= 42)
                {
                    btn.Text = "D" + (i - 35 ).ToString();
                    btn.Name = "D" + (i - 35 ).ToString();
                }
                else if (i <= 49)
                {
                    btn.Text = "E"+ (i - 42 ).ToString();
                    btn.Name = "E" + (i-42 ).ToString();
                }
                else if (i <= 50)
                {
                    btn.Text = "F" + (i - 49 ).ToString();
                    btn.Name = "F" + (i - 49).ToString();
                }

                btn.Width = 55;
                btn.Height = 55;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                btn.BackColor = Color.White;
                btn.ForeColor = Color.CadetBlue;
                btn.Click += Btn_Click;
                if (listegelenkoltuk.Items.Contains(btn.Text))
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.chair__3_);

                    // btn.BackColor = Color.Red;//seçili
                    btn.ForeColor = Color.Black;
                }
                else
                {
                    btn.Image = (System.Drawing.Image)(Properties.Resources.chair__1_);
                    //btn.BackColor = Color.Black;//boş
                    btn.ForeColor = Color.FromArgb(79, 109, 122);

                }
                koltukpaneli.Controls.Add(btn);
            }
        }
        void koltukgetir()
        {
            lblgelenkoltuk.Text = "";
            panelseans.Controls.Clear();
            string saatler = "";
            string sorgu = "SELECT * FROM Kontrol WHERE Filmadı=@filmadi AND Tarih=@tarih AND Saat=@saat AND Salonadi=@salonadi";
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("filmadi", cbfilmadi.Text);
            komut.Parameters.AddWithValue("tarih", cbtarih.Text.ToString());
            komut.Parameters.AddWithValue("saat", lblseanssec.Text);
            komut.Parameters.AddWithValue("salonadi", cbsalon.Text.ToString());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {

                lblgelenkoltuk.Text += " ," + oku["Koltuklar"].ToString();
                if (lblgelenkoltuk.Text.Length > 2)
                {
                    lblgelenkoltuk.Text = lblgelenkoltuk.Text.Substring(2);
                }
                else
                {
                    lblgelenkoltuk.Text = "";
                }
            }
            baglanti.Close();
            koltukayirma();
        }
        void koltukayirma()
        {
            listegelenkoltuk.Items.Clear();
            string no = "";
            string[] sec;
            no = lblgelenkoltuk.Text.ToString();
            sec = no.Split(',');
            foreach (string bulunan in sec)
            {
                listegelenkoltuk.Items.Add(bulunan);
            }
        }

        private void btntemizlee_Click(object sender, EventArgs e)
        {
            txtadsoyad.Text = "";
            txttelno.Text = "";
            txtkoltuklar.Text = "";
            cbbiletturu.Text = "";
            lblgelenkoltuk.Text = "";
            lblkoltuksayisi.Text = "";
            lblseanssec.Text = "";
            txtbarkod.Text = "";
            cbtarih.Text = "";
            cbsalon.Text = "";
            cbbiletturu.Items.Clear();
            cbtarih.Items.Clear();
            lblbelirlenen.Items.Clear();
            cbsalon.Items.Clear();
            cbbiletturu.Items.Add("Yetişkin");
            cbbiletturu.Items.Add("Öğrenci");
            biletNolustur();
            panelseans.Controls.Clear();
            koltukpaneli.Controls.Clear();
            cbfilmadi.Items.Clear();
            listegelenkoltuk.Items.Clear();
            filmadigetir();
            txtadsoyad.Focus();
            
            
            
;        }
    }
}
        
