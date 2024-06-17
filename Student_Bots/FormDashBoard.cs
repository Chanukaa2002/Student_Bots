using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Bots
{
    public partial class FormDashBoard : Form
    {
        Student student;
        Teacher teacher;
        public FormDashBoard()
        {
            InitializeComponent();
            student  = new Student();
            teacher = new Teacher();
            stdGrade();
            stdGender();
            teacherGender();
        }

        private void stdGrade()
        {
            DataTable studentData = student.viewStdCount();

            if (studentData != null)
            {
                chartStudentGrade.Series[0].XValueMember = "Grade";
                chartStudentGrade.Series[0].YValueMembers = "StudentCount";
                chartStudentGrade.DataSource = studentData;
                chartStudentGrade.DataBind();
            }
        }

        private void stdGender()
        {
            DataTable studentData = student.viewStdGender();

            if (studentData != null)
            {
                chartStudentGender.Series[0].XValueMember = "Gender";
                chartStudentGender.Series[0].YValueMembers = "StudentCount";
                chartStudentGender.DataSource = studentData;
                chartStudentGender.DataBind();
            }
        }

        private void teacherGender()
        {
            DataTable teacherData = teacher.viewTeacherGender();

            if (teacherData != null)
            {
                chartTeacherGender.Series[0].XValueMember = "Gender";
                chartTeacherGender.Series[0].YValueMembers = "TeacherCount";
                chartTeacherGender.DataSource = teacherData;
                chartTeacherGender.DataBind();
            }
        }

        private void chartStudentGender_Click(object sender, EventArgs e)
        {

        }

        private void chartStudentGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
