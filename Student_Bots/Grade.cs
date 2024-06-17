using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Student_Bots
{
    internal class Grade
    {
        private SqlConnection conn;
        private DatabaseConnection db;

        public Grade()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
        }

        public DataTable viewGradeStudent(String Grade)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Student where Grade ='"+Grade+"'", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
            finally { conn.Close(); }
        }

    }
}
