namespace Student_Bots
{
    partial class FormTeacherLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherLogin));
            this.btnNextLoginPage = new System.Windows.Forms.Button();
            this.btnTeacherLogin = new System.Windows.Forms.Button();
            this.txtboxTeacherPassword = new System.Windows.Forms.TextBox();
            this.txtboxTeacherUserName = new System.Windows.Forms.TextBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.chkBoxPassword = new System.Windows.Forms.CheckBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.picBoxUserName = new System.Windows.Forms.PictureBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNextLoginPage
            // 
            this.btnNextLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnNextLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextLoginPage.FlatAppearance.BorderSize = 0;
            this.btnNextLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextLoginPage.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLoginPage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNextLoginPage.Location = new System.Drawing.Point(277, 658);
            this.btnNextLoginPage.Name = "btnNextLoginPage";
            this.btnNextLoginPage.Size = new System.Drawing.Size(40, 40);
            this.btnNextLoginPage.TabIndex = 4;
            this.btnNextLoginPage.Text = "<";
            this.btnNextLoginPage.UseVisualStyleBackColor = false;
            this.btnNextLoginPage.Click += new System.EventHandler(this.btnNextLoginPage_Click);
            // 
            // btnTeacherLogin
            // 
            this.btnTeacherLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnTeacherLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherLogin.FlatAppearance.BorderSize = 0;
            this.btnTeacherLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacherLogin.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeacherLogin.Location = new System.Drawing.Point(39, 555);
            this.btnTeacherLogin.Name = "btnTeacherLogin";
            this.btnTeacherLogin.Size = new System.Drawing.Size(513, 65);
            this.btnTeacherLogin.TabIndex = 3;
            this.btnTeacherLogin.Text = "LOGIN";
            this.btnTeacherLogin.UseVisualStyleBackColor = false;
            this.btnTeacherLogin.Click += new System.EventHandler(this.btnTeacherLogin_Click);
            // 
            // txtboxTeacherPassword
            // 
            this.txtboxTeacherPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTeacherPassword.Location = new System.Drawing.Point(207, 422);
            this.txtboxTeacherPassword.Multiline = true;
            this.txtboxTeacherPassword.Name = "txtboxTeacherPassword";
            this.txtboxTeacherPassword.PasswordChar = '*';
            this.txtboxTeacherPassword.Size = new System.Drawing.Size(307, 36);
            this.txtboxTeacherPassword.TabIndex = 1;
            this.txtboxTeacherPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxTeacherPassword_KeyDown);
            // 
            // txtboxTeacherUserName
            // 
            this.txtboxTeacherUserName.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxTeacherUserName.Location = new System.Drawing.Point(207, 342);
            this.txtboxTeacherUserName.Multiline = true;
            this.txtboxTeacherUserName.Name = "txtboxTeacherUserName";
            this.txtboxTeacherUserName.Size = new System.Drawing.Size(307, 36);
            this.txtboxTeacherUserName.TabIndex = 0;
            // 
            // lblTeacher
            // 
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Bahnschrift Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblTeacher.Location = new System.Drawing.Point(165, 242);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(254, 57);
            this.lblTeacher.TabIndex = 1;
            this.lblTeacher.Text = "TEACHER LOGIN\r\n";
            // 
            // chkBoxPassword
            // 
            this.chkBoxPassword.AutoSize = true;
            this.chkBoxPassword.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPassword.Location = new System.Drawing.Point(440, 513);
            this.chkBoxPassword.Name = "chkBoxPassword";
            this.chkBoxPassword.Size = new System.Drawing.Size(138, 22);
            this.chkBoxPassword.TabIndex = 2;
            this.chkBoxPassword.Text = "Show Password";
            this.chkBoxPassword.UseVisualStyleBackColor = true;
            this.chkBoxPassword.CheckedChanged += new System.EventHandler(this.chkBoxPassword_CheckedChanged);
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExit.Location = new System.Drawing.Point(550, 681);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(28, 16);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(175, -12);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(256, 239);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 15;
            this.picBoxLogo.TabStop = false;
            // 
            // picBoxUserName
            // 
            this.picBoxUserName.Image = ((System.Drawing.Image)(resources.GetObject("picBoxUserName.Image")));
            this.picBoxUserName.Location = new System.Drawing.Point(136, 340);
            this.picBoxUserName.Name = "picBoxUserName";
            this.picBoxUserName.Size = new System.Drawing.Size(41, 38);
            this.picBoxUserName.TabIndex = 16;
            this.picBoxUserName.TabStop = false;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassword.Image")));
            this.picBoxPassword.Location = new System.Drawing.Point(136, 422);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(41, 38);
            this.picBoxPassword.TabIndex = 17;
            this.picBoxPassword.TabStop = false;
            // 
            // FormTeacherLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(603, 716);
            this.Controls.Add(this.picBoxPassword);
            this.Controls.Add(this.picBoxUserName);
            this.Controls.Add(this.picBoxLogo);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.chkBoxPassword);
            this.Controls.Add(this.btnNextLoginPage);
            this.Controls.Add(this.btnTeacherLogin);
            this.Controls.Add(this.txtboxTeacherPassword);
            this.Controls.Add(this.txtboxTeacherUserName);
            this.Controls.Add(this.lblTeacher);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTeacherLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTeacherLogin";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNextLoginPage;
        private System.Windows.Forms.Button btnTeacherLogin;
        private System.Windows.Forms.TextBox txtboxTeacherPassword;
        private System.Windows.Forms.TextBox txtboxTeacherUserName;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.CheckBox chkBoxPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.PictureBox picBoxUserName;
        private System.Windows.Forms.PictureBox picBoxPassword;
    }
}