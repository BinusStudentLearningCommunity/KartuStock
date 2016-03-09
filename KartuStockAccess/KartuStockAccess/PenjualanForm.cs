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
    public partial class PenjualanForm : Form
    {
        mbox mb = new mbox();
        Koneksi kon = new Koneksi();
        public PenjualanForm()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void refreshTable()
        {
            this.produkTableAdapter.FillBy1(this.database2DataSet.Produk);
        }

        private void PenjualanForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database2DataSet.Produk' table. You can move, or remove it, as needed.
            //this.produkTableAdapter.Fill(this.database2DataSet.Produk);
            refreshTable();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[8].DefaultCellStyle.NullValue = "0";


        }
        private void sum()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                try
                {
                    sum += Rupiah.ToAngka(dataGridView1.Rows[i].Cells[8].Value.ToString());

                }
                catch (Exception)
                {
                    
                }
            }
            lblsum.Text = Rupiah.ToRupiah(sum);

        }
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                if (e.ColumnIndex == 5)
                {
                    int stock = int.Parse(dataGridView1.Rows[row].Cells[4].Value.ToString());
                    int pengurangan = stock - int.Parse(dataGridView1.Rows[row].Cells[5].Value.ToString());
                    int totalHargaJual = pengurangan * int.Parse(dataGridView1.Rows[row].Cells[7].Value.ToString());
                    if (pengurangan < 0)
                    {
                        mb.WarningBox("Terjadi Kesalahaan Input !!");
                        dataGridView1.Rows[row].Cells[6].Value = "";
                        dataGridView1.Rows[row].Cells[5].Value = "";
                    }
                    else
                    {
                        dataGridView1.Rows[row].Cells[6].Value = pengurangan.ToString();
                        dataGridView1.Rows[row].Cells[8].Value = totalHargaJual.ToString();
                        sum();
                    }
                }
            }
            catch (Exception)
            {
                
            }
        
        }

        private void dataGridView1_Leave(object sender, EventArgs e)
        {
            sum();
        }

        private void dataGridView1_Move(object sender, EventArgs e)
        {
            sum();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sum();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String random = rnd.Next(1000, 2000).ToString();
            String idPenjualaan = DateTime.Now.ToString("dd") + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yyyy") + random;
            kon.insert("Insert into [Penjualan](idPenjualan,Tanggal,ID,TotalPenjualaan) values('" + idPenjualaan + "', '" + DateTime.Now.Date + "',1,'" + Rupiah.ToAngka(lblsum.Text) + "')");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //if (int.Parse(dataGridView1.Rows[i].Cells[8].Value.ToString())> 0)
                //{
                //    MessageBox.Show(i+"");
                //}
                try
                {
                    String queryUpdate = "update produk set [qtyg] = " + dataGridView1.Rows[i].Cells[5].Value.ToString() + " where [idproduk] = " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " ";
                    kon.insert(queryUpdate);
                    String queryInsert = "insert into detailpenjualan values ('" + idPenjualaan + "'," + dataGridView1.Rows[i].Cells[0].Value.ToString() + "," + dataGridView1.Rows[i].Cells[6].Value.ToString() + ","+Rupiah.ToAngka(textBox2.Text)+")";
                    kon.insert(queryInsert);
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[8].Value.ToString());
                    //kon.insert("update set ")
                }
                catch (Exception)
                {
                     
                }

            }
            lblsum.Text = "0";
            mb.InformationBox("Data Telah Tersimpan");
            refreshTable();


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


        //private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        this.produkTableAdapter.FillBy1(this.database2DataSet.Produk);
        //    }
        //    catch (System.Exception ex)
        //    {
        //        System.Windows.Forms.MessageBox.Show(ex.Message);
        //    }

        //}
    }
}
