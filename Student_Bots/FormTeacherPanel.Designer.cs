namespace Student_Bots
{
    partial class FormTeacherPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherPanel));
            this.pnlHearBar = new System.Windows.Forms.Panel();
            this.panelHeadLine = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblTeacherDashBoard = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnStudentsMsrks = new System.Windows.Forms.Button();
            this.btnStudentsAdd = new System.Windows.Forms.Button();
            this.panelFormLoad = new System.Windows.Forms.Panel();
            this.pnlHearBar.SuspendLayout();
            this.panelHeadLine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHearBar
            // 
            this.pnlHearBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlHearBar.Controls.Add(this.panelHeadLine);
            this.pnlHearBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHearBar.Location = new System.Drawing.Point(0, 0);
            this.pnlHearBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlHearBar.Name = "pnlHearBar";
            this.pnlHearBar.Size = new System.Drawing.Size(1678, 125);
            this.pnlHearBar.TabIndex = 1;
            // 
            // panelHeadLine
            // 
            this.panelHeadLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.panelHeadLine.Controls.Add(this.picBoxLogo);
            this.panelHeadLine.Controls.Add(this.lblTeacherDashBoard);
            this.panelHeadLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeadLine.Location = new System.Drawing.Point(0, 0);
            this.panelHeadLine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelHeadLine.Name = "panelHeadLine";
            this.panelHeadLine.Size = new System.Drawing.Size(1678, 125);
            this.panelHeadLine.TabIndex = 1;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(0, 4);
            this.picBoxLogo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(226, 125);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 2;
            this.picBoxLogo.TabStop = false;
            // 
            // lblTeacherDashBoard
            // 
            this.lblTeacherDashBoard.AutoSize = true;
            this.lblTeacherDashBoard.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.lblTeacherDashBoard.Location = new System.Drawing.Point(536, 1);
            this.lblTeacherDashBoard.Name = "lblTeacherDashBoard";
            this.lblTeacherDashBoard.Size = new System.Drawing.Size(717, 115);
            this.lblTeacherDashBoard.TabIndex = 1;
            this.lblTeacherDashBoard.Text = " TEACHER DASHBOARD";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnStudentsMsrks);
            this.pnlMenu.Controls.Add(this.btnStudentsAdd);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 125);
            this.pnlMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(226, 925);
            this.pnlMenu.TabIndex = 2;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Bahnschrift", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 861);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(226, 64);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnStudentsMsrks
            // 
            this.btnStudentsMsrks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnStudentsMsrks.FlatAppearance.BorderSize = 0;
            this.btnStudentsMsrks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsMsrks.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentsMsrks.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStudentsMsrks.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentsMsrks.Image")));
            this.btnStudentsMsrks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentsMsrks.Location = new System.Drawing.Point(0, 134);
            this.btnStudentsMsrks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudentsMsrks.Name = "btnStudentsMsrks";
            this.btnStudentsMsrks.Size = new System.Drawing.Size(226, 128);
            this.btnStudentsMsrks.TabIndex = 1;
            this.btnStudentsMsrks.Text = " Mark";
            this.btnStudentsMsrks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentsMsrks.UseVisualStyleBackColor = false;
            this.btnStudentsMsrks.Click += new System.EventHandler(this.btnStudentsMsrks_Click);
            // 
            // btnStudentsAdd
            // 
            this.btnStudentsAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnStudentsAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentsAdd.FlatAppearance.BorderSize = 0;
            this.btnStudentsAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentsAdd.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentsAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStudentsAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnStudentsAdd.Image")));
            this.btnStudentsAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentsAdd.Location = new System.Drawing.Point(0, 0);
            this.btnStudentsAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudentsAdd.Name = "btnStudentsAdd";
            this.btnStudentsAdd.Size = new System.Drawing.Size(226, 128);
            this.btnStudentsAdd.TabIndex = 0;
            this.btnStudentsAdd.Text = "Student";
            this.btnStudentsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudentsAdd.UseVisualStyleBackColor = false;
            this.btnStudentsAdd.Click += new System.EventHandler(this.btnStudentsAdd_Click);
            // 
            // panelFormLoad
            // 
            this.panelFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panelFormLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoad.Location = new System.Drawing.Point(226, 125);
            this.panelFormLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelFormLoad.Name = "panelFormLoad";
            this.panelFormLoad.Size = new System.Drawing.Size(1452, 925);
            this.panelFormLoad.TabIndex = 3;
            // 
            // FormTeacherPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1678, 1050);
            this.Controls.Add(this.panelFormLoad);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHearBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormTeacherPanel";
            this.Text = "FormTeacherPanel";
            this.pnlHearBar.ResumeLayout(false);
            this.panelHeadLine.ResumeLayout(false);
            this.panelHeadLine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHearBar;
        private System.Windows.Forms.Panel panelHeadLine;
        private System.Windows.Forms.Label lblTeacherDashBoard;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStudentsAdd;
        private System.Windows.Forms.Panel panelFormLoad;
        private System.Windows.Forms.Button btnStudentsMsrks;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.PictureBox picBoxLogo;
    }
}