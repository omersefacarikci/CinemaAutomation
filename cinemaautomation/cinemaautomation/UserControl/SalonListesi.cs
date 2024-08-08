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
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }

        private void gel(object sender, MouseEventArgs e)
        {
            lblsalonadi.ForeColor = Color.Black;
            this.BackColor = Color.DimGray;
        }

        private void ayrıl(object sender, EventArgs e)
        {
            lblkoltuksayisi.ForeColor = Color.CadetBlue;
            this.BackColor = Color.DimGray;
        }
    }
}
