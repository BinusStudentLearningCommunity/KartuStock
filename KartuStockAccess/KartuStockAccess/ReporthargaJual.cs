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
    public partial class ReporthargaJual : Form
    {
        public ReporthargaJual()
        {
            InitializeComponent();
        }

        private void ReporthargaJual_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database2DataSet.Produk' table. You can move, or remove it, as needed.
            this.ProdukTableAdapter.Fill(this.Database2DataSet.Produk);

            this.reportViewer1.RefreshReport();
        }
    }
}
