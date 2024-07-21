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
    public partial class FormStudents : Form
    {
        Student student;
        Marks mark;

        public FormStudents()
        {
            InitializeComponent();
            student = new Student();
            mark = new Marks(); 
            StudentList();
        }
        private void StudentList()
        {
            dataGridViewStudents.DataSource = student.viewStudent();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        String index = dataGridViewStudents.Rows[e.RowIndex].Cells["Index_No"].FormattedValue.ToString();
                        dataGridViewSpecificStudent.DataSource = mark.viewGrid(index);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grade = comboBoxGrade.SelectedIndex;
            if (grade == 12)
            {
                dataGridViewStudents.DataSource = student.viewStudent();
            }
            else
            {
                dataGridViewStudents.DataSource = student.viewByGrade(grade);
            }
        }

        
    }
}
