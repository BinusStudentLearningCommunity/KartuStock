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
    public partial class viewPembelian : Form
    {
        string idpembelian;
        mbox mb = new mbox();

        Koneksi kon = new Koneksi();

        public viewPembelian()
        {
            InitializeComponent();
        }
        public void refreshTable()
        {
            DataTable dt = new DataTable();
            dt = kon.select("Select * from pembelian");
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string tanggalAwal = dateTimePicker1.Value.ToString("MM'/'dd'/'yyyy");
            string tanggalAkhir = dateTimePicker2.Value.ToString("MM'/'dd'/'yyyy");
            dt = kon.select("select * from [pembelian] where [tanggal] between  #" + tanggalAwal + "# and  #" + tanggalAkhir + "#");
            dataGridView1.DataSource = dt;
        }

        private void viewPembelian_Load(object sender, EventArgs e)
        {
            refreshTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                idpembelian = dataGridView1.Rows[row].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                //dt = kon.select("select * from detailpembelian where idpembelian = '" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "'");
                dt = kon.select("SELECT DetailPembelian.IDPembelian, Produk.idproduk, Produk.NamaProduk, DetailPembelian.Harga, DetailPembelian.Jumlah FROM Produk INNER JOIN DetailPembelian ON (Produk.IDProduk = DetailPembelian.IDProduk) AND (Produk.IDProduk = DetailPembelian.IDProduk) AND (Produk.IDProduk = DetailPembelian.IDProduk) where DetailPembelian.idpembelian = '" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "'");

                dataGridView2.DataSource = dt;
                this.dataGridView2.Columns[1].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                idpembelian = dataGridView1.Rows[row].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                dt = kon.select("SELECT DetailPembelian.IDPembelian, Produk.idproduk, Produk.NamaProduk, DetailPembelian.Harga, DetailPembelian.Jumlah FROM Produk INNER JOIN DetailPembelian ON (Produk.IDProduk = DetailPembelian.IDProduk) AND (Produk.IDProduk = DetailPembelian.IDProduk) AND (Produk.IDProduk = DetailPembelian.IDProduk) where DetailPembelian.idpembelian = '" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "'");
                dataGridView2.DataSource = dt;
                this.dataGridView2.Columns[1].Visible = false;
            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idpembelian == "")
            {
                mb.WarningBox("Pilih Terlebih data penjualan yang diinginkan dahulu yang diinginkan !!");
            }
            else
            {
                DataTable dt = new DataTable();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    string selectupdate = "select [qty] from [produk] where [idproduk] = " + dataGridView2.Rows[i].Cells[1].Value.ToString() + "";

                    dt = kon.select(selectupdate);
                    int qty = int.Parse(dt.Rows[0][0].ToString());
                    int pengurangan = qty - int.Parse(dataGridView2.Rows[i].Cells[4].Value.ToString());
                    string queryupdate = "update produk set qty  = " + pengurangan.ToString() + " where idproduk = " + dataGridView2.Rows[i].Cells[1].Value.ToString() + "";
                    kon.insert(queryupdate);
                }
                kon.insert("delete from pembelian where idpembelian ='" + idpembelian + "'");

            }
            mb.InformationBox("Data Berhasil Terhapus");
            idpembelian = "";
            refreshTable();
            dataGridView2.DataSource = null;
           
        }
    }
}
