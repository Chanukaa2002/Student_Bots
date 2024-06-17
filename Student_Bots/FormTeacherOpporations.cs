using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Student_Bots
{
    public partial class FormTeacherOpporations : Form
    {
        Teacher teacher;
        String gender;

        public FormTeacherOpporations()
        {
             teacher = new Teacher();
            InitializeComponent();
            dataGridTeacher();
        }
        private void ClearTxt()
        {
            textBoxAge.Text = "";
            textBoxClassTeacher.Text = "";
            textBoxNationality.Text = "";
            textBoxTeacherId.Text = "";
            textBoxTeacherName.Text = "";
            textBoxTeacherPassword.Text = "";
            comboBoxGender.SelectedIndex = 0;
  
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (textBoxTeacherName.Text == String.Empty)
                {
                    lblErrorTeacherName.Visible = true;
                    btnAdd.Enabled = false;
                }
                else
                {
                    btnAdd.Enabled= true;
                }

                if (comboBoxGender.SelectedIndex == 1)
                {
                    gender = "M";
                }
                else
                {
                    gender = "F";
                }
                String Principle_Id = "P001";   
                teacher.TeacherRegistration(textBoxTeacherId.Text,textBoxTeacherPassword.Text,textBoxTeacherName.Text,textBoxClassTeacher.Text,gender,textBoxNationality.Text,Convert.ToInt32(textBoxAge.Text),Principle_Id);
                dataGridViewTeacher.DataSource = teacher.viewTeacher();
                ClearTxt();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        private void dataGridTeacher()
        {
            dataGridViewTeacher.DataSource = teacher.viewTeacher();
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTxt();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (comboBoxGender.SelectedIndex == 1)
                {
                    gender = "M";
                }
                else
                {
                    gender = "F";
                }
                String Principle_Id = "P001";
                teacher.updateTeacher(textBoxTeacherId.Text, textBoxTeacherPassword.Text, textBoxTeacherName.Text, textBoxClassTeacher.Text, gender, textBoxNationality.Text, Convert.ToInt32(textBoxAge.Text), Principle_Id);
                dataGridViewTeacher.DataSource = teacher.viewTeacher();
                ClearTxt();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void dataGridViewTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }
        private void dataGridViewTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewTeacher.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewTeacher.CurrentRow.Selected = true;
                        textBoxAge.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["Age"].FormattedValue.ToString();
                        textBoxClassTeacher.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["Class"].FormattedValue.ToString();
                        textBoxNationality.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["Nationality"].FormattedValue.ToString();
                        textBoxTeacherId.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["Teacher_Id"].FormattedValue.ToString();
                        textBoxTeacherName.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["Teacher_Name"].FormattedValue.ToString();
                        textBoxTeacherPassword.Text = dataGridViewTeacher.Rows[e.RowIndex].Cells["Password"].FormattedValue.ToString();
                        String gender = dataGridViewTeacher.Rows[e.RowIndex].Cells["Gender"].FormattedValue.ToString();
                        if(gender == "M")
                        {
                            comboBoxGender.SelectedIndex = 1;
                        }
                        else if (gender == "F")
                        {
                            comboBoxGender.SelectedIndex = 2;
                        }
                    

                        //txtBID.Text = dataGrid.Rows[e.RowIndex].Cells["BID"].FormattedValue.ToString();

                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        //---------Validating-------------
        private void textBoxTeacherName_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if(textBoxTeacherName.Text == String.Empty)
                {
                    lblErrorTeacherName.Visible = true;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorTeacherName.Visible = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message);}
        }
        private void textBoxClassTeacher_Validating(object sender, CancelEventArgs e)
        {
            try 
            { 
                if (textBoxClassTeacher.Text == String.Empty)
                {
                    lblErrorClass.Visible = true;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorClass.Visible = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void comboBoxGender_Validating(object sender, CancelEventArgs e)
        {
            try
            {          
                if (comboBoxGender.SelectedIndex==0)
                {
                    lblErrorGender.Visible = true;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorGender.Visible = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxNationality_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxNationality.Text == String.Empty)
                {
                    lblErrorNationality.Visible = true;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorNationality.Visible = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBoxTeacherId_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if (textBoxTeacherId.Text == String.Empty)
                {
                    lblErrorTeacherId.Visible = true;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorTeacherId.Visible = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void textBoxTeacherPassword_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxTeacherPassword.Text == String.Empty)
                {
                    lblErrorTeacherPassword.Visible = true;
                    btnAdd.Enabled = false;
                    btnUpdate.Enabled = false;
                }
                else
                {
                    lblErrorTeacherPassword.Visible = false;
                    btnAdd.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        /*   private void textBoxAge_Validating(object sender, CancelEventArgs e)
           {
               if (textBoxAge.Text == String.Empty)
               {
                   if(TextBox.Text )
               }
               else
               {
                   lblErrorAge.Visible = false;
                   btnAdd.Enabled = true;
               }
           }
        */
    }
}
