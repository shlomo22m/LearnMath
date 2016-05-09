namespace LearnMath
{
    partial class StartPage
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
            this.EntranceTitle = new System.Windows.Forms.Label();
            this.StudentEntrance = new System.Windows.Forms.Button();
            this.TeacherEntrance = new System.Windows.Forms.Button();
            this.ExitMAinPage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MannagerEntrance = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntranceTitle
            // 
            this.EntranceTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EntranceTitle.AutoSize = true;
            this.EntranceTitle.Font = new System.Drawing.Font("Aharoni", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EntranceTitle.ForeColor = System.Drawing.Color.Crimson;
            this.EntranceTitle.Location = new System.Drawing.Point(254, 27);
            this.EntranceTitle.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.EntranceTitle.Name = "EntranceTitle";
            this.EntranceTitle.Size = new System.Drawing.Size(598, 79);
            this.EntranceTitle.TabIndex = 0;
            this.EntranceTitle.Text = "לומדים חשבון ונהנים";
            this.EntranceTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StudentEntrance
            // 
            this.StudentEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StudentEntrance.AutoSize = true;
            this.StudentEntrance.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentEntrance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.StudentEntrance.Location = new System.Drawing.Point(758, 283);
            this.StudentEntrance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StudentEntrance.Name = "StudentEntrance";
            this.StudentEntrance.Size = new System.Drawing.Size(252, 119);
            this.StudentEntrance.TabIndex = 1;
            this.StudentEntrance.Text = "כניסת תלמיד";
            this.StudentEntrance.UseVisualStyleBackColor = true;
            this.StudentEntrance.Click += new System.EventHandler(this.StudentEntrance_Click);
            // 
            // TeacherEntrance
            // 
            this.TeacherEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TeacherEntrance.AutoSize = true;
            this.TeacherEntrance.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold);
            this.TeacherEntrance.ForeColor = System.Drawing.Color.Coral;
            this.TeacherEntrance.Location = new System.Drawing.Point(91, 283);
            this.TeacherEntrance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TeacherEntrance.Name = "TeacherEntrance";
            this.TeacherEntrance.Size = new System.Drawing.Size(249, 119);
            this.TeacherEntrance.TabIndex = 2;
            this.TeacherEntrance.Text = "כניסת מורה";
            this.TeacherEntrance.UseVisualStyleBackColor = true;
            this.TeacherEntrance.Click += new System.EventHandler(this.TeacherEntrance_Click);
            // 
            // ExitMAinPage
            // 
            this.ExitMAinPage.BackColor = System.Drawing.Color.Red;
            this.ExitMAinPage.Location = new System.Drawing.Point(34, 483);
            this.ExitMAinPage.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ExitMAinPage.Name = "ExitMAinPage";
            this.ExitMAinPage.Size = new System.Drawing.Size(99, 50);
            this.ExitMAinPage.TabIndex = 3;
            this.ExitMAinPage.Text = "יציאה";
            this.ExitMAinPage.UseVisualStyleBackColor = false;
            this.ExitMAinPage.Click += new System.EventHandler(this.ExitMAinPage_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(734, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = ":שם משתמש";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // UserName
            // 
            this.UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UserName.Location = new System.Drawing.Point(560, 167);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(154, 34);
            this.UserName.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(240, 167);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(177, 34);
            this.Password.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = ":סיסמא";
            // 
            // MannagerEntrance
            // 
            this.MannagerEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MannagerEntrance.AutoSize = true;
            this.MannagerEntrance.Font = new System.Drawing.Font("Arial Narrow", 25.8F, System.Drawing.FontStyle.Bold);
            this.MannagerEntrance.ForeColor = System.Drawing.Color.Red;
            this.MannagerEntrance.Location = new System.Drawing.Point(416, 283);
            this.MannagerEntrance.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MannagerEntrance.Name = "MannagerEntrance";
            this.MannagerEntrance.Size = new System.Drawing.Size(262, 119);
            this.MannagerEntrance.TabIndex = 8;
            this.MannagerEntrance.Text = "כניסת מנהל";
            this.MannagerEntrance.UseVisualStyleBackColor = true;
            this.MannagerEntrance.Click += new System.EventHandler(this.MannagerEntrance_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1039, 664);
            this.Controls.Add(this.MannagerEntrance);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitMAinPage);
            this.Controls.Add(this.TeacherEntrance);
            this.Controls.Add(this.StudentEntrance);
            this.Controls.Add(this.EntranceTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "StartPage";
            this.Text = "StartPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EntranceTitle;
        private System.Windows.Forms.Button StudentEntrance;
        private System.Windows.Forms.Button TeacherEntrance;
        private System.Windows.Forms.Button ExitMAinPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MannagerEntrance;
    }
}

