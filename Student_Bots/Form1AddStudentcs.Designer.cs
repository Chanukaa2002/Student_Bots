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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1AddStudentcs));
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
            this.lblImage = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dateTimePickerAddmition = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDob = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.pictureBoxStdImage = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblErrorIndex = new System.Windows.Forms.Label();
            this.lblErrorGender = new System.Windows.Forms.Label();
            this.lblErrorGrade = new System.Windows.Forms.Label();
            this.lblErrorStudentName = new System.Windows.Forms.Label();
            this.lblErrorDOB = new System.Windows.Forms.Label();
            this.lblErrorGardian = new System.Windows.Forms.Label();
            this.lblErrorAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStdImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxStdName
            // 
            this.txtBoxStdName.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStdName.Location = new System.Drawing.Point(222, 55);
            this.txtBoxStdName.Name = "txtBoxStdName";
            this.txtBoxStdName.Size = new System.Drawing.Size(323, 35);
            this.txtBoxStdName.TabIndex = 0;
            this.txtBoxStdName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxStdName_Validating);
            // 
            // lblStdName
            // 
            this.lblStdName.AutoSize = true;
            this.lblStdName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStdName.Location = new System.Drawing.Point(21, 56);
            this.lblStdName.Name = "lblStdName";
            this.lblStdName.Size = new System.Drawing.Size(194, 34);
            this.lblStdName.TabIndex = 4;
            this.lblStdName.Text = "Student Name";
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGrade.Location = new System.Drawing.Point(21, 117);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(90, 34);
            this.lblGrade.TabIndex = 6;
            this.lblGrade.Text = "Grade";
            // 
            // txtBoxIndex
            // 
            this.txtBoxIndex.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIndex.Location = new System.Drawing.Point(222, 257);
            this.txtBoxIndex.Name = "txtBoxIndex";
            this.txtBoxIndex.Size = new System.Drawing.Size(323, 35);
            this.txtBoxIndex.TabIndex = 4;
            this.txtBoxIndex.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxIndex_Validating);
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblIndex.Location = new System.Drawing.Point(21, 258);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(83, 34);
            this.lblIndex.TabIndex = 8;
            this.lblIndex.Text = "Index";
            // 
            // lblAddmitionDate
            // 
            this.lblAddmitionDate.AutoSize = true;
            this.lblAddmitionDate.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddmitionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblAddmitionDate.Location = new System.Drawing.Point(11, 318);
            this.lblAddmitionDate.Name = "lblAddmitionDate";
            this.lblAddmitionDate.Size = new System.Drawing.Size(206, 34);
            this.lblAddmitionDate.TabIndex = 10;
            this.lblAddmitionDate.Text = "Addmition Date";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblDob.Location = new System.Drawing.Point(21, 381);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(174, 34);
            this.lblDob.TabIndex = 12;
            this.lblDob.Text = "Date of Birth";
            // 
            // txtBoxGardian
            // 
            this.txtBoxGardian.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGardian.Location = new System.Drawing.Point(224, 445);
            this.txtBoxGardian.Name = "txtBoxGardian";
            this.txtBoxGardian.Size = new System.Drawing.Size(323, 35);
            this.txtBoxGardian.TabIndex = 7;
            this.txtBoxGardian.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxGardian_Validating);
            // 
            // lblGardianName
            // 
            this.lblGardianName.AutoSize = true;
            this.lblGardianName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGardianName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGardianName.Location = new System.Drawing.Point(23, 446);
            this.lblGardianName.Name = "lblGardianName";
            this.lblGardianName.Size = new System.Drawing.Size(195, 34);
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
            this.comboBoxGrade.Location = new System.Drawing.Point(222, 118);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(323, 36);
            this.comboBoxGrade.TabIndex = 1;
            this.comboBoxGrade.Text = "-Select-";
            this.comboBoxGrade.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxGrade_Validating);
            // 
            // txtBoxAddress
            // 
            this.txtBoxAddress.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAddress.Location = new System.Drawing.Point(224, 509);
            this.txtBoxAddress.Multiline = true;
            this.txtBoxAddress.Name = "txtBoxAddress";
            this.txtBoxAddress.Size = new System.Drawing.Size(323, 72);
            this.txtBoxAddress.TabIndex = 8;
            this.txtBoxAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxAddress_Validating);
            // 
            // lblAddres
            // 
            this.lblAddres.AutoSize = true;
            this.lblAddres.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblAddres.Location = new System.Drawing.Point(23, 510);
            this.lblAddres.Name = "lblAddres";
            this.lblAddres.Size = new System.Drawing.Size(120, 34);
            this.lblAddres.TabIndex = 17;
            this.lblAddres.Text = "Address";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGender.Location = new System.Drawing.Point(23, 188);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(106, 34);
            this.lblGender.TabIndex = 19;
            this.lblGender.Text = "Gender";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Font = new System.Drawing.Font("Bahnschrift SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMale.Location = new System.Drawing.Point(224, 188);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(100, 40);
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
            this.radioButtonFemale.Location = new System.Drawing.Point(351, 189);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(136, 40);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            this.radioButtonFemale.Validating += new System.ComponentModel.CancelEventHandler(this.radioButtonFemale_Validating);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblImage.Location = new System.Drawing.Point(665, 39);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(92, 34);
            this.lblImage.TabIndex = 9;
            this.lblImage.Text = "Image";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.SystemColors.Control;
            this.btnImport.Location = new System.Drawing.Point(776, 132);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(142, 41);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(710, 476);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 66);
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
            this.btnClear.Location = new System.Drawing.Point(710, 548);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(206, 66);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dateTimePickerAddmition
            // 
            this.dateTimePickerAddmition.Location = new System.Drawing.Point(224, 327);
            this.dateTimePickerAddmition.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerAddmition.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerAddmition.Name = "dateTimePickerAddmition";
            this.dateTimePickerAddmition.Size = new System.Drawing.Size(321, 22);
            this.dateTimePickerAddmition.TabIndex = 5;
            this.dateTimePickerAddmition.Value = new System.DateTime(2024, 5, 12, 14, 57, 39, 0);
            // 
            // dateTimePickerDob
            // 
            this.dateTimePickerDob.Location = new System.Drawing.Point(222, 388);
            this.dateTimePickerDob.Name = "dateTimePickerDob";
            this.dateTimePickerDob.Size = new System.Drawing.Size(321, 22);
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
            this.btnUpdate.Location = new System.Drawing.Point(979, 467);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 66);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(979, 548);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 66);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(602, 179);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(583, 282);
            this.dataGridViewStudents.TabIndex = 25;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // pictureBoxStdImage
            // 
            this.pictureBoxStdImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStdImage.Image")));
            this.pictureBoxStdImage.Location = new System.Drawing.Point(799, 23);
            this.pictureBoxStdImage.Name = "pictureBoxStdImage";
            this.pictureBoxStdImage.Size = new System.Drawing.Size(88, 92);
            this.pictureBoxStdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStdImage.TabIndex = 26;
            this.pictureBoxStdImage.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lblErrorIndex
            // 
            this.lblErrorIndex.AutoSize = true;
            this.lblErrorIndex.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorIndex.ForeColor = System.Drawing.Color.Red;
            this.lblErrorIndex.Location = new System.Drawing.Point(554, 259);
            this.lblErrorIndex.Name = "lblErrorIndex";
            this.lblErrorIndex.Size = new System.Drawing.Size(35, 38);
            this.lblErrorIndex.TabIndex = 28;
            this.lblErrorIndex.Text = "*";
            this.lblErrorIndex.Visible = false;
            // 
            // lblErrorGender
            // 
            this.lblErrorGender.AutoSize = true;
            this.lblErrorGender.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGender.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGender.Location = new System.Drawing.Point(488, 195);
            this.lblErrorGender.Name = "lblErrorGender";
            this.lblErrorGender.Size = new System.Drawing.Size(35, 38);
            this.lblErrorGender.TabIndex = 29;
            this.lblErrorGender.Text = "*";
            this.lblErrorGender.Visible = false;
            // 
            // lblErrorGrade
            // 
            this.lblErrorGrade.AutoSize = true;
            this.lblErrorGrade.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGrade.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGrade.Location = new System.Drawing.Point(551, 125);
            this.lblErrorGrade.Name = "lblErrorGrade";
            this.lblErrorGrade.Size = new System.Drawing.Size(35, 38);
            this.lblErrorGrade.TabIndex = 30;
            this.lblErrorGrade.Text = "*";
            this.lblErrorGrade.Visible = false;
            // 
            // lblErrorStudentName
            // 
            this.lblErrorStudentName.AutoSize = true;
            this.lblErrorStudentName.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStudentName.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStudentName.Location = new System.Drawing.Point(551, 56);
            this.lblErrorStudentName.Name = "lblErrorStudentName";
            this.lblErrorStudentName.Size = new System.Drawing.Size(35, 38);
            this.lblErrorStudentName.TabIndex = 31;
            this.lblErrorStudentName.Text = "*";
            this.lblErrorStudentName.Visible = false;
            // 
            // lblErrorDOB
            // 
            this.lblErrorDOB.AutoSize = true;
            this.lblErrorDOB.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDOB.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDOB.Location = new System.Drawing.Point(554, 386);
            this.lblErrorDOB.Name = "lblErrorDOB";
            this.lblErrorDOB.Size = new System.Drawing.Size(35, 38);
            this.lblErrorDOB.TabIndex = 32;
            this.lblErrorDOB.Text = "*";
            this.lblErrorDOB.Visible = false;
            // 
            // lblErrorGardian
            // 
            this.lblErrorGardian.AutoSize = true;
            this.lblErrorGardian.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorGardian.ForeColor = System.Drawing.Color.Red;
            this.lblErrorGardian.Location = new System.Drawing.Point(554, 447);
            this.lblErrorGardian.Name = "lblErrorGardian";
            this.lblErrorGardian.Size = new System.Drawing.Size(35, 38);
            this.lblErrorGardian.TabIndex = 33;
            this.lblErrorGardian.Text = "*";
            this.lblErrorGardian.Visible = false;
            // 
            // lblErrorAddress
            // 
            this.lblErrorAddress.AutoSize = true;
            this.lblErrorAddress.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorAddress.ForeColor = System.Drawing.Color.Red;
            this.lblErrorAddress.Location = new System.Drawing.Point(554, 514);
            this.lblErrorAddress.Name = "lblErrorAddress";
            this.lblErrorAddress.Size = new System.Drawing.Size(35, 38);
            this.lblErrorAddress.TabIndex = 34;
            this.lblErrorAddress.Text = "*";
            this.lblErrorAddress.Visible = false;
            // 
            // Form1AddStudentcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1197, 627);
            this.Controls.Add(this.lblErrorAddress);
            this.Controls.Add(this.lblErrorGardian);
            this.Controls.Add(this.lblErrorDOB);
            this.Controls.Add(this.lblErrorIndex);
            this.Controls.Add(this.lblErrorGender);
            this.Controls.Add(this.lblErrorGrade);
            this.Controls.Add(this.lblErrorStudentName);
            this.Controls.Add(this.pictureBoxStdImage);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.dateTimePickerDob);
            this.Controls.Add(this.dateTimePickerAddmition);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnImport);
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
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblStdName);
            this.Name = "Form1AddStudentcs";
            this.Text = "Form1AddStudentcs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStdImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddmition;
        private System.Windows.Forms.DateTimePicker dateTimePickerDob;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.PictureBox pictureBoxStdImage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lblErrorAddress;
        private System.Windows.Forms.Label lblErrorGardian;
        private System.Windows.Forms.Label lblErrorDOB;
        private System.Windows.Forms.Label lblErrorIndex;
        private System.Windows.Forms.Label lblErrorGender;
        private System.Windows.Forms.Label lblErrorGrade;
        private System.Windows.Forms.Label lblErrorStudentName;
    }
}