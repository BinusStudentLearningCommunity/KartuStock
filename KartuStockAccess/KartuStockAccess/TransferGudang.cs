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
    public partial class TransferGudang : Form
    {
        Koneksi kon = new Koneksi();
        Koneksi kon2 = new Koneksi();
        mbox mb = new mbox();
        DataTable dt = new DataTable();
        string hValue;
        public TransferGudang()
        {
            InitializeComponent();
        }

        private void TransferGudang_Load(object sender, EventArgs e)
        {
            dt = kon.select("Select namaproduk, idproduk from produk");
            for(int i = 0 ; i< dt.Rows.Count; i++){
                 comboBox1.Items.Add(new ComboBoxItem(dt.Rows[i][0].ToString(), dt.Rows[i][1].ToString()));
            }
   
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

  

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                hValue = ((ComboBoxItem)comboBox1.SelectedItem).HiddenValue;
                dt = kon.select("Select qty from produk where idproduk = " + hValue + "");
                label3.Text = dt.Rows[0][0].ToString();
                numericUpDown1.Maximum = Convert.ToDecimal(label3.Text);
            }
            catch (Exception)
            {
                
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int barangdisplay = int.Parse(label3.Text) - Convert.ToInt32(numericUpDown1.Value);
            kon.insert("Update [produk] set [qty] = " + barangdisplay.ToString() + ", [qtyg] = " + numericUpDown1.Value.ToString() + " where [idproduk] = "+hValue+"");
            mb.InformationBox("Berhasil Terupdate");
            comboBox1.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            label3.Text = "0";
        }

    }
}
