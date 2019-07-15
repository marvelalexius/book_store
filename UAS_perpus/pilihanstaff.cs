using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_perpus
{
    public partial class pilihanstaff : Form
    {
        public pilihanstaff()
        {
            InitializeComponent();
        }

        private void databuku_Click(object sender, EventArgs e)
        {
            this.Hide();
            tambahbuku registerbuku;
            registerbuku = new tambahbuku();
            registerbuku.Show();
        }

        private void datapinjam_Click(object sender, EventArgs e)
        {
            this.Hide();
            transaksi list_transaksi;
            list_transaksi = new transaksi();
            list_transaksi.Show();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            home home_form = new home();
            home_form.Show();
        }
    }
}
