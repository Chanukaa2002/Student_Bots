using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Student_Bots
{
    public partial class FormAddMarks : Form
    {
        Marks marks;
        public FormAddMarks()
        {
            InitializeComponent();
            marks = new Marks();
            dataGridMarks();
        }

        
        private void dataGridMarks()
        {
            dataGridViewMarkDetails.DataSource = marks.view();
        }

        private void checkSubInGrade()
        {
            try
            {

                if(comboBoxGrade.SelectedIndex==0 & comboBoxGrade.SelectedIndex<=10)
                {
                    lblOp1.Text = "";
                    lblOp2.Text = "";
                    lblOp3.Text = "";

                    textBoxOp1.Visible = false;
                    textBoxOp2.Visible = false;
                    textBoxOp3.Visible = false;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grade = comboBoxGrade.SelectedIndex;
            if (grade == 12)
            {
                dataGridViewMarkDetails.DataSource = marks.view();
            }
            else
            {
                dataGridViewMarkDetails.DataSource = marks.viewGrade(grade);
            }
        }

        //clear
        private void clear()
        {
            comboBoxGrade.SelectedIndex = 12;
            txtBoxStdId.Text = "";
            textBoxBuddist.Text = "";
            textBoxEnglish.Text = "";
            textBoxHistory.Text = "";
            textBoxMaths.Text = "";
            textBoxOp1.Text = "";
            textBoxOp2.Text = "";
            textBoxOp3.Text = "";
            textBoxScience.Text = "";
            textBoxSinhala.Text = "";

        }
        
//--------------------------------------------------------------|Validating|----------------------------------------------------------
        private void textBoxSinhala_Validating(object sender, CancelEventArgs e)
        {
            try
            {

                if (textBoxSinhala.Text==String.Empty)
                {
                    lblErrorSinhala.Visible = true;
                    btnAdd.Enabled = false;
                   // btnUpdate.Enabled = false;
                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxSinhala.Text, out number))
                    {
                        if(number>=0  && number <= 100)
                        {
                            lblErrorSinhala.Visible = false;
                            btnAdd.Enabled = true;
                     //       btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorSinhala.Visible = true;
                            btnAdd.Enabled = false;
                       //     btnUpdate.Enabled = false;
                        }
                    }
                    else
                    {
                        lblErrorSinhala.Visible = true;
                        btnAdd.Enabled = false;
                    //    btnUpdate.Enabled = false;
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxBuddist_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxBuddist.Text == String.Empty)
                {
                    lblErrorBuddist.Visible = true;
                    btnAdd.Enabled = false;
                  //  btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxBuddist.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorBuddist.Visible = false;
                            btnAdd.Enabled = true;
                      //      btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorBuddist.Visible = true;
                            btnAdd.Enabled = false;
                      //      btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorBuddist.Visible = true;
                        btnAdd.Enabled = false;
                      //  btnUpdate.Enabled = false;
                    }
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
                
        }
        private void textBoxScience_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxScience.Text == String.Empty)
                {
                    lblErrorScience.Visible = true;
                    btnAdd.Enabled = false;
                  //  btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxScience.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorScience.Visible = false;
                            btnAdd.Enabled = true;
                   //         btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorScience.Visible = true;
                            btnAdd.Enabled = false;
                   //         btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorScience.Visible = true;
                        btnAdd.Enabled = false;
                   //     btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxMaths_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxMaths.Text == String.Empty)
                {
                    lblErrorMaths.Visible = true;
                    btnAdd.Enabled = false;
                   // btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxMaths.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorMaths.Visible = false;
                            btnAdd.Enabled = true;
                     //       btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorMaths.Visible = true;
                            btnAdd.Enabled = false;
                     //       btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorMaths.Visible = true;
                        btnAdd.Enabled = false;
                   //     btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxHistory_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxHistory.Text == String.Empty)
                {
                    lblErrorHistory.Visible = true;
                    btnAdd.Enabled = false;
                   // btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxHistory.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorHistory.Visible = false;
                            btnAdd.Enabled = true;
                         //   btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorHistory.Visible = true;
                            btnAdd.Enabled = false;
                           // btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorHistory.Visible = true;
                        btnAdd.Enabled = false;
                     //   btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxEnglish_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxEnglish.Text == String.Empty)
                {
                    lblErrorEnglish.Visible = true;
                    btnAdd.Enabled = false;
                   // btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxEnglish.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorEnglish.Visible = false;
                            btnAdd.Enabled = true;
                    //        btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorEnglish.Visible = true;
                            btnAdd.Enabled = false;
                    //        btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorEnglish.Visible = true;
                        btnAdd.Enabled = false;
                     //   btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxOp1_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxOp1.Text == String.Empty)
                {
                    lblErrorOp1.Visible = true;
                    btnAdd.Enabled = false;
                //    btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxOp1.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorOp1.Visible = false;
                            btnAdd.Enabled = true;
                //            btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorOp1.Visible = true;
                            btnAdd.Enabled = false;
                //            btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorOp1.Visible = true;
                        btnAdd.Enabled = false;
                //        btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxOp2_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxOp2.Text == String.Empty)
                {
                    lblErrorOp2.Visible = true;
                    btnAdd.Enabled = false;
                //    btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxOp2.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorOp2.Visible = false;
                            btnAdd.Enabled = true;
                //            btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorOp2.Visible = true;
                            btnAdd.Enabled = false;
                //            btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorOp2.Visible = true;
                        btnAdd.Enabled = false;
                //        btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void textBoxOp3_Validating(object sender, CancelEventArgs e)
        {
            try
            {


                if (textBoxOp3.Text == String.Empty)
                {
                    lblErrorOp3.Visible = true;
                    btnAdd.Enabled = false;
                //    btnUpdate.Enabled = false;

                }
                else
                {
                    int number;
                    if (int.TryParse(textBoxOp3.Text, out number))
                    {
                        if (number >= 0 && number <= 100)
                        {
                            lblErrorOp3.Visible = false;
                            btnAdd.Enabled = true;
                //            btnUpdate.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter 0-100");
                            lblErrorOp3.Visible = true;
                            btnAdd.Enabled = false;
//                            btnUpdate.Enabled = false;

                        }
                    }
                    else
                    {
                        lblErrorOp3.Visible = true;
                        btnAdd.Enabled = false;
                //        btnUpdate.Enabled = false;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            marks.addMarks(float.Parse(textBoxSinhala.Text), float.Parse(textBoxBuddist.Text), 
                           float.Parse(textBoxScience.Text), float.Parse(textBoxMaths.Text), 
                           float.Parse(textBoxHistory.Text), float.Parse(textBoxEnglish.Text), 
                           float.Parse(textBoxOp2.Text), float.Parse(textBoxOp3.Text), 
                           float.Parse(textBoxOp3.Text), txtBoxStdId.Text);
            dataGridMarks();
            clear();
        }

        

        private void dataGridViewMarkDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    if (dataGridViewMarkDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        dataGridViewMarkDetails.CurrentRow.Selected = true;
                        txtBoxStdId.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Index_No"].FormattedValue.ToString();
                        textBoxBuddist.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Buddist"].FormattedValue.ToString();
                        textBoxEnglish.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["English"].FormattedValue.ToString();
                        textBoxHistory.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["History"].FormattedValue.ToString();
                        textBoxMaths.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Maths"].FormattedValue.ToString();
                        textBoxOp1.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Op1"].FormattedValue.ToString();
                        textBoxOp2.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Op2"].FormattedValue.ToString();
                        textBoxOp3.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Op3"].FormattedValue.ToString();
                        textBoxScience.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Science"].FormattedValue.ToString();
                        textBoxSinhala.Text = dataGridViewMarkDetails.Rows[e.RowIndex].Cells["Sinhala"].FormattedValue.ToString();
                                                

                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
 