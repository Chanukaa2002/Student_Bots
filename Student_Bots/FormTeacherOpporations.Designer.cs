namespace Student_Bots
{
    partial class FormTeacherOpporations
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
            this.lblTeacerName = new System.Windows.Forms.Label();
            this.llblClassTeacher = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.textBoxTeacherName = new System.Windows.Forms.TextBox();
            this.textBoxClassTeacher = new System.Windows.Forms.TextBox();
            this.textBoxNationality = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.dataGridViewTeacher = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTeacherId = new System.Windows.Forms.Label();
            this.lblTeacherPassword = new System.Windows.Forms.Label();
            this.textBoxTeacherId = new System.Windows.Forms.TextBox();
            this.textBoxTeacherPassword = new System.Windows.Forms.TextBox();
            this.lblErrorTeacherName = new System.Windows.Forms.Label();
            this.lblErrorClass = new System.Windows.Forms.Label();
            this.lblErrorGender = new System.Windows.Forms.Label();
            this.lblErrorNationality = new System.Windows.Forms.Label();
            this.lblErrorAge = new System.Windows.Forms.Label();
            this.lblErrorTeacherId = new System.Windows.Forms.Label();
            this.lblErrorTeacherPassword = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTeacerName
            // 
            this.lblTeacerName.AutoSize = true;
            this.lblTeacerName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblTeacerName.Location = new System.Drawing.Point(23, 53);
            this.lblTeacerName.Name = "lblTeacerName";
            this.lblTeacerName.Size = new System.Drawing.Size(195, 34);
            this.lblTeacerName.TabIndex = 2;
            this.lblTeacerName.Text = "Teacher Name";
            // 
            // llblClassTeacher
            // 
            this.llblClassTeacher.AutoSize = true;
            this.llblClassTeacher.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblClassTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.llblClassTeacher.Location = new System.Drawing.Point(122, 110);
            this.llblClassTeacher.Name = "llblClassTeacher";
            this.llblClassTeacher.Size = new System.Drawing.Size(85, 34);
            this.llblClassTeacher.TabIndex = 2;
            this.llblClassTeacher.Text = "Class";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGender.Location = new System.Drawing.Point(112, 171);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(106, 34);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationality.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblNationality.Location = new System.Drawing.Point(68, 231);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(150, 34);
            this.lblNationality.TabIndex = 2;
            this.lblNationality.Text = "Nationality";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblAge.Location = new System.Drawing.Point(155, 286);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(63, 34);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // textBoxTeacherName
            // 
            this.textBoxTeacherName.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherName.Location = new System.Drawing.Point(224, 55);
            this.textBoxTeacherName.Name = "textBoxTeacherName";
            this.textBoxTeacherName.Size = new System.Drawing.Size(323, 35);
            this.textBoxTeacherName.TabIndex = 0;
            this.textBoxTeacherName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTeacherName_Validating);
            // 
            // textBoxClassTeacher
            // 
            this.textBoxClassTeacher.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxClassTeacher.Location = new System.Drawing.Point(224, 109);
            this.textBoxClassTeacher.Name = "textBoxClassTeacher";
            this.textBoxClassTeacher.Size = new System.Drawing.Size(323, 35);
            this.textBoxClassTeacher.TabIndex = 1;
            this.textBoxClassTeacher.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxClassTeacher_Validating);
            // 
            // textBoxNationality
            // 
            this.textBoxNationality.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNationality.Location = new System.Drawing.Point(224, 230);
            this.textBoxNationality.Name = "textBoxNationality";
            this.textBoxNationality.Size = new System.Drawing.Size(323, 35);
            this.textBoxNationality.TabIndex = 3;
            this.textBoxNationality.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxNationality_Validating);
            // 
            // textBoxAge
            // 
            this.textBoxAge.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAge.Location = new System.Drawing.Point(224, 285);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(323, 35);
            this.textBoxAge.TabIndex = 4;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "-Select-",
            "Male",
            "Female"});
            this.comboBoxGender.Location = new System.Drawing.Point(224, 172);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(323, 36);
            this.comboBoxGender.TabIndex = 2;
            this.comboBoxGender.Text = "-Select-";
            this.comboBoxGender.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGender_Validating);
            // 
            // dataGridViewTeacher
            // 
            this.dataGridViewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeacher.Location = new System.Drawing.Point(184, 378);
            this.dataGridViewTeacher.Name = "dataGridViewTeacher";
            this.dataGridViewTeacher.RowHeadersWidth = 51;
            this.dataGridViewTeacher.RowTemplate.Height = 24;
            this.dataGridViewTeacher.Size = new System.Drawing.Size(796, 237);
            this.dataGridViewTeacher.TabIndex = 5;
            this.dataGridViewTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellClick);
            this.dataGridViewTeacher.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeacher_CellContentClick);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(778, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 63);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(944, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(148, 63);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(778, 288);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(148, 63);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(944, 288);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(148, 63);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblTeacherId
            // 
            this.lblTeacherId.AutoSize = true;
            this.lblTeacherId.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblTeacherId.Location = new System.Drawing.Point(643, 63);
            this.lblTeacherId.Name = "lblTeacherId";
            this.lblTeacherId.Size = new System.Drawing.Size(144, 34);
            this.lblTeacherId.TabIndex = 2;
            this.lblTeacherId.Text = "Teacher Id";
            // 
            // lblTeacherPassword
            // 
            this.lblTeacherPassword.AutoSize = true;
            this.lblTeacherPassword.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblTeacherPassword.Location = new System.Drawing.Point(647, 115);
            this.lblTeacherPassword.Name = "lblTeacherPassword";
            this.lblTeacherPassword.Size = new System.Drawing.Size(140, 34);
            this.lblTeacherPassword.TabIndex = 2;
            this.lblTeacherPassword.Text = "Password";
            // 
            // textBoxTeacherId
            // 
            this.textBoxTeacherId.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherId.Location = new System.Drawing.Point(807, 64);
            this.textBoxTeacherId.Name = "textBoxTeacherId";
            this.textBoxTeacherId.Size = new System.Drawing.Size(323, 35);
            this.textBoxTeacherId.TabIndex = 5;
            this.textBoxTeacherId.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTeacherId_Validating);
            // 
            // textBoxTeacherPassword
            // 
            this.textBoxTeacherPassword.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTeacherPassword.Location = new System.Drawing.Point(807, 116);
            this.textBoxTeacherPassword.Name = "textBoxTeacherPassword";
            this.textBoxTeacherPassword.Size = new System.Drawing.Size(323, 35);
            this.textBoxTeacherPassword.TabIndex = 6;
            this.textBoxTeacherPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxTeacherPassword_Validating);
            // 
            // lblErrorTeacherName
            // 
            this.lblErrorTeacherName.AutoSize = true;
            this.lblErrorTeacherName.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeacherName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTeacherName.Location = new System.Drawing.Point(550, 59);
            this.lblErrorTeacherName.Name = "lblErrorTeacherName";
            this.lblErrorTeacherName.Size = new System.Drawing.Size(35, 38);
            this.lblErrorTeacherName.TabIndex = 7;
            this.lblErrorTeacherName.Text = "*";
            this.lblErrorTeacherName.Visible = false;
            // 
            // lblErrorClass
            // 
            this.lblErrorClass.AutoSize = true;
            this.lblErrorClass.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClass.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClass.Location = new System.Drawing.Point(550, 107);
            this.lblErrorClass.Name = "lblErrorClass";
            this.lblErrorClass.Size = new System.Drawing.Size(35, 38);
            this.lblErrorClass.TabIndex = 7;
            this.lblErrorClass.Text = "*";
            this.lblErrorClass.Visible = false;
            // 
            // lblErrorGender
            // 
            this.lblErrorGender.AutoSize = true;
            this.lblErrorGender.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGender.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGender.Location = new System.Drawing.Point(553, 172);
            this.lblErrorGender.Name = "lblErrorGender";
            this.lblErrorGender.Size = new System.Drawing.Size(35, 38);
            this.lblErrorGender.TabIndex = 7;
            this.lblErrorGender.Text = "*";
            this.lblErrorGender.Visible = false;
            // 
            // lblErrorNationality
            // 
            this.lblErrorNationality.AutoSize = true;
            this.lblErrorNationality.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorNationality.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNationality.Location = new System.Drawing.Point(553, 231);
            this.lblErrorNationality.Name = "lblErrorNationality";
            this.lblErrorNationality.Size = new System.Drawing.Size(35, 38);
            this.lblErrorNationality.TabIndex = 7;
            this.lblErrorNationality.Text = "*";
            this.lblErrorNationality.Visible = false;
            // 
            // lblErrorAge
            // 
            this.lblErrorAge.AutoSize = true;
            this.lblErrorAge.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAge.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAge.Location = new System.Drawing.Point(553, 286);
            this.lblErrorAge.Name = "lblErrorAge";
            this.lblErrorAge.Size = new System.Drawing.Size(35, 38);
            this.lblErrorAge.TabIndex = 7;
            this.lblErrorAge.Text = "*";
            this.lblErrorAge.Visible = false;
            // 
            // lblErrorTeacherId
            // 
            this.lblErrorTeacherId.AutoSize = true;
            this.lblErrorTeacherId.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeacherId.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTeacherId.Location = new System.Drawing.Point(1136, 64);
            this.lblErrorTeacherId.Name = "lblErrorTeacherId";
            this.lblErrorTeacherId.Size = new System.Drawing.Size(35, 38);
            this.lblErrorTeacherId.TabIndex = 7;
            this.lblErrorTeacherId.Text = "*";
            this.lblErrorTeacherId.Visible = false;
            // 
            // lblErrorTeacherPassword
            // 
            this.lblErrorTeacherPassword.AutoSize = true;
            this.lblErrorTeacherPassword.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorTeacherPassword.ForeColor = System.Drawing.Color.Red;
            this.lblErrorTeacherPassword.Location = new System.Drawing.Point(1136, 119);
            this.lblErrorTeacherPassword.Name = "lblErrorTeacherPassword";
            this.lblErrorTeacherPassword.Size = new System.Drawing.Size(35, 38);
            this.lblErrorTeacherPassword.TabIndex = 7;
            this.lblErrorTeacherPassword.Text = "*";
            this.lblErrorTeacherPassword.Visible = false;
            // 
            // FormTeacherOpporations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1197, 627);
            this.Controls.Add(this.lblErrorTeacherPassword);
            this.Controls.Add(this.lblErrorAge);
            this.Controls.Add(this.lblErrorTeacherId);
            this.Controls.Add(this.lblErrorNationality);
            this.Controls.Add(this.lblErrorGender);
            this.Controls.Add(this.lblErrorClass);
            this.Controls.Add(this.lblErrorTeacherName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridViewTeacher);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxNationality);
            this.Controls.Add(this.textBoxTeacherPassword);
            this.Controls.Add(this.textBoxClassTeacher);
            this.Controls.Add(this.textBoxTeacherId);
            this.Controls.Add(this.textBoxTeacherName);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblNationality);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblTeacherPassword);
            this.Controls.Add(this.lblTeacherId);
            this.Controls.Add(this.llblClassTeacher);
            this.Controls.Add(this.lblTeacerName);
            this.Name = "FormTeacherOpporations";
            this.Text = "FormTeacherOpporations";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeacher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTeacerName;
        private System.Windows.Forms.Label llblClassTeacher;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox textBoxTeacherName;
        private System.Windows.Forms.TextBox textBoxClassTeacher;
        private System.Windows.Forms.TextBox textBoxNationality;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.DataGridView dataGridViewTeacher;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTeacherId;
        private System.Windows.Forms.Label lblTeacherPassword;
        private System.Windows.Forms.TextBox textBoxTeacherId;
        private System.Windows.Forms.TextBox textBoxTeacherPassword;
        private System.Windows.Forms.Label lblErrorTeacherName;
        private System.Windows.Forms.Label lblErrorClass;
        private System.Windows.Forms.Label lblErrorGender;
        private System.Windows.Forms.Label lblErrorNationality;
        private System.Windows.Forms.Label lblErrorAge;
        private System.Windows.Forms.Label lblErrorTeacherId;
        private System.Windows.Forms.Label lblErrorTeacherPassword;
    }
}