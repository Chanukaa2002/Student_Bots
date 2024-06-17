namespace Student_Bots
{
    partial class FormStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudents));
            this.lblPUserName = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.dataGridViewSpecificStudent = new System.Windows.Forms.DataGridView();
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblMarks = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecificStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPUserName
            // 
            this.lblPUserName.AutoSize = true;
            this.lblPUserName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblPUserName.Location = new System.Drawing.Point(109, 55);
            this.lblPUserName.Name = "lblPUserName";
            this.lblPUserName.Size = new System.Drawing.Size(90, 34);
            this.lblPUserName.TabIndex = 2;
            this.lblPUserName.Text = "Grade";
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
            this.comboBoxGrade.Location = new System.Drawing.Point(218, 56);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(323, 36);
            this.comboBoxGrade.TabIndex = 5;
            this.comboBoxGrade.Text = "-Select-";
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGender_SelectedIndexChanged);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(12, 178);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(554, 381);
            this.dataGridViewStudents.TabIndex = 6;
            this.dataGridViewStudents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellClick);
            // 
            // dataGridViewSpecificStudent
            // 
            this.dataGridViewSpecificStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSpecificStudent.Location = new System.Drawing.Point(579, 178);
            this.dataGridViewSpecificStudent.Name = "dataGridViewSpecificStudent";
            this.dataGridViewSpecificStudent.RowHeadersWidth = 51;
            this.dataGridViewSpecificStudent.RowTemplate.Height = 24;
            this.dataGridViewSpecificStudent.Size = new System.Drawing.Size(554, 148);
            this.dataGridViewSpecificStudent.TabIndex = 6;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStudent.Location = new System.Drawing.Point(244, 131);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(127, 34);
            this.lblStudent.TabIndex = 7;
            this.lblStudent.Text = "Students";
            // 
            // lblMarks
            // 
            this.lblMarks.AutoSize = true;
            this.lblMarks.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblMarks.Location = new System.Drawing.Point(823, 131);
            this.lblMarks.Name = "lblMarks";
            this.lblMarks.Size = new System.Drawing.Size(94, 34);
            this.lblMarks.TabIndex = 8;
            this.lblMarks.Text = "Marks";
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1197, 627);
            this.Controls.Add(this.lblMarks);
            this.Controls.Add(this.lblStudent);
            this.Controls.Add(this.dataGridViewSpecificStudent);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.comboBoxGrade);
            this.Controls.Add(this.lblPUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSpecificStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPUserName;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewSpecificStudent;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblMarks;
    }
}