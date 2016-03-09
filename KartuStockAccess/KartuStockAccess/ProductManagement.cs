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
    public partial class ProductManagement : Form
    {
        mbox mb = new mbox();
        public ProductManagement()
        {
            InitializeComponent();
        }


        private void ProductManagement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Produk' table. You can move, or remove it, as needed.
            this.produkTableAdapter.Fill(this.database2DataSet.Produk);
 
            JenisProduk.Items.Add("Makanan");
            JenisProduk.Items.Add("Minuman");
            produkDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void produkBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.produkBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.database2DataSet);
            }
            catch (Exception)
            {
                
                mb.WarningBox("Input Tidak Sesuai Format!!");
            }


        }

        private void produkDataGridView_KeyPress(object sender, KeyPressEventArgs e)
        {
  
        }

        private void produkDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void produkDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column1_KeyPress);
            if (produkDataGridView.CurrentCell.ColumnIndex == 2 || produkDataGridView.CurrentCell.ColumnIndex == 3 || produkDataGridView.CurrentCell.ColumnIndex == 4) //Desired Column
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.KeyPress += new KeyPressEventHandler(Column1_KeyPress);
                }
            }
        }
        private void Column1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
