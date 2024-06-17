namespace Student_Bots
{
    partial class FormPrincipalPanal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipalPanal));
            this.pnlHearBar = new System.Windows.Forms.Panel();
            this.panelHeadLine = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblPrincipalDashBoard = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnLetters = new System.Windows.Forms.Button();
            this.btnTeacher = new System.Windows.Forms.Button();
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
            this.pnlHearBar.Name = "pnlHearBar";
            this.pnlHearBar.Size = new System.Drawing.Size(1416, 100);
            this.pnlHearBar.TabIndex = 0;
            // 
            // panelHeadLine
            // 
            this.panelHeadLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.panelHeadLine.Controls.Add(this.picBoxLogo);
            this.panelHeadLine.Controls.Add(this.lblPrincipalDashBoard);
            this.panelHeadLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelHeadLine.Location = new System.Drawing.Point(0, 0);
            this.panelHeadLine.Name = "panelHeadLine";
            this.panelHeadLine.Size = new System.Drawing.Size(1416, 100);
            this.panelHeadLine.TabIndex = 1;
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(201, 100);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 0;
            this.picBoxLogo.TabStop = false;
            // 
            // lblPrincipalDashBoard
            // 
            this.lblPrincipalDashBoard.AutoSize = true;
            this.lblPrincipalDashBoard.Font = new System.Drawing.Font("Bahnschrift Condensed", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipalDashBoard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.lblPrincipalDashBoard.Location = new System.Drawing.Point(444, 4);
            this.lblPrincipalDashBoard.Name = "lblPrincipalDashBoard";
            this.lblPrincipalDashBoard.Size = new System.Drawing.Size(624, 96);
            this.lblPrincipalDashBoard.TabIndex = 1;
            this.lblPrincipalDashBoard.Text = "PRINCIPAL DASHBOARD";
            this.lblPrincipalDashBoard.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(12)))), ((int)(((byte)(156)))));
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnDashBoard);
            this.pnlMenu.Controls.Add(this.btnStudents);
            this.pnlMenu.Controls.Add(this.btnLetters);
            this.pnlMenu.Controls.Add(this.btnTeacher);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 100);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(201, 674);
            this.pnlMenu.TabIndex = 1;
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
            this.btnLogOut.Location = new System.Drawing.Point(0, 623);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(201, 51);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashBoard.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            this.btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashBoard.Location = new System.Drawing.Point(0, 268);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(201, 84);
            this.btnDashBoard.TabIndex = 2;
            this.btnDashBoard.Text = "Analytic";
            this.btnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashBoard.UseVisualStyleBackColor = false;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudents.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnStudents.Image")));
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 179);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(201, 84);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Student";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStudents.UseVisualStyleBackColor = false;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnLetters
            // 
            this.btnLetters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnLetters.FlatAppearance.BorderSize = 0;
            this.btnLetters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLetters.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLetters.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLetters.Image = ((System.Drawing.Image)(resources.GetObject("btnLetters.Image")));
            this.btnLetters.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLetters.Location = new System.Drawing.Point(0, 90);
            this.btnLetters.Name = "btnLetters";
            this.btnLetters.Size = new System.Drawing.Size(201, 84);
            this.btnLetters.TabIndex = 1;
            this.btnLetters.Text = "Letter";
            this.btnLetters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLetters.UseVisualStyleBackColor = false;
            this.btnLetters.Click += new System.EventHandler(this.btnLetters_Click);
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnTeacher.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeacher.FlatAppearance.BorderSize = 0;
            this.btnTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeacher.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacher.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacher.Location = new System.Drawing.Point(0, 0);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(201, 84);
            this.btnTeacher.TabIndex = 0;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTeacher.UseVisualStyleBackColor = false;
            this.btnTeacher.Click += new System.EventHandler(this.btnTeacher_Click);
            // 
            // panelFormLoad
            // 
            this.panelFormLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panelFormLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormLoad.Location = new System.Drawing.Point(201, 100);
            this.panelFormLoad.Name = "panelFormLoad";
            this.panelFormLoad.Size = new System.Drawing.Size(1215, 674);
            this.panelFormLoad.TabIndex = 2;
            this.panelFormLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormLoad_Paint);
            // 
            // FormPrincipalPanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1416, 774);
            this.Controls.Add(this.panelFormLoad);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHearBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPrincipalPanal";
            this.Text = "FormPrincipalPanal";
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
        private System.Windows.Forms.Label lblPrincipalDashBoard;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnLetters;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panelFormLoad;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Button btnDashBoard;
    }
}