 using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Student_Bots
{
    
    internal class Marks
    {
        private float avg;
        private SqlConnection conn;
        private DatabaseConnection db;

        public Marks()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
        }

        public void addMarks(float sinhala, float buddist, float science, float maths, float history, float english, float op1, float op2, float op3, string indexNo)
        {
            try
            {
                float tot = sinhala + buddist + science + maths + history + english + op1 + op2 + op3;
                avg = tot / 9;
                addAvg(indexNo);
                conn.Open();

                string query = @"INSERT INTO Std_Sub(Student_Index, Subject_Id, marks) 
                                 VALUES (@indexNo, 'S001', @sinhala),
                                        (@indexNo, 'S002', @buddist),
                                        (@indexNo, 'S003', @science),
                                        (@indexNo, 'S004', @maths),
                                        (@indexNo, 'S005', @history),
                                        (@indexNo, 'S006', @english),
                                        (@indexNo, 'S007', @op1),
                                        (@indexNo, 'S008', @op2),
                                        (@indexNo, 'S009', @op3)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@indexNo", indexNo);
                cmd.Parameters.AddWithValue("@sinhala", sinhala);
                cmd.Parameters.AddWithValue("@buddist", buddist);
                cmd.Parameters.AddWithValue("@science", science);
                cmd.Parameters.AddWithValue("@maths", maths);
                cmd.Parameters.AddWithValue("@history", history);
                cmd.Parameters.AddWithValue("@english", english);
                cmd.Parameters.AddWithValue("@op1", op1);
                cmd.Parameters.AddWithValue("@op2", op2);
                cmd.Parameters.AddWithValue("@op3", op3);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Marks not added: " + ex.Message); // Provide more information about the exception
            }
            finally
            {
                conn.Close();
            }
        }
        
        private void addAvg(string indexNo)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Student SET AvgMark = @avg WHERE Index_No = @indexNo";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@avg", avg);
                cmd.Parameters.AddWithValue("@indexNo", indexNo);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Average not added: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable view()
        {
            try
            {
                conn.Open();
                string query = @"SELECT s.Index_No, s.Student_Name, AVG(ss.Marks) AS Avg_marks,
                                 SUM(CASE WHEN ss.Subject_Id = 'S001' THEN ss.Marks ELSE 0 END) AS Sinhala,
                                 SUM(CASE WHEN ss.Subject_Id = 'S002' THEN ss.Marks ELSE 0 END) AS Buddist,
                                 SUM(CASE WHEN ss.Subject_Id = 'S003' THEN ss.Marks ELSE 0 END) AS Science,
                                 SUM(CASE WHEN ss.Subject_Id = 'S004' THEN ss.Marks ELSE 0 END) AS Maths,
                                 SUM(CASE WHEN ss.Subject_Id = 'S005' THEN ss.Marks ELSE 0 END) AS History,
                                 SUM(CASE WHEN ss.Subject_Id = 'S006' THEN ss.Marks ELSE 0 END) AS English,
                                 SUM(CASE WHEN ss.Subject_Id = 'S007' THEN ss.Marks ELSE 0 END) AS Op1,
                                 SUM(CASE WHEN ss.Subject_Id = 'S008' THEN ss.Marks ELSE 0 END) AS Op2,
                                 SUM(CASE WHEN ss.Subject_Id = 'S009' THEN ss.Marks ELSE 0 END) AS Op3  
                                 FROM Student s
                                 JOIN std_sub ss ON s.Index_No = ss.Student_Index
                                 GROUP BY s.Index_No, s.Student_name";

                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable viewGrid(String index)
        {
            try
            {
                conn.Open();
                string query = $@"SELECT 
                                        s.Index_No,
                                        s.Student_Name,
                                        AVG(ss.Marks) AS Avg_marks,
                                        SUM(CASE WHEN ss.Subject_Id = 'S001' THEN ss.Marks ELSE 0 END) AS Sinhala,
                                        SUM(CASE WHEN ss.Subject_Id = 'S002' THEN ss.Marks ELSE 0 END) AS Buddist,
                                        SUM(CASE WHEN ss.Subject_Id = 'S003' THEN ss.Marks ELSE 0 END) AS Science,
                                        SUM(CASE WHEN ss.Subject_Id = 'S004' THEN ss.Marks ELSE 0 END) AS Maths,
                                        SUM(CASE WHEN ss.Subject_Id = 'S005' THEN ss.Marks ELSE 0 END) AS History,
                                        SUM(CASE WHEN ss.Subject_Id = 'S006' THEN ss.Marks ELSE 0 END) AS English,
                                        SUM(CASE WHEN ss.Subject_Id = 'S007' THEN ss.Marks ELSE 0 END) AS Op1,
                                        SUM(CASE WHEN ss.Subject_Id = 'S008' THEN ss.Marks ELSE 0 END) AS Op2,
                                        SUM(CASE WHEN ss.Subject_Id = 'S009' THEN ss.Marks ELSE 0 END) AS Op3
                                    FROM 
                                        Student s
                                    JOIN 
                                        std_sub ss ON s.Index_No = ss.Student_Index
                                    WHERE
                                        s.Index_No = '{index}'
                                    GROUP BY 
                                        s.Index_No, s.Student_Name;";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable viewGrade(int grade)
        {
            try
            {
                conn.Open();
                string query = $@"SELECT 
                                        s.Index_No,
                                        s.Student_Name,
                                        AVG(ss.Marks) AS Avg_marks,
                                        SUM(CASE WHEN ss.Subject_Id = 'S001' THEN ss.Marks ELSE 0 END) AS Sinhala,
                                        SUM(CASE WHEN ss.Subject_Id = 'S002' THEN ss.Marks ELSE 0 END) AS Buddist,
                                        SUM(CASE WHEN ss.Subject_Id = 'S003' THEN ss.Marks ELSE 0 END) AS Science,
                                        SUM(CASE WHEN ss.Subject_Id = 'S004' THEN ss.Marks ELSE 0 END) AS Maths,
                                        SUM(CASE WHEN ss.Subject_Id = 'S005' THEN ss.Marks ELSE 0 END) AS History,
                                        SUM(CASE WHEN ss.Subject_Id = 'S006' THEN ss.Marks ELSE 0 END) AS English,
                                        SUM(CASE WHEN ss.Subject_Id = 'S007' THEN ss.Marks ELSE 0 END) AS Op1,
                                        SUM(CASE WHEN ss.Subject_Id = 'S008' THEN ss.Marks ELSE 0 END) AS Op2,
                                        SUM(CASE WHEN ss.Subject_Id = 'S009' THEN ss.Marks ELSE 0 END) AS Op3
                                    FROM 
                                        Student s
                                    JOIN 
                                        std_sub ss ON s.Index_No = ss.Student_Index
                                    WHERE
                                        s.Grade = '{grade}'
                                    GROUP BY 
                                        s.Index_No, s.Student_Name;";


                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
