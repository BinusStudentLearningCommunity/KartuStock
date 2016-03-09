using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartuStockAccess
{
    public partial class UserManagement : Form
    {
        Koneksi koneksi = new Koneksi();
        mbox mb = new mbox();
        String pk;
        public UserManagement()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

            refresh();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        public void refresh()
        {
           dataGridView1.DataSource = koneksi.select("SELECT * FROM [user]");
           
        }
        public void reset(String isi)
        {
            txtnama.Text = isi;
            txtpassword.Text = isi;
            txtusername.Text = isi;
            cmbjabatan.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnama.Text =="" || txtpassword.Text == "" || txtusername.Text ==""|| cmbjabatan.Text =="")
            {
                mb.WarningBox("Tolong Diisi Terlebih Dahulu!!");
            }
            else
            {
                koneksi.insert("INSERT INTO [user] ([Nama],[Username],[Password],[Jabatan]) VALUES  ('" + txtnama.Text + "','" + txtusername.Text + "','" + txtpassword.Text + "','" + cmbjabatan.Text + "')");
                reset("");
                refresh();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            pk = dataGridView1.Rows[index].Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset("");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            koneksi.insert("DELETE FROM [user] WHERE [id]= "+pk);
            refresh();



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            pk = dataGridView1.Rows[index].Cells[0].Value.ToString();

        }


    }
}
