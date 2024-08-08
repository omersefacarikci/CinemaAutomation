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
    public partial class filmlistesi : UserControl
    {
        public filmlistesi()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFilmDetay frm = new FrmFilmDetay();
            frm.idno = lblıd.Text;
            frm.ShowDialog();
        }
    }
}
