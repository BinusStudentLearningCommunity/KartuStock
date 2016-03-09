using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KartuStockAccess
{
    public partial class Main : Form
    {
        UserManagement um = null;
        ProductManagement pm = null;
        PembelianForm pf = null;
        viewPenjualaan vpen = null;
        PenjualanForm penf = null;
        TransferGudang tg = null;
        RegisterNewProduct rnp = null;
        public Main()
        {
            InitializeComponent();
        }
        public void openMenu(Form kelas)
        {
 
                //kelas = new UserManagement();
                //kelas.MdiParent = this;
                //kelas.Show();

        }
        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (um == null || um.IsDisposed)
            {
                um = new UserManagement();
                um.MdiParent = this;
                um.Show();
            }
        }

        private void produkManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pm  == null || pm.IsDisposed)
            {
                pm = new ProductManagement();
                pm.MdiParent = this;
                pm.Show();
            }
        }

        private void pembelianFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pf == null || pf.IsDisposed)
            {
                pf = new PembelianForm();
                pf.MdiParent = this;
                pf.Show();
            }
        }

        private void penjualanFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (penf == null || penf.IsDisposed)
            {
                penf = new PenjualanForm();
                penf.MdiParent = this;
                penf.Show();
            }
        }

        private void viewPenjualaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (vpen == null || vpen.IsDisposed)
            {
                vpen = new viewPenjualaan();
                vpen.MdiParent = this;
                vpen.Show();
            }
        }

        private void transferProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tg == null || tg.IsDisposed)
            {
                tg = new TransferGudang();
                tg.MdiParent = this;
                tg.Show();
            }
        }

        private void registerNewProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rnp == null || rnp.IsDisposed)
            {
                rnp = new RegisterNewProduct();
                rnp.MdiParent = this;
                rnp.Show();
            }
        }
    }
}
