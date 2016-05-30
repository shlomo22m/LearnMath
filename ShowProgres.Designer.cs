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
            this.StartDateTxt = new System.Windows.Forms.DateTimePicker();
            this.IdSerchTxt = new System.Windows.Forms.TextBox();
            this.EndDateTxt = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.Location = new System.Drawing.Point(207, 27);
            this.Report.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(276, 44);
            this.Report.TabIndex = 0;
            this.Report.Text = "הצגת דוח תלמיד";
            // 
            // StartDate
            // 
            this.StartDate.AutoSize = true;
            this.StartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate.Location = new System.Drawing.Point(554, 172);
            this.StartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(66, 20);
            this.StartDate.TabIndex = 1;
            this.StartDate.Text = ":מתאריך";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate.Location = new System.Drawing.Point(554, 197);
            this.EndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(79, 20);
            this.EndDate.TabIndex = 3;
            this.EndDate.Text = ":עד תאריך";
            // 
            // IdSerch
            // 
            this.IdSerch.AutoSize = true;
            this.IdSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSerch.Location = new System.Drawing.Point(554, 142);
            this.IdSerch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdSerch.Name = "IdSerch";
            this.IdSerch.Size = new System.Drawing.Size(97, 20);
            this.IdSerch.TabIndex = 5;
            this.IdSerch.Text = ":הצגה לפי ת.ז";
            // 
            // ShowReport
            // 
            this.ShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReport.Location = new System.Drawing.Point(183, 196);
            this.ShowReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowReport.Name = "ShowReport";
            this.ShowReport.Size = new System.Drawing.Size(71, 31);
            this.ShowReport.TabIndex = 7;
            this.ShowReport.Text = "הצג דוח";
            this.ShowReport.UseVisualStyleBackColor = true;
            // 
            // StartDateTxt
            // 
            this.StartDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateTxt.Location = new System.Drawing.Point(392, 168);
            this.StartDateTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartDateTxt.Name = "StartDateTxt";
            this.StartDateTxt.Size = new System.Drawing.Size(151, 26);
            this.StartDateTxt.TabIndex = 9;
            // 
            // IdSerchTxt
            // 
            this.IdSerchTxt.Location = new System.Drawing.Point(466, 145);
            this.IdSerchTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdSerchTxt.Name = "IdSerchTxt";
            this.IdSerchTxt.Size = new System.Drawing.Size(76, 20);
            this.IdSerchTxt.TabIndex = 6;
            // 
            // EndDateTxt
            // 
            this.EndDateTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateTxt.Location = new System.Drawing.Point(392, 197);
            this.EndDateTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndDateTxt.Name = "EndDateTxt";
            this.EndDateTxt.Size = new System.Drawing.Size(151, 26);
            this.EndDateTxt.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "חזרה";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowProgres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 410);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EndDateTxt);
            this.Controls.Add(this.StartDateTxt);
            this.Controls.Add(this.ShowReport);
            this.Controls.Add(this.IdSerchTxt);
            this.Controls.Add(this.IdSerch);
            this.Controls.Add(this.EndDate);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.Report);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DateTimePicker StartDateTxt;
        private System.Windows.Forms.TextBox IdSerchTxt;
        private System.Windows.Forms.DateTimePicker EndDateTxt;
        private System.Windows.Forms.Button button1;
    }
}