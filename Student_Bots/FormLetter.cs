using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;//
using System.Threading.Tasks;//
using System.Windows.Forms;//
using System.Data.SqlClient;//
using Syncfusion.DocIO.DLS;//
using Syncfusion.DocIO;//
using System.IO;

namespace Student_Bots
{
    public partial class FormLetter : Form
    {
        Letter letter;
        Student student;
        public FormLetter()
        {
            letter = new Letter();
            student = new Student();
            InitializeComponent();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void txtBoxCoActivity_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if(txtBoxCoActivity.Text ==String.Empty)
                {
                    lblErrorActivity.Visible = true;
                    btnGenarate.Enabled = false;
                }
                else
                {
                    lblErrorActivity.Visible = false;
                    btnGenarate.Enabled = true;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void FormLetter_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxIndex_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxIndex.SelectedValue != null)
            {
                if (comboBoxIndex.SelectedValue.ToString() != "0")
                {

                    string index = comboBoxIndex.SelectedValue.ToString();
                    dataGridViewStdDetail.DataSource = student.viewByIndex(index);
                }
                
            }
        }

        private void indexList()
        {
            int grade = comboBoxGrade.SelectedIndex;
            

            DataTable dt = letter.GetIndexList(grade);
            if (dt != null)
            {
                comboBoxIndex.DataSource = dt;
                comboBoxIndex.DisplayMember = "Index_No"; 
                comboBoxIndex.ValueMember = "Index_No";
                comboBoxIndex.SelectedIndex = -1;
                comboBoxIndex.Text = "-Select-";
            }

        }

        private void clear()
        {
            txtBoxCoActivity.Text = "";
            comboBoxIndex.SelectedIndex = 0;
            comboBoxGrade.SelectedIndex = 0;
        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexList();
        }

        private void btnGenarate_Click(object sender, EventArgs e)
        {
            if (comboBoxIndex.SelectedValue != null)
            {
                string studentIndex = comboBoxIndex.SelectedValue.ToString();
                string coActivities = txtBoxCoActivity.Text;
                Letter letter = new Letter();
                letter.GenerateStudentLetter(studentIndex, coActivities);
                clear();
            }

        }
        
       


    }
}
