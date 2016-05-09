namespace LearnMath
{
    partial class ShowProgres
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
            this.Report = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.IdSerch = new System.Windows.Forms.Label();
            this.ShowReport = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.StartDateTxt = new System.Windows.Forms.DateTimePicker();
            this.IdSerchTxt = new System.Windows.Forms.TextBox();
            this.EndDateTxt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(276, 33);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(335, 54);
            this.Report.TabIndex = 0;
            this.Report.Text = "הצגת דוח תלמיד";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(739, 212);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(77, 25);
            this.StartDate.TabIndex = 1;
            this.StartDate.Text = ":מתאריך";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(739, 243);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(92, 25);
            this.EndDate.TabIndex = 3;
            this.EndDate.Text = ":עד תאריך";
            // 
            // IdSerch
            // 
            this.IdSerch.AutoSize = true;
            this.IdSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSerch.Location = new System.Drawing.Point(739, 175);
            this.IdSerch.Name = "IdSerch";
            this.IdSerch.Size = new System.Drawing.Size(116, 25);
            this.IdSerch.TabIndex = 5;
            this.IdSerch.Text = ":הצגה לפי ת.ז";
            // 
            // ShowReport
            // 
            this.ShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReport.Location = new System.Drawing.Point(244, 241);
            this.ShowReport.Name = "ShowReport";
            this.ShowReport.Size = new System.Drawing.Size(95, 38);
            this.ShowReport.TabIndex = 7;
            this.ShowReport.Text = "הצג דוח";
            this.ShowReport.UseVisualStyleBackColor = true;
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(12, 462);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 30);
            this.Exit.TabIndex = 8;
            this.Exit.Text = "יציאה";
            this.Exit.UseVisualStyleBackColor = true;
            // 
            // StartDateTxt
            // 
            this.StartDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTxt.Location = new System.Drawing.Point(522, 207);
            this.StartDateTxt.Name = "StartDateTxt";
            this.StartDateTxt.Size = new System.Drawing.Size(200, 30);
            this.StartDateTxt.TabIndex = 9;
            // 
            // IdSerchTxt
            // 
            this.IdSerchTxt.Location = new System.Drawing.Point(622, 179);
            this.IdSerchTxt.Name = "IdSerchTxt";
            this.IdSerchTxt.Size = new System.Drawing.Size(100, 22);
            this.IdSerchTxt.TabIndex = 6;
            // 
            // EndDateTxt
            // 
            this.EndDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTxt.Location = new System.Drawing.Point(522, 243);
            this.EndDateTxt.Name = "EndDateTxt";
            this.EndDateTxt.Size = new System.Drawing.Size(200, 30);
            this.EndDateTxt.TabIndex = 10;
            // 
            // ShowProgres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 504);
            this.Controls.Add(this.EndDateTxt);
            this.Controls.Add(this.StartDateTxt);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ShowReport);
            this.Controls.Add(this.IdSerchTxt);
            this.Controls.Add(this.IdSerch);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Report);
            this.Name = "ShowProgres";
            this.Text = "ShowProgres";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label StartDate;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Label IdSerch;
        private System.Windows.Forms.Button ShowReport;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.DateTimePicker StartDateTxt;
        private System.Windows.Forms.TextBox IdSerchTxt;
        private System.Windows.Forms.DateTimePicker EndDateTxt;
    }
}