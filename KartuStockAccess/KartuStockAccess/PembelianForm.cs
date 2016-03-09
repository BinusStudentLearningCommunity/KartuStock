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
    public partial class PembelianForm : Form
    {
        Koneksi kon = new Koneksi();
        mbox mb = new mbox();
        int qty;
        String pk="";

        public PembelianForm()
        {
            InitializeComponent();
        }

        private void PembelianForm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            refresh();
            dataGridView1.Columns[0].Visible = false;
            DataGridViewButtonColumn bdelete = new DataGridViewButtonColumn();
            bdelete.HeaderText = "Delete ";
            bdelete.Text = "Delete";
            bdelete.Name = "Delete";
            bdelete.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(bdelete);
        }

        private void refresh()
        {
            dataGridView1.DataSource = kon.select("Select idproduk, namaproduk, jenisproduk, qty from produk");

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int produk = decimal.ToInt16(numqty.Value);
            int penjumlahaan = qty + produk;
            lbltotal.Text = penjumlahaan.ToString();
            try
            {
                int harga = Rupiah.ToAngka(txtharga.Text);
                int hargaTotal = harga * decimal.ToInt16(numqty.Value);
                lblHarga.Text = Rupiah.ToRupiah(hargaTotal);
            }
            catch (Exception)
            {
                 
            }

        }



        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                try
                {
                    int selectedIndex = dataGridView2.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        dataGridView2.Rows.RemoveAt(selectedIndex);
                        dataGridView2.Refresh(); // if needed
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Tidak Dapat Menghilangkan Baris");
                }
            }
            sum();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtharga.Text = "";
                lblHarga.Text = "";
                lbltotal.Text = "";
                numqty.Value = 0;
                int index = e.RowIndex;
                txtProduk.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                qty = int.Parse(dataGridView1.Rows[index].Cells[3].Value.ToString());
                pk = dataGridView1.Rows[index].Cells[0].Value.ToString();

            }
            catch (Exception)
            {
                
 
            }
        }

        private void txtProduk_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtProduk_Leave(object sender, EventArgs e)
        {
            
        }

        private void txtharga_Leave(object sender, EventArgs e)
        {
            try
            {
                txtharga.Text = Rupiah.ToRupiah(int.Parse(txtharga.Text)).ToString();

            }
            catch (Exception)
            {
                

            }
            
        }

        private void txtharga_Enter(object sender, EventArgs e)
        {
            try
            {
                txtharga.Text = Rupiah.ToAngka(txtharga.Text).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int harga = Rupiah.ToAngka(txtharga.Text);
                int hargaTotal = harga * decimal.ToInt16(numqty.Value);
                lblHarga.Text = Rupiah.ToRupiah(hargaTotal);

            }
            catch (Exception)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean flag = true;
            if (pk == "")
            {
                mb.WarningBox("Tolong Pilih Terlebih Dahulu");
            }else
	        {
                if (checkBox1.Checked == true)
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString() == pk)
                        {
                            mb.WarningBox("Dilarang Memasukan Lebih dari 2 Item Yang Sama");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        this.dataGridView2.Rows.Add(pk, txtProduk.Text, numqty.Value.ToString(), "0", txthargabatch.Text, lbltotal.Text,"a");
                        sum();
                      
                    }
                }
                else
                {
                    for (int i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.Rows[i].Cells[0].Value.ToString() == pk)
                        {
                            mb.WarningBox("Dilarang Memasukan Lebih dari 2 Item Yang Sama");
                            flag = false;
                            break;
                        }
                    }
                    if (flag)
                    {
                        this.dataGridView2.Rows.Add(pk, txtProduk.Text, numqty.Value.ToString(), txtharga.Text, lblHarga.Text, lbltotal.Text,"b");
                        sum();
                    }
                }
                txtProduk.Text = "";
                txtharga.Text = "";
                txthargabatch.Text = "";
                lblHarga.Text = "";
                lbltotal.Text = "";
                checkBox1.Checked = false;
                txthargabatch.Enabled = false;
                numqty.Value = 0;
                
	        }
  



        }
        private void sum()
        {
            int sum = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; ++i)
            {

                sum += Rupiah.ToAngka(dataGridView2.Rows[i].Cells[4].Value.ToString());
            }
            lblsum.Text =  Rupiah.ToRupiah(sum);

        }
        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            String random = rnd.Next(1000,2000).ToString(); 
            String idPembelian = DateTime.Now.ToString("dd") + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("MM")+ random;
            kon.insert("INSERT INTO Pembelian values ('" + idPembelian + "', " + Rupiah.ToAngka(lblsum.Text) + ", " + txtdiskon.Text + ",'" + txtket.Text + "',1,'" + DateTime.Now.Date + "') ");
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                String queryUpdate = "update produk set [qty] = " + dataGridView2.Rows[i].Cells[5].Value.ToString() + " where [idproduk] = " + dataGridView2.Rows[i].Cells[0].Value.ToString() + " ";
                kon.insert(queryUpdate);
                String queryInsertDetail = "insert into detailpembelian values('" + idPembelian + "', " + dataGridView2.Rows[i].Cells[0].Value.ToString() + "," + Rupiah.ToAngka(dataGridView2.Rows[i].Cells[3].Value.ToString()) + "," + dataGridView2.Rows[i].Cells[2].Value.ToString() + ")";
                kon.insert(queryInsertDetail);
            }
            mb.InformationBox("Berhasil Disimpan");
            txtharga.Text = "";
            txtProduk.Text = "";
            txtdiskon.Text = "";
            txtket.Text = "";
            lblHarga.Text = "";
            lblsum.Text = "";
            lbltotal.Text = "";
            numqty.Value = 0;
            this.dataGridView2.DataSource = null;
            this.dataGridView2.Rows.Clear();


            refresh();
            
            
        }

        private void dataGridView2_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //int row = e.RowIndex;
            //int sementara = 0;
            //int tampung = 0;

            //if (e.ColumnIndex == 2)
            //{
            //    try
            //    {
                  
            //            sementara = int.Parse(dataGridView2.Rows[row].Cells[2].Value.ToString()) * Rupiah.ToAngka(dataGridView2.Rows[row].Cells[3].Value.ToString());
            //            dataGridView2.Rows[row].Cells[4].Value = Rupiah.ToRupiah(sementara);
            //            tampung = int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString()) + int.Parse(dataGridView2.Rows[row].Cells[2].Value.ToString());
            //            dataGridView2.Rows[row].Cells[5].Value = tampung.ToString();
                 
                    
            //    }
            //    catch (Exception)
            //    {


            //    }
            //}
            //if (e.ColumnIndex == 3)
            //{
            //    try
            //    {
            //        sementara = int.Parse(dataGridView2.Rows[row].Cells[2].Value.ToString()) * Rupiah.ToAngka(dataGridView2.Rows[row].Cells[3].Value.ToString());
            //        dataGridView2.Rows[row].Cells[4].Value = Rupiah.ToRupiah(sementara);
            //        tampung = int.Parse(dataGridView1.Rows[row].Cells[3].Value.ToString()) + int.Parse(dataGridView2.Rows[row].Cells[2].Value.ToString());
            //        dataGridView2.Rows[row].Cells[5].Value = tampung.ToString();
            //    }
            //    catch (Exception)
            //    {


            //    }
            //}
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == 3)
            {
                dataGridView2.Rows[row].Cells[3].Value = Rupiah.ToAngka(dataGridView2.Rows[row].Cells[3].Value.ToString());

            }

        }

        private void dataGridView2_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            if (e.ColumnIndex == 3)
            {
                dataGridView2.Rows[row].Cells[3].Value = Rupiah.ToRupiah(int.Parse(dataGridView2.Rows[row].Cells[3].Value.ToString()));

            }
        }
        private void stateTextbox(Boolean b)
        {
            txtharga.Enabled =!b;
            txthargabatch.Enabled = b;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                stateTextbox(true);
            }
            else
            {
                stateTextbox(false);
            }
        }

        private void txthargabatch_Enter(object sender, EventArgs e)
        {
            try
            {
                txthargabatch.Text = Rupiah.ToAngka(txthargabatch.Text).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void txthargabatch_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txthargabatch_Leave(object sender, EventArgs e)
        {
            try
            {
                txthargabatch.Text = Rupiah.ToRupiah(int.Parse(txthargabatch.Text)).ToString();

            }
            catch (Exception)
            {


            }
        }
    }
}
