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
            indexList();
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
                    btnPrint.Enabled = false;
                }
                else
                {
                    lblErrorActivity.Visible = false;
                    btnPrint.Enabled = true;
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
                string index = comboBoxIndex.SelectedValue.ToString();
                dataGridViewStdDetail.DataSource = student.viewByIndex(index);
            }
        }

        private void indexList()
        {
            DataTable dt = letter.GetIndexList();
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
            comboBoxIndex.Text = "-Select-";
        }
    }
}
