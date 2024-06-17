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
    public partial class FormTeacherPanel : Form
    {
        private Form activeForm;
        private void openChildForm(Form childForm, object btnSender)
        {
            try {
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
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            
        }
        public FormTeacherPanel()
        {
            InitializeComponent();
        }

        private void btnStudentsAdd_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new Form1AddStudentcs(), sender);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnStudentsMsrks_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new FormAddMarks(), sender);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            try
            {
                FormTeacherLogin TeacherLogin = new FormTeacherLogin();
                TeacherLogin.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }
    }
}
