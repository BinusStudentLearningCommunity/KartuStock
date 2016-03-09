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
    public partial class RegisterNewProduct : Form
    {
        Koneksi kon = new Koneksi();
        mbox mb = new mbox();
        public RegisterNewProduct()
        {
            InitializeComponent();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Rupiah.ToAngka(textBox2.Text).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (int)e.KeyChar == 8)
            {

                e.Handled = false;

            }

            else
            {

                e.Handled = true;

            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                textBox2.Text = Rupiah.ToRupiah(int.Parse(textBox2.Text)).ToString();

            }
            catch (Exception)
            {


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" ||comboBox1.Text == "")
            {
                mb.WarningBox("Isi Terlebih Dahulu");
            }
            else
            {
                kon.insert("Insert Into produk (namaproduk, hargajual, jenisproduk) Values('" + textBox1.Text + "'," + Rupiah.ToAngka(textBox2.Text).ToString() + ",'" + comboBox1.Text + "')");
                mb.InformationBox("Data Telah Tersimpan");
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = -1;
            }

        }
    }
}
