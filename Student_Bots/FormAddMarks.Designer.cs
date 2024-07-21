namespace Student_Bots
{
    partial class FormAddMarks
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
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.dataGridViewMarkDetails = new System.Windows.Forms.DataGridView();
            this.txtBoxStdId = new System.Windows.Forms.TextBox();
            this.lblStdNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelSubjects = new System.Windows.Forms.Panel();
            this.lblErrorMaths = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblErrorHistory = new System.Windows.Forms.Label();
            this.lblErrorScience = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblErrorBuddist = new System.Windows.Forms.Label();
            this.textBoxOp3 = new System.Windows.Forms.TextBox();
            this.lblErrorSinhala = new System.Windows.Forms.Label();
            this.lblOp3 = new System.Windows.Forms.Label();
            this.textBoxOp2 = new System.Windows.Forms.TextBox();
            this.lblOp2 = new System.Windows.Forms.Label();
            this.textBoxOp1 = new System.Windows.Forms.TextBox();
            this.lblOp1 = new System.Windows.Forms.Label();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.lblEnglish = new System.Windows.Forms.Label();
            this.textBoxHistory = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.textBoxMaths = new System.Windows.Forms.TextBox();
            this.lblMaths = new System.Windows.Forms.Label();
            this.textBoxScience = new System.Windows.Forms.TextBox();
            this.lblScience = new System.Windows.Forms.Label();
            this.textBoxBuddist = new System.Windows.Forms.TextBox();
            this.lblBuddist = new System.Windows.Forms.Label();
            this.textBoxSinhala = new System.Windows.Forms.TextBox();
            this.lblSinhala = new System.Windows.Forms.Label();
            this.lblErrorOp3 = new System.Windows.Forms.Label();
            this.lblErrorOp2 = new System.Windows.Forms.Label();
            this.lblErrorOp1 = new System.Windows.Forms.Label();
            this.lblErrorEnglish = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkDetails)).BeginInit();
            this.panelSubjects.SuspendLayout();
            this.SuspendLayout();
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
            "Grade 11",
            "-All-"});
            this.comboBoxGrade.Location = new System.Drawing.Point(230, 22);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(323, 36);
            this.comboBoxGrade.TabIndex = 0;
            this.comboBoxGrade.Text = "-Select-";
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGrade.Location = new System.Drawing.Point(29, 21);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(90, 34);
            this.lblGrade.TabIndex = 17;
            this.lblGrade.Text = "Grade";
            // 
            // dataGridViewMarkDetails
            // 
            this.dataGridViewMarkDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarkDetails.Location = new System.Drawing.Point(581, 20);
            this.dataGridViewMarkDetails.Name = "dataGridViewMarkDetails";
            this.dataGridViewMarkDetails.RowHeadersWidth = 51;
            this.dataGridViewMarkDetails.RowTemplate.Height = 24;
            this.dataGridViewMarkDetails.Size = new System.Drawing.Size(604, 191);
            this.dataGridViewMarkDetails.TabIndex = 19;
            this.dataGridViewMarkDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarkDetails_CellClick);
            // 
            // txtBoxStdId
            // 
            this.txtBoxStdId.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStdId.Location = new System.Drawing.Point(230, 86);
            this.txtBoxStdId.Name = "txtBoxStdId";
            this.txtBoxStdId.Size = new System.Drawing.Size(323, 35);
            this.txtBoxStdId.TabIndex = 1;
            // 
            // lblStdNo
            // 
            this.lblStdNo.AutoSize = true;
            this.lblStdNo.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStdNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStdNo.Location = new System.Drawing.Point(29, 87);
            this.lblStdNo.Name = "lblStdNo";
            this.lblStdNo.Size = new System.Drawing.Size(126, 34);
            this.lblStdNo.TabIndex = 20;
            this.lblStdNo.Text = "Index No";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.MediumBlue;
            this.label10.Location = new System.Drawing.Point(217, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 34);
            this.label10.TabIndex = 20;
            this.label10.Text = "Enter Makrs";
            // 
            // panelSubjects
            // 
            this.panelSubjects.Controls.Add(this.lblErrorMaths);
            this.panelSubjects.Controls.Add(this.btnClear);
            this.panelSubjects.Controls.Add(this.lblErrorHistory);
            this.panelSubjects.Controls.Add(this.lblErrorScience);
            this.panelSubjects.Controls.Add(this.btnAdd);
            this.panelSubjects.Controls.Add(this.lblErrorBuddist);
            this.panelSubjects.Controls.Add(this.textBoxOp3);
            this.panelSubjects.Controls.Add(this.lblErrorSinhala);
            this.panelSubjects.Controls.Add(this.lblOp3);
            this.panelSubjects.Controls.Add(this.textBoxOp2);
            this.panelSubjects.Controls.Add(this.lblOp2);
            this.panelSubjects.Controls.Add(this.textBoxOp1);
            this.panelSubjects.Controls.Add(this.lblOp1);
            this.panelSubjects.Controls.Add(this.textBoxEnglish);
            this.panelSubjects.Controls.Add(this.lblEnglish);
            this.panelSubjects.Controls.Add(this.textBoxHistory);
            this.panelSubjects.Controls.Add(this.lblHistory);
            this.panelSubjects.Controls.Add(this.textBoxMaths);
            this.panelSubjects.Controls.Add(this.lblMaths);
            this.panelSubjects.Controls.Add(this.textBoxScience);
            this.panelSubjects.Controls.Add(this.lblScience);
            this.panelSubjects.Controls.Add(this.textBoxBuddist);
            this.panelSubjects.Controls.Add(this.lblBuddist);
            this.panelSubjects.Controls.Add(this.textBoxSinhala);
            this.panelSubjects.Controls.Add(this.lblSinhala);
            this.panelSubjects.Location = new System.Drawing.Point(12, 234);
            this.panelSubjects.Name = "panelSubjects";
            this.panelSubjects.Size = new System.Drawing.Size(1110, 349);
            this.panelSubjects.TabIndex = 2;
            // 
            // lblErrorMaths
            // 
            this.lblErrorMaths.AutoSize = true;
            this.lblErrorMaths.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMaths.ForeColor = System.Drawing.Color.Red;
            this.lblErrorMaths.Location = new System.Drawing.Point(509, 231);
            this.lblErrorMaths.Name = "lblErrorMaths";
            this.lblErrorMaths.Size = new System.Drawing.Size(31, 38);
            this.lblErrorMaths.TabIndex = 27;
            this.lblErrorMaths.Text = "*";
            this.lblErrorMaths.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(936, 273);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 70);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // lblErrorHistory
            // 
            this.lblErrorHistory.AutoSize = true;
            this.lblErrorHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorHistory.ForeColor = System.Drawing.Color.Red;
            this.lblErrorHistory.Location = new System.Drawing.Point(509, 299);
            this.lblErrorHistory.Name = "lblErrorHistory";
            this.lblErrorHistory.Size = new System.Drawing.Size(31, 38);
            this.lblErrorHistory.TabIndex = 28;
            this.lblErrorHistory.Text = "*";
            this.lblErrorHistory.Visible = false;
            // 
            // lblErrorScience
            // 
            this.lblErrorScience.AutoSize = true;
            this.lblErrorScience.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorScience.ForeColor = System.Drawing.Color.Red;
            this.lblErrorScience.Location = new System.Drawing.Point(509, 154);
            this.lblErrorScience.Name = "lblErrorScience";
            this.lblErrorScience.Size = new System.Drawing.Size(31, 38);
            this.lblErrorScience.TabIndex = 29;
            this.lblErrorScience.Text = "*";
            this.lblErrorScience.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAdd.Location = new System.Drawing.Point(731, 273);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 70);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblErrorBuddist
            // 
            this.lblErrorBuddist.AutoSize = true;
            this.lblErrorBuddist.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorBuddist.ForeColor = System.Drawing.Color.Red;
            this.lblErrorBuddist.Location = new System.Drawing.Point(508, 96);
            this.lblErrorBuddist.Name = "lblErrorBuddist";
            this.lblErrorBuddist.Size = new System.Drawing.Size(31, 38);
            this.lblErrorBuddist.TabIndex = 30;
            this.lblErrorBuddist.Text = "*";
            this.lblErrorBuddist.Visible = false;
            // 
            // textBoxOp3
            // 
            this.textBoxOp3.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOp3.Location = new System.Drawing.Point(769, 211);
            this.textBoxOp3.Name = "textBoxOp3";
            this.textBoxOp3.Size = new System.Drawing.Size(323, 35);
            this.textBoxOp3.TabIndex = 8;
            this.textBoxOp3.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOp3_Validating);
            // 
            // lblErrorSinhala
            // 
            this.lblErrorSinhala.AutoSize = true;
            this.lblErrorSinhala.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorSinhala.ForeColor = System.Drawing.Color.Red;
            this.lblErrorSinhala.Location = new System.Drawing.Point(508, 22);
            this.lblErrorSinhala.Name = "lblErrorSinhala";
            this.lblErrorSinhala.Size = new System.Drawing.Size(31, 38);
            this.lblErrorSinhala.TabIndex = 31;
            this.lblErrorSinhala.Text = "*";
            this.lblErrorSinhala.Visible = false;
            // 
            // lblOp3
            // 
            this.lblOp3.AutoSize = true;
            this.lblOp3.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblOp3.Location = new System.Drawing.Point(568, 212);
            this.lblOp3.Name = "lblOp3";
            this.lblOp3.Size = new System.Drawing.Size(141, 34);
            this.lblOp3.TabIndex = 23;
            this.lblOp3.Text = "Optional 3";
            // 
            // textBoxOp2
            // 
            this.textBoxOp2.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOp2.Location = new System.Drawing.Point(769, 150);
            this.textBoxOp2.Name = "textBoxOp2";
            this.textBoxOp2.Size = new System.Drawing.Size(323, 35);
            this.textBoxOp2.TabIndex = 7;
            this.textBoxOp2.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOp2_Validating);
            // 
            // lblOp2
            // 
            this.lblOp2.AutoSize = true;
            this.lblOp2.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblOp2.Location = new System.Drawing.Point(568, 151);
            this.lblOp2.Name = "lblOp2";
            this.lblOp2.Size = new System.Drawing.Size(140, 34);
            this.lblOp2.TabIndex = 25;
            this.lblOp2.Text = "Optional 2";
            // 
            // textBoxOp1
            // 
            this.textBoxOp1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxOp1.Location = new System.Drawing.Point(769, 87);
            this.textBoxOp1.Name = "textBoxOp1";
            this.textBoxOp1.Size = new System.Drawing.Size(323, 35);
            this.textBoxOp1.TabIndex = 6;
            this.textBoxOp1.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxOp1_Validating);
            // 
            // lblOp1
            // 
            this.lblOp1.AutoSize = true;
            this.lblOp1.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblOp1.Location = new System.Drawing.Point(568, 88);
            this.lblOp1.Name = "lblOp1";
            this.lblOp1.Size = new System.Drawing.Size(135, 34);
            this.lblOp1.TabIndex = 26;
            this.lblOp1.Text = "Optional 1";
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnglish.Location = new System.Drawing.Point(769, 21);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(323, 35);
            this.textBoxEnglish.TabIndex = 5;
            this.textBoxEnglish.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxEnglish_Validating);
            // 
            // lblEnglish
            // 
            this.lblEnglish.AutoSize = true;
            this.lblEnglish.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnglish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblEnglish.Location = new System.Drawing.Point(568, 22);
            this.lblEnglish.Name = "lblEnglish";
            this.lblEnglish.Size = new System.Drawing.Size(109, 34);
            this.lblEnglish.TabIndex = 28;
            this.lblEnglish.Text = "English";
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHistory.Location = new System.Drawing.Point(179, 294);
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.Size = new System.Drawing.Size(323, 35);
            this.textBoxHistory.TabIndex = 4;
            this.textBoxHistory.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxHistory_Validating);
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblHistory.Location = new System.Drawing.Point(18, 295);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(106, 34);
            this.lblHistory.TabIndex = 29;
            this.lblHistory.Text = "History";
            // 
            // textBoxMaths
            // 
            this.textBoxMaths.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaths.Location = new System.Drawing.Point(179, 223);
            this.textBoxMaths.Name = "textBoxMaths";
            this.textBoxMaths.Size = new System.Drawing.Size(323, 35);
            this.textBoxMaths.TabIndex = 3;
            this.textBoxMaths.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxMaths_Validating);
            // 
            // lblMaths
            // 
            this.lblMaths.AutoSize = true;
            this.lblMaths.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaths.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblMaths.Location = new System.Drawing.Point(18, 224);
            this.lblMaths.Name = "lblMaths";
            this.lblMaths.Size = new System.Drawing.Size(92, 34);
            this.lblMaths.TabIndex = 30;
            this.lblMaths.Text = "Maths";
            // 
            // textBoxScience
            // 
            this.textBoxScience.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScience.Location = new System.Drawing.Point(179, 150);
            this.textBoxScience.Name = "textBoxScience";
            this.textBoxScience.Size = new System.Drawing.Size(323, 35);
            this.textBoxScience.TabIndex = 2;
            this.textBoxScience.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxScience_Validating);
            // 
            // lblScience
            // 
            this.lblScience.AutoSize = true;
            this.lblScience.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblScience.Location = new System.Drawing.Point(18, 151);
            this.lblScience.Name = "lblScience";
            this.lblScience.Size = new System.Drawing.Size(113, 34);
            this.lblScience.TabIndex = 27;
            this.lblScience.Text = "Science";
            // 
            // textBoxBuddist
            // 
            this.textBoxBuddist.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBuddist.Location = new System.Drawing.Point(178, 89);
            this.textBoxBuddist.Name = "textBoxBuddist";
            this.textBoxBuddist.Size = new System.Drawing.Size(323, 35);
            this.textBoxBuddist.TabIndex = 1;
            this.textBoxBuddist.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxBuddist_Validating);
            // 
            // lblBuddist
            // 
            this.lblBuddist.AutoSize = true;
            this.lblBuddist.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuddist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblBuddist.Location = new System.Drawing.Point(18, 87);
            this.lblBuddist.Name = "lblBuddist";
            this.lblBuddist.Size = new System.Drawing.Size(110, 34);
            this.lblBuddist.TabIndex = 24;
            this.lblBuddist.Text = "Buddist";
            // 
            // textBoxSinhala
            // 
            this.textBoxSinhala.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSinhala.Location = new System.Drawing.Point(179, 19);
            this.textBoxSinhala.Name = "textBoxSinhala";
            this.textBoxSinhala.Size = new System.Drawing.Size(323, 35);
            this.textBoxSinhala.TabIndex = 0;
            this.textBoxSinhala.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSinhala_Validating);
            // 
            // lblSinhala
            // 
            this.lblSinhala.AutoSize = true;
            this.lblSinhala.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinhala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblSinhala.Location = new System.Drawing.Point(18, 20);
            this.lblSinhala.Name = "lblSinhala";
            this.lblSinhala.Size = new System.Drawing.Size(109, 34);
            this.lblSinhala.TabIndex = 22;
            this.lblSinhala.Text = "Sinhala";
            // 
            // lblErrorOp3
            // 
            this.lblErrorOp3.AutoSize = true;
            this.lblErrorOp3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOp3.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOp3.Location = new System.Drawing.Point(1114, 448);
            this.lblErrorOp3.Name = "lblErrorOp3";
            this.lblErrorOp3.Size = new System.Drawing.Size(31, 38);
            this.lblErrorOp3.TabIndex = 43;
            this.lblErrorOp3.Text = "*";
            this.lblErrorOp3.Visible = false;
            // 
            // lblErrorOp2
            // 
            this.lblErrorOp2.AutoSize = true;
            this.lblErrorOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOp2.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOp2.Location = new System.Drawing.Point(1113, 390);
            this.lblErrorOp2.Name = "lblErrorOp2";
            this.lblErrorOp2.Size = new System.Drawing.Size(31, 38);
            this.lblErrorOp2.TabIndex = 44;
            this.lblErrorOp2.Text = "*";
            this.lblErrorOp2.Visible = false;
            // 
            // lblErrorOp1
            // 
            this.lblErrorOp1.AutoSize = true;
            this.lblErrorOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorOp1.ForeColor = System.Drawing.Color.Red;
            this.lblErrorOp1.Location = new System.Drawing.Point(1110, 323);
            this.lblErrorOp1.Name = "lblErrorOp1";
            this.lblErrorOp1.Size = new System.Drawing.Size(31, 38);
            this.lblErrorOp1.TabIndex = 45;
            this.lblErrorOp1.Text = "*";
            this.lblErrorOp1.Visible = false;
            // 
            // lblErrorEnglish
            // 
            this.lblErrorEnglish.AutoSize = true;
            this.lblErrorEnglish.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorEnglish.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEnglish.Location = new System.Drawing.Point(1110, 260);
            this.lblErrorEnglish.Name = "lblErrorEnglish";
            this.lblErrorEnglish.Size = new System.Drawing.Size(31, 38);
            this.lblErrorEnglish.TabIndex = 46;
            this.lblErrorEnglish.Text = "*";
            this.lblErrorEnglish.Visible = false;
            // 
            // FormAddMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1197, 627);
            this.Controls.Add(this.lblErrorOp3);
            this.Controls.Add(this.panelSubjects);
            this.Controls.Add(this.lblErrorOp2);
            this.Controls.Add(this.txtBoxStdId);
            this.Controls.Add(this.lblErrorOp1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblErrorEnglish);
            this.Controls.Add(this.lblStdNo);
            this.Controls.Add(this.dataGridViewMarkDetails);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.lblGrade);
            this.Name = "FormAddMarks";
            this.Text = "FormAddMarks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarkDetails)).EndInit();
            this.panelSubjects.ResumeLayout(false);
            this.panelSubjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.DataGridView dataGridViewMarkDetails;
        private System.Windows.Forms.TextBox txtBoxStdId;
        private System.Windows.Forms.Label lblStdNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panelSubjects;
        private System.Windows.Forms.TextBox textBoxOp3;
        private System.Windows.Forms.Label lblOp3;
        private System.Windows.Forms.TextBox textBoxOp2;
        private System.Windows.Forms.Label lblOp2;
        private System.Windows.Forms.TextBox textBoxOp1;
        private System.Windows.Forms.Label lblOp1;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.Label lblEnglish;
        private System.Windows.Forms.TextBox textBoxHistory;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.TextBox textBoxMaths;
        private System.Windows.Forms.Label lblMaths;
        private System.Windows.Forms.TextBox textBoxScience;
        private System.Windows.Forms.Label lblScience;
        private System.Windows.Forms.TextBox textBoxBuddist;
        private System.Windows.Forms.Label lblBuddist;
        private System.Windows.Forms.TextBox textBoxSinhala;
        private System.Windows.Forms.Label lblSinhala;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblErrorMaths;
        private System.Windows.Forms.Label lblErrorHistory;
        private System.Windows.Forms.Label lblErrorScience;
        private System.Windows.Forms.Label lblErrorBuddist;
        private System.Windows.Forms.Label lblErrorSinhala;
        private System.Windows.Forms.Label lblErrorOp3;
        private System.Windows.Forms.Label lblErrorOp2;
        private System.Windows.Forms.Label lblErrorOp1;
        private System.Windows.Forms.Label lblErrorEnglish;
    }
}