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
    public partial class viewPenjualaan : Form
    {
        string idpenjualan;
        mbox mb = new mbox();

        Koneksi kon = new Koneksi();
        public viewPenjualaan()
        {
            InitializeComponent();
        }

        private void viewPenjualaan_Load(object sender, EventArgs e)
        {
            
            refreshTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
        public void refreshTable()
        {
            DataTable dt = new DataTable();
            dt = kon.select("Select * from penjualan");
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                idpenjualan = dataGridView1.Rows[row].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                dt = kon.select("SELECT DetailPenjualan.IDPenjualan, DetailPenjualan.IDproduk, Produk.NamaProduk, DetailPenjualan.Jumlah FROM Produk INNER JOIN DetailPenjualan ON Produk.IDProduk = DetailPenjualan.IDproduk where DetailPenjualan.idpenjualan = '" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "'");
                dataGridView2.DataSource = dt;
                this.dataGridView2.Columns[1].Visible = false;
            }
            catch (Exception)
            {
                
            }
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                idpenjualan = dataGridView1.Rows[row].Cells[0].Value.ToString();
                DataTable dt = new DataTable();
                dt = kon.select("SELECT DetailPenjualan.IDPenjualan, DetailPenjualan.IDproduk, Produk.NamaProduk, DetailPenjualan.Jumlah FROM Produk INNER JOIN DetailPenjualan ON Produk.IDProduk = DetailPenjualan.IDproduk where DetailPenjualan.idpenjualan = '" + dataGridView1.Rows[row].Cells[0].Value.ToString() + "'");
                dataGridView2.DataSource = dt;
                this.dataGridView2.Columns[1].Visible = false;
            }
            catch (Exception)
            {

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (idpenjualan == "")
            {
                mb.WarningBox("Pilih Terlebih data penjualan yang diinginkan dahulu yang diinginkan !!");
            }
            else
            {
                DataTable dt = new DataTable();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    string selectupdate = "select [qtyg] from [produk] where [idproduk] = " + dataGridView2.Rows[i].Cells[1].Value.ToString() + "";

                    dt = kon.select(selectupdate);
                    int qtyg = int.Parse(dt.Rows[0][0].ToString());
                    int penjumlahaan = qtyg + int.Parse(dataGridView2.Rows[i].Cells[3].Value.ToString());
                    string queryupdate = "update produk set qtyg = " + penjumlahaan.ToString() + " where idproduk = " + dataGridView2.Rows[i].Cells[1].Value.ToString() + "";
                    kon.insert(queryupdate);
                }
                kon.insert("delete from penjualan where idpenjualan ='" + idpenjualan + "'");

            }
            mb.InformationBox("Data Berhasil Terhapus");
            idpenjualan = "";
            refreshTable();
            dataGridView2.DataSource = null;
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //.ToString()
            DataTable dt = new DataTable();
            string tanggalAwal = dateTimePicker1.Value.ToString("MM'/'dd'/'yyyy");
            string tanggalAkhir = dateTimePicker2.Value.ToString("MM'/'dd'/'yyyy");
            dt = kon.select("select * from [penjualan] where [tanggal] between  #" + tanggalAwal + "# and  #" + tanggalAkhir + "#");
            dataGridView1.DataSource = dt;
            //MessageBox.Show("select * from [penjualan] where [tanggal between]  #" + tanggalAwal + "# and  '" + tanggalAkhir + "'");


        }
    }
}
