using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Bots
{
    internal class Letter
    {
        private SqlConnection conn;
        private DatabaseConnection db;

        public Letter()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
        }

        public DataTable GetIndexList()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Index_No from Student", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }finally { conn.Close(); }

        }
    }
}
