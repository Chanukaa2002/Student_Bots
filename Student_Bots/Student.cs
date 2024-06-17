using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Student_Bots
{
    internal class Student
    {
        //------------------------------------------DONE(ErrorHandling)--------------------------------

        private SqlConnection conn;
        private DatabaseConnection db;

        public Student()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
        }

        

        public void AddStudent(String StudentName , String gender , String grade , String Index, String Admission , String DOB , String GardianName, String Address, byte[] ImgData, String Teacher_Id)
        {

            try
            {
                conn.Open();
                string query = "SELECT * FROM Student WHERE Index_No = @Index_No";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Index_No", Index);

                object result = command.ExecuteScalar();
                int count = result != null ? Convert.ToInt32(result) : 0;


                if (count > 0)
                {
                    MessageBox.Show("Index_No Already Exists Try another Index_No!!");
                }
                else
                {
       
                    string Insertquery = @"insert into Student(Index_No,Student_Name,Gender,Admission_Date,DOB,Gardion_Name,Addresss,img_Path,Grade,Teacher_Id)
                                           values(@Index_No,@Student_Name,@Gender,@Admission_Date,@DOB,@Gardian_Name,@Address,@img_Path,@Grade,@Teacher_Id);";//insert img path later
                    using (SqlCommand cmd = new SqlCommand(Insertquery, conn))
                    {

                        cmd.Parameters.AddWithValue("@Index_No", Index);
                        cmd.Parameters.AddWithValue("@Student_Name", StudentName);
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Admission_Date", Admission);
                        cmd.Parameters.AddWithValue("@DOB", DOB);
                        cmd.Parameters.AddWithValue("@Gardian_Name", GardianName);
                        cmd.Parameters.AddWithValue("@Address", Address);
                        cmd.Parameters.AddWithValue("@img_Path", ImgData);
                        cmd.Parameters.AddWithValue("@Grade", grade);
                        cmd.Parameters.AddWithValue("@Teacher_Id", Teacher_Id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Succesfuly Added A Student");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //MessageBox.Show("Index_No Already Exists Try another Index_No!!");
            }
            finally
            {
                conn.Close();
            }
        }
        
        public DataTable viewStudent()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Index_No,Student_Name,Gender,Grade,Admission_Date,DOB,Gardion_Name,Addresss from Student", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); return null; }
            finally { conn.Close(); }
        }
        
        public void updateStudent(String Student_Name, String Gender, String Grade, String Index_No, String Admission_Date, String DOB, String Gardion_Name, String Addresss, byte[] ImgData, String Teacher_Id)
        {
            try
            {
                conn.Open();
                string updateQueary = "update Student set Student_Name=@Student_Name,Gender=@Gender,Admission_Date=@Admission_Date,DOB=@DOB,Gardion_Name=@Gardion_Name,Addresss=@Addresss,img_Path=@ImgData,Grade=@Grade, Teacher_Id=@Teacher_Id where Index_No=@Index_No";//insert img path
                using (SqlCommand updateStudentCmd = new SqlCommand(updateQueary, conn))
                {
                    updateStudentCmd.Parameters.AddWithValue("@Index_No", Index_No);
                    updateStudentCmd.Parameters.AddWithValue("@Student_Name", Student_Name);
                    updateStudentCmd.Parameters.AddWithValue("@Gender", Gender);
                    updateStudentCmd.Parameters.AddWithValue("@Admission_Date", Admission_Date);
                    updateStudentCmd.Parameters.AddWithValue("@DOB", DOB);
                    updateStudentCmd.Parameters.AddWithValue("@Gardion_Name", Gardion_Name);
                    updateStudentCmd.Parameters.AddWithValue("@Addresss", Addresss);
                    updateStudentCmd.Parameters.AddWithValue("@img_Path", ImgData);
                    updateStudentCmd.Parameters.AddWithValue("@Grade", Grade);
                    updateStudentCmd.Parameters.AddWithValue("@Teacher_Id", Teacher_Id);
                    updateStudentCmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex){ MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
        public DataTable viewByGrade(int grade)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Index_No,Student_Name,Gender,Grade,Admission_Date,DOB,Gardion_Name,Addresss from " +
                                                   "Student where Grade='"+grade+"'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
            finally { conn.Close(); }
        }

        public DataTable viewByIndex(String index)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Index_No,Student_Name,Gender,Grade,Admission_Date,DOB,Gardion_Name,Addresss from Student where Grade='"+index+"'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
            finally { conn.Close(); }
        }

        public DataTable viewStdCount()
        {
            try
            {
                conn.Open();
                string query = "SELECT Grade, COUNT(*) as StudentCount FROM Student GROUP BY Grade ORDER BY CAST(Grade AS INT) ASC";
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
        public DataTable viewStdGender()
        {
            try
            {
                conn.Open();
                string query = "SELECT Gender, COUNT(*) as StudentCount FROM Student GROUP BY Gender ";
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



        //-------------------------------------------------<Work on this!!>-------------------------------------------------//
        public void DeleteStudent(String Index_No)
        {
            try
            {
                //
                conn.Open();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }finally { conn.Close(); }
        }

        
    }
}
