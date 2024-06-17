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
    public partial class FormPrincipalLogin : Form
    {
        Principle principle;
        public FormPrincipalLogin()
        {
            InitializeComponent();
            principle  = new Principle();
        }

        private void btnNextLoginPage_Click(object sender, EventArgs e)
        {
            FormTeacherLogin FormTLogin = new FormTeacherLogin();
            FormTLogin.Show();
            this.Hide();
        }

        private void btnPrincipalLogin_Click(object sender, EventArgs e)
        {
            try
            { 
                principle.PrincipleLogin(txtboxPrincipalPassword.Text);
                this.Hide();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxPassword.Checked)
                {
                    txtboxPrincipalPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    txtboxPrincipalPassword.UseSystemPasswordChar = false;
                }
            }catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtboxPrincipalPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnPrincipalLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
    }
}
