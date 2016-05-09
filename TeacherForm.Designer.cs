namespace LearnMath
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.StudentEdit = new System.Windows.Forms.Button();
            this.StudentDetails = new System.Windows.Forms.Button();
            this.ExitTeacherForm = new System.Windows.Forms.Button();
            this.MouseSize = new System.Windows.Forms.Label();
            this.BackCollor = new System.Windows.Forms.Label();
            this.MultiCollor = new System.Windows.Forms.RadioButton();
            this.blackBackground = new System.Windows.Forms.RadioButton();
            this.GameLevel = new System.Windows.Forms.Label();
            this.EseyLevel = new System.Windows.Forms.RadioButton();
            this.HardLevel = new System.Windows.Forms.RadioButton();
            this.CustomLevel = new System.Windows.Forms.RadioButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.BigMouse = new System.Windows.Forms.RadioButton();
            this.SmallMouse = new System.Windows.Forms.RadioButton();
            this.MousePanel = new System.Windows.Forms.Panel();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.LevelPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.MousePanel.SuspendLayout();
            this.ColorPanel.SuspendLayout();
            this.LevelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentEdit
            // 
            this.StudentEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentEdit.AutoSize = true;
            this.StudentEdit.Font = new System.Drawing.Font("Miriam", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudentEdit.Location = new System.Drawing.Point(720, 87);
            this.StudentEdit.Name = "StudentEdit";
            this.StudentEdit.Size = new System.Drawing.Size(267, 104);
            this.StudentEdit.TabIndex = 0;
            this.StudentEdit.Text = "עריכת פרטי תלמיד";
            this.StudentEdit.UseVisualStyleBackColor = true;
            // 
            // StudentDetails
            // 
            this.StudentDetails.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudentDetails.AutoSize = true;
            this.StudentDetails.Font = new System.Drawing.Font("Miriam", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudentDetails.Location = new System.Drawing.Point(370, 87);
            this.StudentDetails.Name = "StudentDetails";
            this.StudentDetails.Size = new System.Drawing.Size(258, 104);
            this.StudentDetails.TabIndex = 1;
            this.StudentDetails.Text = "נתוני תלמיד";
            this.StudentDetails.UseVisualStyleBackColor = true;
            this.StudentDetails.Click += new System.EventHandler(this.StudentDetails_Click);
            // 
            // ExitTeacherForm
            // 
            this.ExitTeacherForm.Location = new System.Drawing.Point(38, 31);
            this.ExitTeacherForm.Name = "ExitTeacherForm";
            this.ExitTeacherForm.Size = new System.Drawing.Size(75, 23);
            this.ExitTeacherForm.TabIndex = 6;
            this.ExitTeacherForm.Text = "יציאה";
            this.ExitTeacherForm.UseVisualStyleBackColor = true;
            this.ExitTeacherForm.Click += new System.EventHandler(this.ExitTeacherForm_Click);
            // 
            // MouseSize
            // 
            this.MouseSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MouseSize.Location = new System.Drawing.Point(16, 15);
            this.MouseSize.Name = "MouseSize";
            this.MouseSize.Size = new System.Drawing.Size(197, 41);
            this.MouseSize.TabIndex = 10;
            this.MouseSize.Text = "בחר גודל סמן";
            this.MouseSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackCollor
            // 
            this.BackCollor.AutoSize = true;
            this.BackCollor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackCollor.Location = new System.Drawing.Point(29, 21);
            this.BackCollor.Name = "BackCollor";
            this.BackCollor.Size = new System.Drawing.Size(220, 29);
            this.BackCollor.TabIndex = 11;
            this.BackCollor.Text = "בחר צבע רקע משחק";
            // 
            // MultiCollor
            // 
            this.MultiCollor.AutoSize = true;
            this.MultiCollor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MultiCollor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MultiCollor.Location = new System.Drawing.Point(109, 74);
            this.MultiCollor.Name = "MultiCollor";
            this.MultiCollor.Size = new System.Drawing.Size(85, 29);
            this.MultiCollor.TabIndex = 12;
            this.MultiCollor.Text = "צבעוני";
            this.MultiCollor.UseVisualStyleBackColor = true;
            // 
            // blackBackground
            // 
            this.blackBackground.AutoSize = true;
            this.blackBackground.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blackBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.blackBackground.Location = new System.Drawing.Point(121, 126);
            this.blackBackground.Name = "blackBackground";
            this.blackBackground.Size = new System.Drawing.Size(73, 29);
            this.blackBackground.TabIndex = 13;
            this.blackBackground.Text = "שחור";
            this.blackBackground.UseVisualStyleBackColor = true;
            this.blackBackground.CheckedChanged += new System.EventHandler(this.blackBackground_CheckedChanged);
            // 
            // GameLevel
            // 
            this.GameLevel.AutoSize = true;
            this.GameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GameLevel.Location = new System.Drawing.Point(110, 21);
            this.GameLevel.Name = "GameLevel";
            this.GameLevel.Size = new System.Drawing.Size(198, 29);
            this.GameLevel.TabIndex = 14;
            this.GameLevel.Text = "בחירת רמת משחק";
            // 
            // EseyLevel
            // 
            this.EseyLevel.AutoSize = true;
            this.EseyLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EseyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EseyLevel.Location = new System.Drawing.Point(161, 71);
            this.EseyLevel.Name = "EseyLevel";
            this.EseyLevel.Size = new System.Drawing.Size(147, 29);
            this.EseyLevel.TabIndex = 15;
            this.EseyLevel.TabStop = true;
            this.EseyLevel.Text = "רמה קלה- עד 5";
            this.EseyLevel.UseVisualStyleBackColor = true;
            // 
            // HardLevel
            // 
            this.HardLevel.AutoSize = true;
            this.HardLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.HardLevel.Location = new System.Drawing.Point(152, 106);
            this.HardLevel.Name = "HardLevel";
            this.HardLevel.Size = new System.Drawing.Size(156, 29);
            this.HardLevel.TabIndex = 16;
            this.HardLevel.TabStop = true;
            this.HardLevel.Text = "רמה קשה-עד 10";
            this.HardLevel.UseVisualStyleBackColor = true;
            // 
            // CustomLevel
            // 
            this.CustomLevel.AutoSize = true;
            this.CustomLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CustomLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.CustomLevel.Location = new System.Drawing.Point(136, 141);
            this.CustomLevel.Name = "CustomLevel";
            this.CustomLevel.Size = new System.Drawing.Size(172, 29);
            this.CustomLevel.TabIndex = 17;
            this.CustomLevel.TabStop = true;
            this.CustomLevel.Text = "התאמה אישית- עד";
            this.CustomLevel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(41, 145);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 22);
            this.numericUpDown1.TabIndex = 18;
            // 
            // BigMouse
            // 
            this.BigMouse.AutoSize = true;
            this.BigMouse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BigMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BigMouse.Location = new System.Drawing.Point(118, 126);
            this.BigMouse.Name = "BigMouse";
            this.BigMouse.Size = new System.Drawing.Size(67, 29);
            this.BigMouse.TabIndex = 9;
            this.BigMouse.TabStop = true;
            this.BigMouse.Text = "גדול";
            this.BigMouse.UseVisualStyleBackColor = true;
            // 
            // SmallMouse
            // 
            this.SmallMouse.AutoSize = true;
            this.SmallMouse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SmallMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SmallMouse.Location = new System.Drawing.Point(123, 74);
            this.SmallMouse.Name = "SmallMouse";
            this.SmallMouse.Size = new System.Drawing.Size(62, 29);
            this.SmallMouse.TabIndex = 8;
            this.SmallMouse.TabStop = true;
            this.SmallMouse.Text = "קטן";
            this.SmallMouse.UseVisualStyleBackColor = true;
            // 
            // MousePanel
            // 
            this.MousePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MousePanel.Controls.Add(this.BigMouse);
            this.MousePanel.Controls.Add(this.SmallMouse);
            this.MousePanel.Controls.Add(this.MouseSize);
            this.MousePanel.Location = new System.Drawing.Point(881, 274);
            this.MousePanel.Name = "MousePanel";
            this.MousePanel.Size = new System.Drawing.Size(216, 187);
            this.MousePanel.TabIndex = 19;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorPanel.Controls.Add(this.blackBackground);
            this.ColorPanel.Controls.Add(this.MultiCollor);
            this.ColorPanel.Controls.Add(this.BackCollor);
            this.ColorPanel.Location = new System.Drawing.Point(556, 274);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(283, 187);
            this.ColorPanel.TabIndex = 20;
            this.ColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorPanel_Paint);
            // 
            // LevelPanel
            // 
            this.LevelPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LevelPanel.AutoSize = true;
            this.LevelPanel.Controls.Add(this.CustomLevel);
            this.LevelPanel.Controls.Add(this.numericUpDown1);
            this.LevelPanel.Controls.Add(this.HardLevel);
            this.LevelPanel.Controls.Add(this.GameLevel);
            this.LevelPanel.Controls.Add(this.EseyLevel);
            this.LevelPanel.Location = new System.Drawing.Point(168, 274);
            this.LevelPanel.Name = "LevelPanel";
            this.LevelPanel.Size = new System.Drawing.Size(338, 187);
            this.LevelPanel.TabIndex = 21;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1225, 516);
            this.Controls.Add(this.LevelPanel);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.MousePanel);
            this.Controls.Add(this.ExitTeacherForm);
            this.Controls.Add(this.StudentDetails);
            this.Controls.Add(this.StudentEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.MousePanel.ResumeLayout(false);
            this.MousePanel.PerformLayout();
            this.ColorPanel.ResumeLayout(false);
            this.ColorPanel.PerformLayout();
            this.LevelPanel.ResumeLayout(false);
            this.LevelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StudentEdit;
        private System.Windows.Forms.Button StudentDetails;
        private System.Windows.Forms.Button ExitTeacherForm;
        private System.Windows.Forms.Label MouseSize;
        private System.Windows.Forms.Label BackCollor;
        private System.Windows.Forms.RadioButton MultiCollor;
        private System.Windows.Forms.RadioButton blackBackground;
        private System.Windows.Forms.Label GameLevel;
        private System.Windows.Forms.RadioButton EseyLevel;
        private System.Windows.Forms.RadioButton HardLevel;
        private System.Windows.Forms.RadioButton CustomLevel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RadioButton BigMouse;
        private System.Windows.Forms.RadioButton SmallMouse;
        private System.Windows.Forms.Panel MousePanel;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Panel LevelPanel;
    }
}