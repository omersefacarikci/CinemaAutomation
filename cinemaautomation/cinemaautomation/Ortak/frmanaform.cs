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
    public partial class frmanaform : Form
    {
        public frmanaform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close(); Bu programı tamamen kapatmaz.Arka planda tutar.
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel12.BackColor = Color.WhiteSmoke;
            frmyönetmen frm = new frmyönetmen();
            frm.ShowDialog(); //Açılır pencere
                              //Diğer formlarımızı ana sayfa üzerinden açacağım.

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel13.BackColor = Color.WhiteSmoke;
            frmyonetmenlistes frm = new frmyonetmenlistes();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel14.BackColor = Color.WhiteSmoke;
            FrmOyuncuKayit frm = new FrmOyuncuKayit();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel15.BackColor = Color.WhiteSmoke;
            frmoyunculistesi frm = new frmoyunculistesi();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel16.BackColor = Color.WhiteSmoke;
            FrmSalonKayit frm = new FrmSalonKayit();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {  
            panel17.BackColor = Color.WhiteSmoke;
            Frmfilmkayit frm = new Frmfilmkayit();
            frm.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel18.BackColor = Color.WhiteSmoke;
            FrmFilmListe frm = new FrmFilmListe();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel19.BackColor = Color.WhiteSmoke;
            FrmBiletOlustur frm = new FrmBiletOlustur();
            frm.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panel21.BackColor = Color.WhiteSmoke;
            Frmbiletsorgula frm = new Frmbiletsorgula();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel23.BackColor = Color.WhiteSmoke;
            Frmsalonatama frm = new Frmsalonatama();
            frm.ShowDialog();
        }

       
    }
}
