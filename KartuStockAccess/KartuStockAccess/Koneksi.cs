using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartuStockAccess
{
    class Koneksi
    {
        private OleDbConnection bookConn;
        private OleDbCommand oleDbCmd = new OleDbCommand();
        private String connParam = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\dennis\Documents\Visual Studio 2013\Projects\KartuStockAccess\Database2.mdb;Persist Security Info=False";
        private DataTable dt;
        private void open()
        {
            bookConn = new OleDbConnection(connParam);
            bookConn.Open();
        }
        public void insert(String query)
        {
            try
            {
                open();
                oleDbCmd.Connection = bookConn;
                oleDbCmd.CommandText = query;
                oleDbCmd.ExecuteNonQuery();
                bookConn.Close();
            }
            catch (Exception)
            {

                throw;            
            }

        }
        public DataTable select(String query)
        {
            dt = new DataTable();
            dt.Clear();
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(query, connParam);
            OleDbCommandBuilder cBuilder = new OleDbCommandBuilder(dAdapter);
            dAdapter.Fill(dt);
            return dt;
        }
    } 
}
