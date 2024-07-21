using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.DocIO.DLS;//
using Syncfusion.DocIO;//
using System.IO;
using System.Net;
using System.Reflection;


namespace Student_Bots
{
    internal class Letter
    {
        private SqlConnection conn;
        private DatabaseConnection db;
        Student student;

        public Letter()
        {
            db = new DatabaseConnection();
            conn = db.GetSqlConnection();
            
        }

        public DataTable GetIndexList(int grade)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Index_No from Student Where status=1 and Grade='" + grade + "'", conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return null; }
            finally { conn.Close(); }

        }
        public void GenerateStudentLetter(string studentIndex, string coActivities)
        {
            string templatePath = @"C:\Users\Chanuka\source\repos\cw\Letter\format\format.docx";

            using (FileStream templateStream = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
            {
                using (WordDocument document = new WordDocument(templateStream, FormatType.Docx))
                {
                    student = new Student();
                    DataTable dt = student.viewByIndex(studentIndex);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        string studentName = dt.Rows[0]["Student_Name"].ToString();
                        string dob = dt.Rows[0]["DOB"].ToString();
                        string admission = dt.Rows[0]["Admission_Date"].ToString();
                        string today = DateTime.Now.ToString("yyyy-MM-dd");
                        string grade = dt.Rows[0]["Grade"].ToString();
                        string Class = dt.Rows[0]["Class"].ToString();
                        string gardian = dt.Rows[0]["Gardion_Name"].ToString();
                        string gender = dt.Rows[0]["Gender"].ToString();
                        string setGender = "";
                        if(gender == "M")
                        {
                            setGender = "He";
                        }
                        else
                        {
                            setGender = "She";
                                
                        }

                        document.Replace("{{StudentName}}", studentName, true, true);
                        document.Replace("{{IndexNo}}", studentIndex, true, true);
                        document.Replace("{{DateOfBirth}}", dob, true, true);
                        document.Replace("{{AdmissionDate}}", admission, true, true);
                        document.Replace("{{DateOfLeaving}}", today, true, true);
                        document.Replace("{{ClassLastAttended}}", grade + Class, true, true);
                        document.Replace("{{Grade}}", grade, true, true);
                        document.Replace("{{co-activities}}", coActivities, true, true);
                        document.Replace("{{ParentName}}", gardian, true, true);
                        document.Replace("{{gender}}", setGender, true, true);

                        string savePathTemplate = @"C:\Users\Chanuka\source\repos\cw\Letter\leaving_certificates\Grade-{0}\{1}({2}).docx";
                        string savePath = string.Format(savePathTemplate, grade,studentName, studentIndex);

                        using (FileStream fileStream = new FileStream(savePath, FileMode.Create, FileAccess.Write))
                        {
                            document.Save(fileStream, FormatType.Docx);
                        }

                        document.Close();
                        addLetter(studentIndex, today, savePath);
                        student.DeleteStudent(studentIndex);
                    }
                }

                MessageBox.Show("Letter generated and saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void addLetter(string studentIndex, string today, string savePath)
        {
            try
            {
                conn.Open();
                string q = "SELECT TOP 1 Letter_Id FROM Letter ORDER BY Letter_Id DESC";
                SqlCommand getLastIdCommand = new SqlCommand(q, conn);
                object lastIdObj = getLastIdCommand.ExecuteScalar();
                string lastId;
                if (lastIdObj != null)
                {
                    lastId = lastIdObj.ToString();
                }
                else
                {
                    lastId = "L000";
                }
                string nextId = GenerateNextId(lastId);
                byte[] fileData = File.ReadAllBytes(savePath);
                string insertQuery = @"INSERT INTO Letter (Letter_Id, Letter_Name, Student_Index, Principle_Id,Relese_date,Letter_Path,Doc)
                               VALUES (@letterId, @name, @index, @principleId,@date,@path,@doc);";

                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@letterId", nextId);
                    cmd.Parameters.AddWithValue("@name", "Leaving Certificate");
                    cmd.Parameters.AddWithValue("@index", studentIndex);
                    cmd.Parameters.AddWithValue("@principleId", "P001");
                    cmd.Parameters.AddWithValue("@date", today);
                    cmd.Parameters.AddWithValue("@path", savePath);
                    cmd.Parameters.AddWithValue("@doc", fileData);
                    cmd.ExecuteNonQuery();
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

        private string GenerateNextId(string lastId)
        {
            int numberPart = int.Parse(lastId.Substring(1));
            numberPart++;
            return "L" + numberPart.ToString("D3");
        }


    }
}
