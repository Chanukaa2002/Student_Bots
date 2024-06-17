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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblErrorActivity = new System.Windows.Forms.Label();
            this.comboBoxIndex = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStdDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStudentName.Location = new System.Drawing.Point(231, 120);
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
            this.lblCoActivity.Location = new System.Drawing.Point(139, 226);
            this.lblCoActivity.Name = "lblCoActivity";
            this.lblCoActivity.Size = new System.Drawing.Size(286, 34);
            this.lblCoActivity.TabIndex = 1;
            this.lblCoActivity.Text = "Student Co-Activities:";
            // 
            // txtBoxCoActivity
            // 
            this.txtBoxCoActivity.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCoActivity.Location = new System.Drawing.Point(435, 207);
            this.txtBoxCoActivity.Multiline = true;
            this.txtBoxCoActivity.Name = "txtBoxCoActivity";
            this.txtBoxCoActivity.Size = new System.Drawing.Size(556, 88);
            this.txtBoxCoActivity.TabIndex = 1;
            this.txtBoxCoActivity.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxCoActivity_Validating);
            // 
            // dataGridViewStdDetail
            // 
            this.dataGridViewStdDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStdDetail.Location = new System.Drawing.Point(53, 350);
            this.dataGridViewStdDetail.Name = "dataGridViewStdDetail";
            this.dataGridViewStdDetail.RowHeadersWidth = 51;
            this.dataGridViewStdDetail.RowTemplate.Height = 24;
            this.dataGridViewStdDetail.Size = new System.Drawing.Size(1091, 103);
            this.dataGridViewStdDetail.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Location = new System.Drawing.Point(226, 524);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(286, 65);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(114)))), ((int)(((byte)(239)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Bahnschrift", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(689, 524);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(286, 65);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblErrorActivity
            // 
            this.lblErrorActivity.AutoSize = true;
            this.lblErrorActivity.Font = new System.Drawing.Font("Bauhaus 93", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorActivity.ForeColor = System.Drawing.Color.Red;
            this.lblErrorActivity.Location = new System.Drawing.Point(997, 226);
            this.lblErrorActivity.Name = "lblErrorActivity";
            this.lblErrorActivity.Size = new System.Drawing.Size(35, 38);
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
            this.comboBoxIndex.Location = new System.Drawing.Point(431, 120);
            this.comboBoxIndex.Name = "comboBoxIndex";
            this.comboBoxIndex.Size = new System.Drawing.Size(560, 36);
            this.comboBoxIndex.TabIndex = 9;
            this.comboBoxIndex.Text = "-Select-";
            this.comboBoxIndex.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndex_SelectedIndexChanged);
            // 
            // FormLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1197, 627);
            this.Controls.Add(this.comboBoxIndex);
            this.Controls.Add(this.lblErrorActivity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dataGridViewStdDetail);
            this.Controls.Add(this.txtBoxCoActivity);
            this.Controls.Add(this.lblCoActivity);
            this.Controls.Add(this.lblStudentName);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblErrorActivity;
        private System.Windows.Forms.ComboBox comboBoxIndex;
    }
}