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
            this.IdSerch = new System.Windows.Forms.Label();
            this.ShowReport = new System.Windows.Forms.Button();
            this.IdSerchTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Report
            // 
            this.Report.AutoSize = true;
            this.Report.Font = new System.Drawing.Font("Arial Narrow", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Report.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Report.Location = new System.Drawing.Point(271, 9);
            this.Report.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(94, 43);
            this.Report.TabIndex = 0;
            this.Report.Text = "דוחות";
            // 
            // IdSerch
            // 
            this.IdSerch.AutoSize = true;
            this.IdSerch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdSerch.Location = new System.Drawing.Point(563, 119);
            this.IdSerch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdSerch.Name = "IdSerch";
            this.IdSerch.Size = new System.Drawing.Size(65, 20);
            this.IdSerch.TabIndex = 5;
            this.IdSerch.Text = "הכנס ת.ז";
            // 
            // ShowReport
            // 
            this.ShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowReport.Location = new System.Drawing.Point(420, 207);
            this.ShowReport.Margin = new System.Windows.Forms.Padding(2);
            this.ShowReport.Name = "ShowReport";
            this.ShowReport.Size = new System.Drawing.Size(71, 31);
            this.ShowReport.TabIndex = 7;
            this.ShowReport.Text = "הצג דוח";
            this.ShowReport.UseVisualStyleBackColor = true;
            this.ShowReport.Click += new System.EventHandler(this.ShowReport_Click);
            // 
            // IdSerchTxt
            // 
            this.IdSerchTxt.Location = new System.Drawing.Point(420, 119);
            this.IdSerchTxt.Margin = new System.Windows.Forms.Padding(2);
            this.IdSerchTxt.Name = "IdSerchTxt";
            this.IdSerchTxt.Size = new System.Drawing.Size(121, 20);
            this.IdSerchTxt.TabIndex = 6;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(547, 159);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "בחר משחק";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 41;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(62, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 31);
            this.button2.TabIndex = 42;
            this.button2.Text = "הצג דוח";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(461, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 31);
            this.label2.TabIndex = 43;
            this.label2.Text = "הצגת דוח תלמיד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(56, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 31);
            this.label3.TabIndex = 44;
            this.label3.Text = "הצגת דוח כל התלמידים";
            // 
            // ShowProgres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(657, 410);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowReport);
            this.Controls.Add(this.IdSerchTxt);
            this.Controls.Add(this.IdSerch);
            this.Controls.Add(this.Report);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ShowProgres";
            this.Text = "ShowProgres";
            this.Load += new System.EventHandler(this.ShowProgres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Report;
        private System.Windows.Forms.Label IdSerch;
        private System.Windows.Forms.Button ShowReport;
        private System.Windows.Forms.TextBox IdSerchTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}