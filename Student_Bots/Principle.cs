using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Student_Bots
{
    internal class Principle
    {
        private SqlConnection conn;
        private DatabaseConnection db;

        public Principle()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
        }

        public void PrincipleLogin(String password)
        {
            try
            {
                conn.Open();
                String queary = @"SELECT Password From Principle where Password=@password";
                using (SqlCommand cmd = new SqlCommand(queary, conn))
                {
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successful!");
                            FormPrincipalPanal PrinciplePanel = new FormPrincipalPanal();
                            PrinciplePanel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                            FormPrincipalLogin PrincipleLogin = new FormPrincipalLogin();
                            PrincipleLogin.Show();
                            //Auto Closing - Done
                        }
                    }
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        /*
        public void AddTeacher(String Teacher_Id, String Password, String Teacher_Name, String Class, String Gender, String Nationality, int Age,String Principle_Id)
        {
            Teacher teacher = new Teacher();
            teacher.TeacherRegistration(Teacher_Id, Password, Teacher_Name, Class, Gender, Nationality, Age, Principle_Id);
        }
        */
        
    }
}
