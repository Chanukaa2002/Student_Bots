namespace Student_Bots
{
    partial class FormLetter
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblCoActivity = new System.Windows.Forms.Label();
            this.txtBoxCoActivity = new System.Windows.Forms.TextBox();
            this.dataGridViewStdDetail = new System.Windows.Forms.DataGridView();
            this.btnGenarate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblErrorActivity = new System.Windows.Forms.Label();
            this.comboBoxIndex = new System.Windows.Forms.ComboBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStudentName.Location = new System.Drawing.Point(260, 150);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(194, 34);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Student Index:";
            // 
            // lblCoActivity
            // 
            this.lblCoActivity.AutoSize = true;
            this.lblCoActivity.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoActivity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblCoActivity.Location = new System.Drawing.Point(156, 282);
            this.lblCoActivity.Name = "lblCoActivity";
            this.lblCoActivity.Size = new System.Drawing.Size(286, 34);
            this.lblCoActivity.TabIndex = 1;
            this.lblCoActivity.Text = "Student Co-Activities:";
            // 
            // txtBoxCoActivity
            // 
            this.txtBoxCoActivity.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCoActivity.Location = new System.Drawing.Point(489, 259);
            this.txtBoxCoActivity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxCoActivity.Multiline = true;
            this.txtBoxCoActivity.Name = "txtBoxCoActivity";
            this.txtBoxCoActivity.Size = new System.Drawing.Size(625, 109);
            this.txtBoxCoActivity.TabIndex = 1;
            this.txtBoxCoActivity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCoActivity_Validating);
            // 
            // dataGridViewStdDetail
            // 
            this.dataGridViewStdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStdDetail.Location = new System.Drawing.Point(60, 438);
            this.dataGridViewStdDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewStdDetail.Name = "dataGridViewStdDetail";
            this.dataGridViewStdDetail.RowHeadersWidth = 51;
            this.dataGridViewStdDetail.RowTemplate.Height = 24;
            this.dataGridViewStdDetail.Size = new System.Drawing.Size(1227, 129);
            this.dataGridViewStdDetail.TabIndex = 3;
            // 
            // btnGenarate
            // 
            this.btnGenarate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnGenarate.FlatAppearance.BorderSize = 0;
            this.btnGenarate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenarate.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenarate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenarate.Location = new System.Drawing.Point(254, 655);
            this.btnGenarate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGenarate.Name = "btnGenarate";
            this.btnGenarate.Size = new System.Drawing.Size(322, 81);
            this.btnGenarate.TabIndex = 2;
            this.btnGenarate.Text = "Genarate";
            this.btnGenarate.UseVisualStyleBackColor = false;
            this.btnGenarate.Click += new System.EventHandler(this.btnGenarate_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(775, 655);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(322, 81);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblErrorActivity
            // 
            this.lblErrorActivity.AutoSize = true;
            this.lblErrorActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorActivity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorActivity.Location = new System.Drawing.Point(1122, 282);
            this.lblErrorActivity.Name = "lblErrorActivity";
            this.lblErrorActivity.Size = new System.Drawing.Size(31, 38);
            this.lblErrorActivity.TabIndex = 8;
            this.lblErrorActivity.Text = "*";
            this.lblErrorActivity.Visible = false;
            // 
            // comboBoxIndex
            // 
            this.comboBoxIndex.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxIndex.FormattingEnabled = true;
            this.comboBoxIndex.Items.AddRange(new object[] {
            "-Select-"});
            this.comboBoxIndex.Location = new System.Drawing.Point(485, 150);
            this.comboBoxIndex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxIndex.Name = "comboBoxIndex";
            this.comboBoxIndex.Size = new System.Drawing.Size(630, 36);
            this.comboBoxIndex.TabIndex = 9;
            this.comboBoxIndex.Text = "-Select-";
            this.comboBoxIndex.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndex_SelectedIndexChanged);
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblGrade.Location = new System.Drawing.Point(347, 65);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(95, 34);
            this.lblGrade.TabIndex = 10;
            this.lblGrade.Text = "Grade:";
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
            this.comboBoxGrade.Location = new System.Drawing.Point(487, 65);
            this.comboBoxGrade.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(628, 36);
            this.comboBoxGrade.TabIndex = 11;
            this.comboBoxGrade.Text = "-Select-";
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // FormLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1347, 784);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.lblGrade);
            this.Controls.Add(this.comboBoxIndex);
            this.Controls.Add(this.lblErrorActivity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenarate);
            this.Controls.Add(this.dataGridViewStdDetail);
            this.Controls.Add(this.txtBoxCoActivity);
            this.Controls.Add(this.lblCoActivity);
            this.Controls.Add(this.lblStudentName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLetter";
            this.Text = "FormLetter";
            this.Load += new System.EventHandler(this.FormLetter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblCoActivity;
        private System.Windows.Forms.TextBox txtBoxCoActivity;
        private System.Windows.Forms.DataGridView dataGridViewStdDetail;
        private System.Windows.Forms.Button btnGenarate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErrorActivity;
        private System.Windows.Forms.ComboBox comboBoxIndex;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.ComboBox comboBoxGrade;
    }
}