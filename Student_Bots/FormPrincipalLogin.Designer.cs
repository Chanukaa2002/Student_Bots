namespace Student_Bots
{
    partial class FormPrincipalLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalLogin));
            this.lblPrinciple = new System.Windows.Forms.Label();
            this.btnPrincipalLogin = new System.Windows.Forms.Button();
            this.txtboxPrincipalPassword = new System.Windows.Forms.TextBox();
            this.btnNextLoginPage = new System.Windows.Forms.Button();
            this.chkBoxPassword = new System.Windows.Forms.CheckBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picBoxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrinciple
            // 
            this.lblPrinciple.AutoSize = true;
            this.lblPrinciple.Font = new System.Drawing.Font("Bahnschrift Condensed", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrinciple.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblPrinciple.Location = new System.Drawing.Point(165, 247);
            this.lblPrinciple.Name = "lblPrinciple";
            this.lblPrinciple.Size = new System.Drawing.Size(279, 57);
            this.lblPrinciple.TabIndex = 5;
            this.lblPrinciple.Text = "PRINCIPAL LOGIN\r\n";
            // 
            // btnPrincipalLogin
            // 
            this.btnPrincipalLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnPrincipalLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrincipalLogin.FlatAppearance.BorderSize = 0;
            this.btnPrincipalLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrincipalLogin.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrincipalLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrincipalLogin.Location = new System.Drawing.Point(39, 555);
            this.btnPrincipalLogin.Name = "btnPrincipalLogin";
            this.btnPrincipalLogin.Size = new System.Drawing.Size(513, 65);
            this.btnPrincipalLogin.TabIndex = 2;
            this.btnPrincipalLogin.Text = "LOGIN";
            this.btnPrincipalLogin.UseVisualStyleBackColor = false;
            this.btnPrincipalLogin.Click += new System.EventHandler(this.btnPrincipalLogin_Click);
            // 
            // txtboxPrincipalPassword
            // 
            this.txtboxPrincipalPassword.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxPrincipalPassword.Location = new System.Drawing.Point(200, 393);
            this.txtboxPrincipalPassword.Multiline = true;
            this.txtboxPrincipalPassword.Name = "txtboxPrincipalPassword";
            this.txtboxPrincipalPassword.PasswordChar = '*';
            this.txtboxPrincipalPassword.Size = new System.Drawing.Size(307, 36);
            this.txtboxPrincipalPassword.TabIndex = 0;
            this.txtboxPrincipalPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtboxPrincipalPassword_KeyDown);
            // 
            // btnNextLoginPage
            // 
            this.btnNextLoginPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnNextLoginPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextLoginPage.FlatAppearance.BorderSize = 0;
            this.btnNextLoginPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextLoginPage.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLoginPage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNextLoginPage.Location = new System.Drawing.Point(278, 658);
            this.btnNextLoginPage.Name = "btnNextLoginPage";
            this.btnNextLoginPage.Size = new System.Drawing.Size(40, 40);
            this.btnNextLoginPage.TabIndex = 3;
            this.btnNextLoginPage.Text = ">";
            this.btnNextLoginPage.UseVisualStyleBackColor = false;
            this.btnNextLoginPage.Click += new System.EventHandler(this.btnNextLoginPage_Click);
            // 
            // chkBoxPassword
            // 
            this.chkBoxPassword.AutoSize = true;
            this.chkBoxPassword.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxPassword.Location = new System.Drawing.Point(440, 513);
            this.chkBoxPassword.Name = "chkBoxPassword";
            this.chkBoxPassword.Size = new System.Drawing.Size(138, 22);
            this.chkBoxPassword.TabIndex = 1;
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
            this.lblExit.TabIndex = 4;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(175, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 239);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // picBoxPassword
            // 
            this.picBoxPassword.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPassword.Image")));
            this.picBoxPassword.Location = new System.Drawing.Point(132, 391);
            this.picBoxPassword.Name = "picBoxPassword";
            this.picBoxPassword.Size = new System.Drawing.Size(37, 38);
            this.picBoxPassword.TabIndex = 18;
            this.picBoxPassword.TabStop = false;
            // 
            // FormPrincipalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(603, 716);
            this.Controls.Add(this.picBoxPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.chkBoxPassword);
            this.Controls.Add(this.btnNextLoginPage);
            this.Controls.Add(this.btnPrincipalLogin);
            this.Controls.Add(this.txtboxPrincipalPassword);
            this.Controls.Add(this.lblPrinciple);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipalLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrinciple;
        private System.Windows.Forms.Button btnPrincipalLogin;
        private System.Windows.Forms.TextBox txtboxPrincipalPassword;
        private System.Windows.Forms.Button btnNextLoginPage;
        private System.Windows.Forms.CheckBox chkBoxPassword;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox picBoxPassword;
    }
}

