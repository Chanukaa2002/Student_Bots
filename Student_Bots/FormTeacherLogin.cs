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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student_Bots
{
    public partial class FormTeacherLogin : Form
    {
        Teacher teacher;
        public FormTeacherLogin()
        {
            InitializeComponent();
            teacher = new Teacher();
        }
        private void btnNextLoginPage_Click(object sender, EventArgs e)
        {
            try
            {
                FormPrincipalLogin FormPLogin = new FormPrincipalLogin();
                FormPLogin.Show();
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(chkBoxPassword.Checked)
                {
                    txtboxTeacherPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    txtboxTeacherPassword.UseSystemPasswordChar= false;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            try
            {
                teacher.TeacherLogin(txtboxTeacherUserName.Text, txtboxTeacherPassword.Text);
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void txtboxTeacherPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTeacherLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
