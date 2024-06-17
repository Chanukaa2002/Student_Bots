using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Cache;
using System.IO;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace Student_Bots
{
    internal class Teacher
    {
        //----------------------------------------------DONE---------------------------------------------------
        
        private SqlConnection conn;
        private DatabaseConnection db;
        FormTeacherPanel teacherPanal;

        public Teacher()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
        }
        public void TeacherLogin(String Teacher_Id, String password)
        {
            try
            {
                conn.Open();
                String queary = @"SELECT Teacher_Id,Password From Teacher where Teacher_Id=@Teacher_Id AND Password=@password";
                using (SqlCommand cmd = new SqlCommand(queary, conn))
                {
                    cmd.Parameters.AddWithValue("@Teacher_Id", Teacher_Id);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dtable = new DataTable();
                        adapter.Fill(dtable);

                        if (dtable.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Successful!");
                            
                            teacherPanal = new FormTeacherPanel();
                            Form1AddStudentcs trawTeacherId = new Form1AddStudentcs();
                            //trawTeacherId.catchTeacherId(Teacher_Id.ToString());
                            teacherPanal.Show();

                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password!");
                            FormTeacherLogin teacherLogin = new FormTeacherLogin(); 
                            teacherLogin.Show();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public void TeacherRegistration(String Teacher_Id, String Password, String Teacher_Name, String Class, String Gender, String Nationality, int Age,String Principle_Id)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Teacher WHERE Teacher_Id = @Teacher_Id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Teacher_Id", Teacher_Id);

                object result = command.ExecuteScalar();
                int count = result != null ? Convert.ToInt32(result) : 0;


                if (count > 0)
                {
                    MessageBox.Show("Teacher_Id Already Exists Try another Teacher_Id!!");
                }
                else
                {
                    string Insertquery = @"insert into Teacher(Teacher_Id,Password,Teacher_Name,Class,Gender,Nationality,Age,Principle_Id)
                                           values(@Teacher_Id,@Password,@Teacher_Name,@Class,@Gender,@Nationality,@Age,@Principle_Id);";
                    using (SqlCommand cmd = new SqlCommand(Insertquery, conn))
                    {

                        cmd.Parameters.AddWithValue("@Teacher_Id", Teacher_Id);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Teacher_Name", Teacher_Name);
                        cmd.Parameters.AddWithValue("@Class", Class);
                        cmd.Parameters.AddWithValue("@Gender", Gender);
                        cmd.Parameters.AddWithValue("@Nationality", Nationality);
                        cmd.Parameters.AddWithValue("@Age", Age);
                        cmd.Parameters.AddWithValue("@Principle_Id", Principle_Id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Succesfully Added A Teacher");
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
        
        public void updateTeacher(String Teacher_Id, String Password, String Teacher_Name, String Class, String Gender, String Nationality, int Age, String Principle_Id)
        {
            try
            {
                conn.Open();
                string updateQueary = "update Teacher set Password=@Password , Teacher_Name =@Teacher_Name,Class=@Class,Gender=@Gender ,Nationality=@Nationality,Age=@Age where Teacher_Id=@Teacher_Id";
                using(SqlCommand updateTeacherCmd = new SqlCommand(updateQueary, conn))
                {
                    updateTeacherCmd.Parameters.AddWithValue("@Teacher_Id", Teacher_Id);
                    updateTeacherCmd.Parameters.AddWithValue("@Password", Password);
                    updateTeacherCmd.Parameters.AddWithValue("@Teacher_Name", Teacher_Name);
                    updateTeacherCmd.Parameters.AddWithValue("@Class", Class);
                    updateTeacherCmd.Parameters.AddWithValue("@Gender", Gender);
                    updateTeacherCmd.Parameters.AddWithValue("@Nationality", Nationality);
                    updateTeacherCmd.Parameters.AddWithValue("@Age", Age);
                    updateTeacherCmd.Parameters.AddWithValue("@Principle_Id", Principle_Id);
                    updateTeacherCmd.ExecuteNonQuery();
                }
                
            }
            catch (Exception e)
            {
                throw e;
            }
            finally { conn.Close(); }
        }
        
        public DataTable viewTeacher()
        {
            try
            {
                conn.Open();
                String queary = "Select Teacher_Id,Teacher_Name,Class,Gender,Nationality,Age,Password from Teacher";
                SqlCommand cmd = new SqlCommand(queary, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
            finally { conn.Close(); }

        }

        public DataTable viewTeacherGender()
        {
            try
            {
                conn.Open();
                string query = "SELECT Gender, COUNT(*) as TeacherCount FROM Teacher GROUP BY Gender ";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }


        //public void DeleteTeacher(){}

    }
}
