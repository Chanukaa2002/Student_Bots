namespace Student_Bots
{
    partial class Form1AddStudentcs
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
            this.txtBoxStdName = new System.Windows.Forms.TextBox();
            this.lblStdName = new System.Windows.Forms.Label();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtBoxIndex = new System.Windows.Forms.TextBox();
            this.lblIndex = new System.Windows.Forms.Label();
            this.lblAddmitionDate = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.txtBoxGardian = new System.Windows.Forms.TextBox();
            this.lblGardianName = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.txtBoxAddress = new System.Windows.Forms.TextBox();
            this.lblAddres = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePickerAddmition = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.lblErrorIndex = new System.Windows.Forms.Label();
            this.lblErrorGender = new System.Windows.Forms.Label();
            this.lblErrorGrade = new System.Windows.Forms.Label();
            this.lblErrorStudentName = new System.Windows.Forms.Label();
            this.lblErrorDOB = new System.Windows.Forms.Label();
            this.lblErrorGardian = new System.Windows.Forms.Label();
            this.lblErrorAddress = new System.Windows.Forms.Label();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxStdName
            // 
            this.txtBoxStdName.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStdName.Location = new System.Drawing.Point(250, 69);
            this.txtBoxStdName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxStdName.Name = "txtBoxStdName";
            this.txtBoxStdName.Size = new System.Drawing.Size(363, 41);
            this.txtBoxStdName.TabIndex = 0;
            this.txtBoxStdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStdName_Validating);
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStdName.Location = new System.Drawing.Point(24, 70);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(227, 40);
            this.lblStdName.TabIndex = 4;
            this.lblStdName.Text = "Student Name";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGrade.Location = new System.Drawing.Point(24, 146);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(106, 40);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade";
            // 
            // txtBoxIndex
            // 
            this.txtBoxIndex.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIndex.Location = new System.Drawing.Point(250, 365);
            this.txtBoxIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxIndex.Name = "txtBoxIndex";
            this.txtBoxIndex.Size = new System.Drawing.Size(363, 41);
            this.txtBoxIndex.TabIndex = 4;
            this.txtBoxIndex.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxIndex_Validating);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblIndex.Location = new System.Drawing.Point(24, 366);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(97, 40);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.Text = "Index";
            // 
            // lblAddmitionDate
            // 
            this.lblAddmitionDate.AutoSize = true;
            this.lblAddmitionDate.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddmitionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblAddmitionDate.Location = new System.Drawing.Point(12, 431);
            this.lblAddmitionDate.Name = "lblAddmitionDate";
            this.lblAddmitionDate.Size = new System.Drawing.Size(243, 40);
            this.lblAddmitionDate.TabIndex = 10;
            this.lblAddmitionDate.Text = "Addmition Date";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblDob.Location = new System.Drawing.Point(24, 498);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(204, 40);
            this.lblDob.TabIndex = 12;
            this.lblDob.Text = "Date of Birth";
            // 
            // txtBoxGardian
            // 
            this.txtBoxGardian.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGardian.Location = new System.Drawing.Point(252, 569);
            this.txtBoxGardian.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxGardian.Name = "txtBoxGardian";
            this.txtBoxGardian.Size = new System.Drawing.Size(363, 41);
            this.txtBoxGardian.TabIndex = 7;
            this.txtBoxGardian.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxGardian_Validating);
            // 
            // lblGardianName
            // 
            this.lblGardianName.AutoSize = true;
            this.lblGardianName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGardianName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGardianName.Location = new System.Drawing.Point(26, 571);
            this.lblGardianName.Name = "lblGardianName";
            this.lblGardianName.Size = new System.Drawing.Size(228, 40);
            this.lblGardianName.TabIndex = 14;
            this.lblGardianName.Text = "Gardian Name";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "-Select-",
            "Grade 1",
            "Grade 2",
            "Grade 3",
            "Grade 4",
            "Grade 5",
            "Grade 6",
            "Grade 7",
            "Grade 8",
            "Grade 9",
            "Grade 10",
            "Grade 11"});
            this.comboBoxGrade.Location = new System.Drawing.Point(250, 148);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(363, 42);
            this.comboBoxGrade.TabIndex = 1;
            this.comboBoxGrade.Text = "-Select-";
            this.comboBoxGrade.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGrade_Validating);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(252, 636);
            this.txtBoxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(363, 89);
            this.txtBoxAddress.TabIndex = 8;
            this.txtBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxAddress_Validating);
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblAddres.Location = new System.Drawing.Point(26, 638);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(140, 40);
            this.lblAddres.TabIndex = 17;
            this.lblAddres.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGender.Location = new System.Drawing.Point(26, 289);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(124, 40);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(252, 289);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(120, 47);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            this.radioButtonMale.Validating += new System.ComponentModel.CancelEventHandler(this.radioButtonMale_Validating);
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFemale.Location = new System.Drawing.Point(395, 290);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(162, 47);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.Validating += new System.ComponentModel.CancelEventHandler(this.radioButtonFemale_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(707, 520);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(232, 82);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(707, 636);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(232, 82);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePickerAddmition
            // 
            this.dateTimePickerAddmition.Location = new System.Drawing.Point(252, 442);
            this.dateTimePickerAddmition.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerAddmition.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAddmition.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAddmition.Name = "dateTimePickerAddmition";
            this.dateTimePickerAddmition.Size = new System.Drawing.Size(361, 26);
            this.dateTimePickerAddmition.TabIndex = 5;
            this.dateTimePickerAddmition.Value = new System.DateTime(2024, 5, 12, 14, 57, 39, 0);
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Location = new System.Drawing.Point(250, 507);
            this.dateTimePickerDob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(361, 26);
            this.dateTimePickerDob.TabIndex = 6;
            this.dateTimePickerDob.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePickerDob_Validating);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(1029, 520);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(232, 82);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(677, 97);
            this.dataGridViewStudents.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(656, 352);
            this.dataGridViewStudents.TabIndex = 25;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // lblErrorIndex
            // 
            this.lblErrorIndex.AutoSize = true;
            this.lblErrorIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIndex.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIndex.Location = new System.Drawing.Point(623, 368);
            this.lblErrorIndex.Name = "lblErrorIndex";
            this.lblErrorIndex.Size = new System.Drawing.Size(36, 46);
            this.lblErrorIndex.TabIndex = 28;
            this.lblErrorIndex.Text = "*";
            this.lblErrorIndex.Visible = false;
            // 
            // lblErrorGender
            // 
            this.lblErrorGender.AutoSize = true;
            this.lblErrorGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGender.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGender.Location = new System.Drawing.Point(549, 298);
            this.lblErrorGender.Name = "lblErrorGender";
            this.lblErrorGender.Size = new System.Drawing.Size(36, 46);
            this.lblErrorGender.TabIndex = 29;
            this.lblErrorGender.Text = "*";
            this.lblErrorGender.Visible = false;
            // 
            // lblErrorGrade
            // 
            this.lblErrorGrade.AutoSize = true;
            this.lblErrorGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGrade.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGrade.Location = new System.Drawing.Point(620, 156);
            this.lblErrorGrade.Name = "lblErrorGrade";
            this.lblErrorGrade.Size = new System.Drawing.Size(36, 46);
            this.lblErrorGrade.TabIndex = 30;
            this.lblErrorGrade.Text = "*";
            this.lblErrorGrade.Visible = false;
            // 
            // lblErrorStudentName
            // 
            this.lblErrorStudentName.AutoSize = true;
            this.lblErrorStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStudentName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStudentName.Location = new System.Drawing.Point(620, 70);
            this.lblErrorStudentName.Name = "lblErrorStudentName";
            this.lblErrorStudentName.Size = new System.Drawing.Size(36, 46);
            this.lblErrorStudentName.TabIndex = 31;
            this.lblErrorStudentName.Text = "*";
            this.lblErrorStudentName.Visible = false;
            // 
            // lblErrorDOB
            // 
            this.lblErrorDOB.AutoSize = true;
            this.lblErrorDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDOB.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDOB.Location = new System.Drawing.Point(623, 504);
            this.lblErrorDOB.Name = "lblErrorDOB";
            this.lblErrorDOB.Size = new System.Drawing.Size(36, 46);
            this.lblErrorDOB.TabIndex = 32;
            this.lblErrorDOB.Text = "*";
            this.lblErrorDOB.Visible = false;
            // 
            // lblErrorGardian
            // 
            this.lblErrorGardian.AutoSize = true;
            this.lblErrorGardian.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGardian.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGardian.Location = new System.Drawing.Point(623, 572);
            this.lblErrorGardian.Name = "lblErrorGardian";
            this.lblErrorGardian.Size = new System.Drawing.Size(36, 46);
            this.lblErrorGardian.TabIndex = 33;
            this.lblErrorGardian.Text = "*";
            this.lblErrorGardian.Visible = false;
            // 
            // lblErrorAddress
            // 
            this.lblErrorAddress.AutoSize = true;
            this.lblErrorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress.Location = new System.Drawing.Point(623, 642);
            this.lblErrorAddress.Name = "lblErrorAddress";
            this.lblErrorAddress.Size = new System.Drawing.Size(36, 46);
            this.lblErrorAddress.TabIndex = 34;
            this.lblErrorAddress.Text = "*";
            this.lblErrorAddress.Visible = false;
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Items.AddRange(new object[] {
            "-Select-",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.comboBoxClass.Location = new System.Drawing.Point(252, 222);
            this.comboBoxClass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(363, 42);
            this.comboBoxClass.TabIndex = 35;
            this.comboBoxClass.Text = "-Select-";
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblClass.Location = new System.Drawing.Point(26, 220);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(99, 40);
            this.lblClass.TabIndex = 36;
            this.lblClass.Text = "Class";
            // 
            // Form1AddStudentcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1360, 736);
            this.Controls.Add(this.comboBoxClass);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblErrorAddress);
            this.Controls.Add(this.lblErrorGardian);
            this.Controls.Add(this.lblErrorDOB);
            this.Controls.Add(this.lblErrorIndex);
            this.Controls.Add(this.lblErrorGender);
            this.Controls.Add(this.lblErrorGrade);
            this.Controls.Add(this.lblErrorStudentName);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.dateTimePickerDob);
            this.Controls.Add(this.dateTimePickerAddmition);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtBoxAddress);
            this.Controls.Add(this.lblAddres);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.txtBoxGardian);
            this.Controls.Add(this.lblGardianName);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.lblAddmitionDate);
            this.Controls.Add(this.txtBoxIndex);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.txtBoxStdName);
            this.Controls.Add(this.lblStdName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1AddStudentcs";
            this.Text = "Form1AddStudentcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxStdName;
        private System.Windows.Forms.Label lblStdName;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtBoxIndex;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Label lblAddmitionDate;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.TextBox txtBoxGardian;
        private System.Windows.Forms.Label lblGardianName;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.TextBox txtBoxAddress;
        private System.Windows.Forms.Label lblAddres;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddmition;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label lblErrorAddress;
        private System.Windows.Forms.Label lblErrorGardian;
        private System.Windows.Forms.Label lblErrorDOB;
        private System.Windows.Forms.Label lblErrorIndex;
        private System.Windows.Forms.Label lblErrorGender;
        private System.Windows.Forms.Label lblErrorGrade;
        private System.Windows.Forms.Label lblErrorStudentName;
        private System.Windows.Forms.ComboBox comboBoxClass;
        private System.Windows.Forms.Label lblClass;
    }
}