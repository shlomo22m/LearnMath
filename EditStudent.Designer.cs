namespace LearnMath
{
    partial class EditStudent
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
            this.EditAStudentLabel = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.DeleteStudentBtn = new System.Windows.Forms.Button();
            this.UpdateStudentDetails = new System.Windows.Forms.Button();
            this.ExitUpdate = new System.Windows.Forms.Button();
            this.EditTeacher = new System.Windows.Forms.Button();
            this.DeleteTeacher = new System.Windows.Forms.Button();
            this.AddTecher = new System.Windows.Forms.Button();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditAStudentLabel
            // 
            this.EditAStudentLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditAStudentLabel.AutoSize = true;
            this.EditAStudentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EditAStudentLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.EditAStudentLabel.Location = new System.Drawing.Point(397, 51);
            this.EditAStudentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EditAStudentLabel.Name = "EditAStudentLabel";
            this.EditAStudentLabel.Size = new System.Drawing.Size(293, 55);
            this.EditAStudentLabel.TabIndex = 0;
            this.EditAStudentLabel.Text = "עריכת פרטים";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddStudentBtn.Location = new System.Drawing.Point(534, 41);
            this.AddStudentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(225, 122);
            this.AddStudentBtn.TabIndex = 1;
            this.AddStudentBtn.Text = "הוספת\\הסרת תלמיד";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // DeleteStudentBtn
            // 
            this.DeleteStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteStudentBtn.Location = new System.Drawing.Point(296, 41);
            this.DeleteStudentBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteStudentBtn.Name = "DeleteStudentBtn";
            this.DeleteStudentBtn.Size = new System.Drawing.Size(225, 122);
            this.DeleteStudentBtn.TabIndex = 2;
            this.DeleteStudentBtn.Text = "הצגת נתוני תלמיד";
            this.DeleteStudentBtn.UseVisualStyleBackColor = true;
            this.DeleteStudentBtn.Click += new System.EventHandler(this.DeleteStudentBtn_Click);
            // 
            // UpdateStudentDetails
            // 
            this.UpdateStudentDetails.Location = new System.Drawing.Point(51, 41);
            this.UpdateStudentDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateStudentDetails.Name = "UpdateStudentDetails";
            this.UpdateStudentDetails.Size = new System.Drawing.Size(225, 122);
            this.UpdateStudentDetails.TabIndex = 3;
            this.UpdateStudentDetails.Text = "עדכון פרטי תלמיד";
            this.UpdateStudentDetails.UseVisualStyleBackColor = true;
            // 
            // ExitUpdate
            // 
            this.ExitUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitUpdate.Location = new System.Drawing.Point(28, 51);
            this.ExitUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitUpdate.Name = "ExitUpdate";
            this.ExitUpdate.Size = new System.Drawing.Size(69, 41);
            this.ExitUpdate.TabIndex = 4;
            this.ExitUpdate.Text = "חזור";
            this.ExitUpdate.UseVisualStyleBackColor = true;
            this.ExitUpdate.Click += new System.EventHandler(this.ExitUpdate_Click);
            // 
            // EditTeacher
            // 
            this.EditTeacher.Location = new System.Drawing.Point(51, 210);
            this.EditTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditTeacher.Name = "EditTeacher";
            this.EditTeacher.Size = new System.Drawing.Size(225, 122);
            this.EditTeacher.TabIndex = 7;
            this.EditTeacher.Text = "עדכון פרטי מורה";
            this.EditTeacher.UseVisualStyleBackColor = true;
            // 
            // DeleteTeacher
            // 
            this.DeleteTeacher.Location = new System.Drawing.Point(296, 210);
            this.DeleteTeacher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteTeacher.Name = "DeleteTeacher";
            this.DeleteTeacher.Size = new System.Drawing.Size(225, 122);
            this.DeleteTeacher.TabIndex = 6;
            this.DeleteTeacher.Text = "מחיקת מורה";
            this.DeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // AddTecher
            // 
            this.AddTecher.Location = new System.Drawing.Point(534, 210);
            this.AddTecher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddTecher.Name = "AddTecher";
            this.AddTecher.Size = new System.Drawing.Size(225, 122);
            this.AddTecher.TabIndex = 5;
            this.AddTecher.Text = "הוספת מורה";
            this.AddTecher.UseVisualStyleBackColor = true;
            this.AddTecher.Click += new System.EventHandler(this.AddTecher_Click);
            // 
            // EditPanel
            // 
            this.EditPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditPanel.AutoSize = true;
            this.EditPanel.Controls.Add(this.AddStudentBtn);
            this.EditPanel.Controls.Add(this.EditTeacher);
            this.EditPanel.Controls.Add(this.DeleteStudentBtn);
            this.EditPanel.Controls.Add(this.DeleteTeacher);
            this.EditPanel.Controls.Add(this.UpdateStudentDetails);
            this.EditPanel.Controls.Add(this.AddTecher);
            this.EditPanel.Location = new System.Drawing.Point(76, 103);
            this.EditPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(824, 404);
            this.EditPanel.TabIndex = 8;
            // 
            // EditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1006, 540);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.ExitUpdate);
            this.Controls.Add(this.EditAStudentLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditStudent";
            this.Text = "EditStudent";
            this.EditPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EditAStudentLabel;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button DeleteStudentBtn;
        private System.Windows.Forms.Button UpdateStudentDetails;
        private System.Windows.Forms.Button ExitUpdate;
        private System.Windows.Forms.Button EditTeacher;
        private System.Windows.Forms.Button DeleteTeacher;
        private System.Windows.Forms.Button AddTecher;
        private System.Windows.Forms.Panel EditPanel;
    }
}