
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Bots
{
    internal class DatabaseConnection
    {
        

        public static SqlConnection conn;
        public DatabaseConnection()
        {
            try
            {
                //conn = new SqlConnection("Data Source=CHANUKADILSHAN;Initial Catalog=StudentBots;Integrated Security=True;Encrypt=False");
                conn = new SqlConnection("Data Source=DESKTOP-49DCRHM;Initial Catalog=GUI_CW;Integrated Security=True;Encrypt=False");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        public SqlConnection GetSqlConnection()
        {
            return conn;
        }
    }

    
}
