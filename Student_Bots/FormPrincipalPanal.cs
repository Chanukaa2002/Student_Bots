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
    public partial class FormPrincipalPanal : Form
    {

        private Form activeForm;
        private void openChildForm(Form childForm, object btnSender)
        {
            try
            {           
                if (activeForm != null)
                {
                    activeForm.Close();
                }
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelFormLoad.Controls.Add(childForm);
                this.panelFormLoad.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        public FormPrincipalPanal()
        {
            InitializeComponent();
            openChildForm(new FormDashBoard(), null);
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormTeacherOpporations() , sender);
            }catch(Exception ex ) { MessageBox.Show(ex.Message);}
        }

        private void btnLetters_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormLetter(), sender);
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormStudents(), sender);
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrincipalLogin principalLogin = new FormPrincipalLogin();
                principalLogin.Show();
                this.Hide();
            }catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void panelFormLoad_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormDashBoard(), sender);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
