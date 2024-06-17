namespace Student_Bots
{
    partial class FormDashBoard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartStudentGrade = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblStudentGrade = new System.Windows.Forms.Label();
            this.lblStudentGender = new System.Windows.Forms.Label();
            this.chartStudentGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartTeacherGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblTeacherGender = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentGrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentGender)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeacherGender)).BeginInit();
            this.SuspendLayout();
            // 
            // chartStudentGrade
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStudentGrade.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStudentGrade.Legends.Add(legend1);
            this.chartStudentGrade.Location = new System.Drawing.Point(32, 63);
            this.chartStudentGrade.Name = "chartStudentGrade";
            this.chartStudentGrade.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.MarkerSize = 7;
            series1.Name = "Students";
            this.chartStudentGrade.Series.Add(series1);
            this.chartStudentGrade.Size = new System.Drawing.Size(584, 541);
            this.chartStudentGrade.TabIndex = 0;
            this.chartStudentGrade.Text = "Student Grades";
            this.chartStudentGrade.Click += new System.EventHandler(this.chartStudentGrade_Click);
            // 
            // lblStudentGrade
            // 
            this.lblStudentGrade.AutoSize = true;
            this.lblStudentGrade.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStudentGrade.Location = new System.Drawing.Point(188, 9);
            this.lblStudentGrade.Name = "lblStudentGrade";
            this.lblStudentGrade.Size = new System.Drawing.Size(262, 34);
            this.lblStudentGrade.TabIndex = 9;
            this.lblStudentGrade.Text = "Student Grade wise";
            // 
            // lblStudentGender
            // 
            this.lblStudentGender.AutoSize = true;
            this.lblStudentGender.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblStudentGender.Location = new System.Drawing.Point(177, 9);
            this.lblStudentGender.Name = "lblStudentGender";
            this.lblStudentGender.Size = new System.Drawing.Size(284, 34);
            this.lblStudentGender.TabIndex = 9;
            this.lblStudentGender.Text = "Student Male/Female";
            // 
            // chartStudentGender
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStudentGender.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStudentGender.Legends.Add(legend2);
            this.chartStudentGender.Location = new System.Drawing.Point(13, 60);
            this.chartStudentGender.Name = "chartStudentGender";
            this.chartStudentGender.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 2;
            this.chartStudentGender.Series.Add(series2);
            this.chartStudentGender.Size = new System.Drawing.Size(534, 235);
            this.chartStudentGender.TabIndex = 0;
            this.chartStudentGender.Text = "chart1";
            this.chartStudentGender.Click += new System.EventHandler(this.chartStudentGender_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblStudentGrade);
            this.panel1.Controls.Add(this.chartStudentGrade);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 627);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.chartStudentGender);
            this.panel2.Controls.Add(this.lblStudentGender);
            this.panel2.Location = new System.Drawing.Point(646, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(548, 313);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.chartTeacherGender);
            this.panel3.Controls.Add(this.lblTeacherGender);
            this.panel3.Location = new System.Drawing.Point(646, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(551, 313);
            this.panel3.TabIndex = 11;
            // 
            // chartTeacherGender
            // 
            chartArea3.Name = "ChartArea1";
            this.chartTeacherGender.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartTeacherGender.Legends.Add(legend3);
            this.chartTeacherGender.Location = new System.Drawing.Point(13, 55);
            this.chartTeacherGender.Name = "chartTeacherGender";
            this.chartTeacherGender.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chartTeacherGender.Series.Add(series3);
            this.chartTeacherGender.Size = new System.Drawing.Size(534, 235);
            this.chartTeacherGender.TabIndex = 0;
            this.chartTeacherGender.Text = "chart1";
            // 
            // lblTeacherGender
            // 
            this.lblTeacherGender.AutoSize = true;
            this.lblTeacherGender.Font = new System.Drawing.Font("Bahnschrift", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacherGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(114)))), ((int)(((byte)(160)))));
            this.lblTeacherGender.Location = new System.Drawing.Point(174, 8);
            this.lblTeacherGender.Name = "lblTeacherGender";
            this.lblTeacherGender.Size = new System.Drawing.Size(285, 34);
            this.lblTeacherGender.TabIndex = 9;
            this.lblTeacherGender.Text = "Teacher Male/Female";
            // 
            // FormDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1197, 627);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormDashBoard";
            this.Text = "FormDashBoard";
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentGrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudentGender)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTeacherGender)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudentGrade;
        private System.Windows.Forms.Label lblStudentGrade;
        private System.Windows.Forms.Label lblStudentGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudentGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTeacherGender;
        private System.Windows.Forms.Label lblTeacherGender;
    }
}