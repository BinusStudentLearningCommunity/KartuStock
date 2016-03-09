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
    public partial class Login : Form
    {
        Koneksi kon = new Koneksi();
        mbox mb = new mbox();
        public Login()
        {
            InitializeComponent();
        }
        private void reset(String isi)
        {
            txtpass.Text = isi;
            txtuser.Text = isi;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = kon.select("Select * from [user] where [username] = '" + txtuser.Text + "' and [password] = '" + txtpass.Text + "'");
            if (txtuser.Text =="" || txtuser.Text == "")
            {
                mb.WarningBox("Tolong Diisi Terlebih Dahulu Username Atau Passwordnya !!");
            }
            else if (dt.Rows.Count <= 0)
            {
                mb.WarningBox("Salah Username Atau Password !!");
            }
            else
            {
                GlobalVar.User = txtuser.Text;
                GlobalVar.Pass = txtpass.Text;
                MessageBox.Show("berhasil");
                reset("");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            reset("");
        }
    }
}
