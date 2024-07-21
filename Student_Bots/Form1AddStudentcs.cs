using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Bots
{
    public partial class Form1AddStudentcs : Form
    {
        Student student;      
        String Gender;
        String Grade= "";
        String Class = "";

        public Form1AddStudentcs()
        {
            InitializeComponent();
            student = new Student();
            dataGridStudent();

        }
        String teacher_Id = "T001";//fixxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx
        //public void catchTeacherId(String Teacher_Id)
        //{
        //    this.teacher_Id = Teacher_Id;
        //}

        private void ClearText()
        {
            txtBoxAddress.Text = "";
            txtBoxGardian.Text = "";
            txtBoxIndex.Text = "";
            txtBoxIndex.Text = "";
            txtBoxStdName.Text = "";
            comboBoxGrade.SelectedIndex = 0;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            dateTimePickerAddmition.Value = DateTime.Now;
            dateTimePickerDob.Value = DateTime.Now;
            comboBoxClass.SelectedIndex = 0;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioButtonFemale.Checked== true)
                {
                    Gender = "F";
                }
                else if(radioButtonMale.Checked== true)
                {
                    Gender = "M";
                }
                switch (comboBoxGrade.SelectedIndex)
                {
                    case 1:
                        Grade = "1";
                        break;
                    case 2:
                        Grade = "2";
                        break;
                    case 3:
                        Grade = "3";
                        break;
                    case 4:
                        Grade = "4";
                        break;
                    case 5:
                        Grade = "5";
                        break;
                    case 6:
                        Grade = "6";
                        break;
                    case 7:
                        Grade = "7";
                        break;
                    case 8:
                        Grade = "8";
                        break;
                    case 9:
                        Grade = "9";
                        break;
                    case 10:
                        Grade = "10";
                        break;
                    case 11:
                        Grade = "11";
                        break;
                }
                switch (comboBoxClass.SelectedIndex)
                {
                    case 1:
                        Class = "A";
                        break;
                    case 2:
                        Class = "B";
                        break;
                    case 3:
                        Class = "C";
                        break;
                    case 4:
                        Class = "D";
                        break;
                    case 5:
                        Class = "E";
                        break;
                }


                student.AddStudent(txtBoxStdName.Text, Gender, Grade, txtBoxIndex.Text,dateTimePickerAddmition.Value, dateTimePickerDob.Value, txtBoxGardian.Text, txtBoxAddress.Text, teacher_Id,Class);
                ClearText();
                dataGridStudent();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButtonFemale.Checked == true)
                {
                    Gender = "F";
                }
                else
                {
                    if (radioButtonMale.Checked == true)
                    {
                        Gender = "M";
                    }
                }
                switch (comboBoxGrade.SelectedIndex)
                {
                    case 1:
                        Grade = "1";
                        break;
                    case 2:
                        Grade = "2";
                        break;
                    case 3:
                        Grade = "3";
                        break;
                    case 4:
                        Grade = "4";
                        break;
                    case 5:
                        Grade = "5";
                        break;
                    case 6:
                        Grade = "6";
                        break;
                    case 7:
                        Grade = "7";
                        break;
                    case 8:
                        Grade = "8";
                        break;
                    case 9:
                        Grade = "9";
                        break;
                    case 10:
                        Grade = "10";
                        break;
                    case 11:
                        Grade = "11";
                        break;
                }

                switch (comboBoxClass.SelectedIndex)
                {
                    case 1:
                        Class = "A";
                        break;
                    case 2:
                        Class = "B";
                        break;
                    case 3:
                        Class = "C";
                        break;
                    case 4:
                        Class = "D";
                        break;
                    case 5:
                        Class = "E";
                        break;
                }
                String teacher_Id = "T001";//fix error
                student.updateStudent(txtBoxStdName.Text, Gender, Grade, txtBoxIndex.Text,dateTimePickerAddmition.Value,dateTimePickerDob.Value, txtBoxGardian.Text, txtBoxAddress.Text,  teacher_Id,Class);
                dataGridStudent();
                //dataGridViewStudents.DataSource = student.viewStudent();
                ClearText();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void dataGridStudent()
        {
            try
            {
                dataGridViewStudents.DataSource = student.viewStudent();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewStudents.CurrentRow.Selected = true;
                        txtBoxAddress.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Addresss"].FormattedValue.ToString();
                        txtBoxGardian.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Gardion_Name"].FormattedValue.ToString();
                        txtBoxIndex.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Index_No"].FormattedValue.ToString();
                        txtBoxStdName.Text = dataGridViewStudents.Rows[e.RowIndex].Cells["Student_Name"].FormattedValue.ToString();
                        String grade = dataGridViewStudents.Rows[e.RowIndex].Cells["Grade"].FormattedValue.ToString();
                        String gender = dataGridViewStudents.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                        String admission = dataGridViewStudents.Rows[e.RowIndex].Cells["Admission_Date"].FormattedValue.ToString();
                        String dob = dataGridViewStudents.Rows[e.RowIndex].Cells["DOB"].FormattedValue.ToString();
                        String Class = dataGridViewStudents.Rows[e.RowIndex].Cells["Class"].FormattedValue.ToString();

                        if (!(grade == "0"))
                        {
                            comboBoxGrade.SelectedIndex = Convert.ToInt32(grade);
                        }
                        switch (Class)
                        {
                            case "A":
                                comboBoxClass.SelectedIndex = 1;
                                break;
                            case "B":
                                comboBoxClass.SelectedIndex = 2;
                                break;
                            case "C":
                                comboBoxClass.SelectedIndex = 3;
                                break;
                            case "D":
                                comboBoxClass.SelectedIndex = 4;
                                break;
                            case "E":
                                comboBoxClass.SelectedIndex = 5;
                                break;
                        }
                        //gender
                        if(gender == "M")
                        {
                            radioButtonMale.Checked = true;
                        }
                        else if(gender == "F")
                        {
                            radioButtonFemale.Checked = true;
                        }
                        //admission
                        dateTimePickerAddmition.Value = Convert.ToDateTime(admission);
                        //dob
                        dateTimePickerDob.Value = Convert.ToDateTime(dob);
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }



        //-------------Validating--------------------------------------------
        private void txtBoxStdName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtBoxStdName.Text == String.Empty)
                {
                    lblErrorStudentName.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorStudentName.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex ) { MessageBox.Show(ex.Message); }  
        }
        private void comboBoxGrade_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (comboBoxGrade.SelectedIndex == 0)
                {
                    lblErrorGrade.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorGrade.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void radioButtonMale_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (radioButtonMale.Checked == false & radioButtonFemale.Checked == false)
                {
                    lblErrorGender.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorGender.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void radioButtonFemale_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (radioButtonMale.Checked == false & radioButtonFemale.Checked == false)
                {
                    lblErrorGender.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorGender.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void txtBoxIndex_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtBoxIndex.Text == String.Empty)
                {
                    lblErrorIndex.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorIndex.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dateTimePickerDob_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (dateTimePickerDob.Value==DateTime.Now)
                {
                    lblErrorDOB.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorDOB.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void txtBoxGardian_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (txtBoxGardian.Text == String.Empty)
                {
                    lblErrorGardian.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorGardian.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) {  MessageBox.Show(ex.Message); }
        }
        private void txtBoxAddress_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if(txtBoxAddress.Text == String.Empty)
                {
                    lblErrorAddress.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    lblErrorAddress.Visible = false;
                    btnAdd.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
