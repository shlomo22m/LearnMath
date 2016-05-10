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
            this.StudentEdit = new System.Windows.Forms.Button();
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.StudentEdit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StudentEdit.Font = new System.Drawing.Font("Miriam", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.StudentEdit.Location = new System.Drawing.Point(501, 210);
            this.StudentEdit.Margin = new System.Windows.Forms.Padding(2);
            this.StudentEdit.Name = "StudentEdit";
            this.StudentEdit.Size = new System.Drawing.Size(128, 46);
            this.StudentEdit.TabIndex = 0;
            this.StudentEdit.Text = "ערוך פרטים";
            this.StudentEdit.UseVisualStyleBackColor = false;
            // 
            // ExitTeacherForm
            // 
            this.ExitTeacherForm.BackColor = System.Drawing.Color.DeepPink;
            this.ExitTeacherForm.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitTeacherForm.Location = new System.Drawing.Point(11, 569);
            this.ExitTeacherForm.Margin = new System.Windows.Forms.Padding(2);
            this.ExitTeacherForm.Name = "ExitTeacherForm";
            this.ExitTeacherForm.Size = new System.Drawing.Size(100, 42);
            this.ExitTeacherForm.TabIndex = 6;
            this.ExitTeacherForm.Text = "חזרה";
            this.ExitTeacherForm.UseVisualStyleBackColor = false;
            this.ExitTeacherForm.Click += new System.EventHandler(this.ExitTeacherForm_Click);
            // 
            // MouseSize
            // 
            this.MouseSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MouseSize.Location = new System.Drawing.Point(12, 12);
            this.MouseSize.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MouseSize.Name = "MouseSize";
            this.MouseSize.Size = new System.Drawing.Size(148, 33);
            this.MouseSize.TabIndex = 10;
            this.MouseSize.Text = "בחר גודל סמן";
            this.MouseSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackCollor
            // 
            this.BackCollor.AutoSize = true;
            this.BackCollor.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BackCollor.Location = new System.Drawing.Point(22, 17);
            this.BackCollor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BackCollor.Name = "BackCollor";
            this.BackCollor.Size = new System.Drawing.Size(178, 24);
            this.BackCollor.TabIndex = 11;
            this.BackCollor.Text = "בחר צבע רקע משחק";
            // 
            // MultiCollor
            // 
            this.MultiCollor.AutoSize = true;
            this.MultiCollor.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MultiCollor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.MultiCollor.Location = new System.Drawing.Point(113, 58);
            this.MultiCollor.Margin = new System.Windows.Forms.Padding(2);
            this.MultiCollor.Name = "MultiCollor";
            this.MultiCollor.Size = new System.Drawing.Size(71, 24);
            this.MultiCollor.TabIndex = 12;
            this.MultiCollor.Text = "צבעוני";
            this.MultiCollor.UseVisualStyleBackColor = true;
            this.MultiCollor.CheckedChanged += new System.EventHandler(this.MultiCollor_CheckedChanged);
            // 
            // blackBackground
            // 
            this.blackBackground.AutoSize = true;
            this.blackBackground.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.blackBackground.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.blackBackground.Location = new System.Drawing.Point(122, 88);
            this.blackBackground.Margin = new System.Windows.Forms.Padding(2);
            this.blackBackground.Name = "blackBackground";
            this.blackBackground.Size = new System.Drawing.Size(62, 24);
            this.blackBackground.TabIndex = 13;
            this.blackBackground.Text = "שחור";
            this.blackBackground.UseVisualStyleBackColor = true;
            this.blackBackground.CheckedChanged += new System.EventHandler(this.blackBackground_CheckedChanged);
            // 
            // GameLevel
            // 
            this.GameLevel.AutoSize = true;
            this.GameLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GameLevel.Location = new System.Drawing.Point(82, 17);
            this.GameLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameLevel.Name = "GameLevel";
            this.GameLevel.Size = new System.Drawing.Size(157, 24);
            this.GameLevel.TabIndex = 14;
            this.GameLevel.Text = "בחירת רמת משחק";
            // 
            // EseyLevel
            // 
            this.EseyLevel.AutoSize = true;
            this.EseyLevel.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EseyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.EseyLevel.Location = new System.Drawing.Point(121, 58);
            this.EseyLevel.Margin = new System.Windows.Forms.Padding(2);
            this.EseyLevel.Name = "EseyLevel";
            this.EseyLevel.Size = new System.Drawing.Size(127, 24);
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
            this.HardLevel.Location = new System.Drawing.Point(114, 86);
            this.HardLevel.Margin = new System.Windows.Forms.Padding(2);
            this.HardLevel.Name = "HardLevel";
            this.HardLevel.Size = new System.Drawing.Size(134, 24);
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
            this.CustomLevel.Location = new System.Drawing.Point(102, 115);
            this.CustomLevel.Margin = new System.Windows.Forms.Padding(2);
            this.CustomLevel.Name = "CustomLevel";
            this.CustomLevel.Size = new System.Drawing.Size(148, 24);
            this.CustomLevel.TabIndex = 17;
            this.CustomLevel.TabStop = true;
            this.CustomLevel.Text = "התאמה אישית- עד";
            this.CustomLevel.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(31, 118);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // BigMouse
            // 
            this.BigMouse.AutoSize = true;
            this.BigMouse.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BigMouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.BigMouse.Location = new System.Drawing.Point(88, 88);
            this.BigMouse.Margin = new System.Windows.Forms.Padding(2);
            this.BigMouse.Name = "BigMouse";
            this.BigMouse.Size = new System.Drawing.Size(57, 24);
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
            this.SmallMouse.Location = new System.Drawing.Point(92, 60);
            this.SmallMouse.Margin = new System.Windows.Forms.Padding(2);
            this.SmallMouse.Name = "SmallMouse";
            this.SmallMouse.Size = new System.Drawing.Size(53, 24);
            this.SmallMouse.TabIndex = 8;
            this.SmallMouse.TabStop = true;
            this.SmallMouse.Text = "קטן";
            this.SmallMouse.UseVisualStyleBackColor = true;
            // 
            // MousePanel
            // 
            this.MousePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MousePanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MousePanel.Controls.Add(this.BigMouse);
            this.MousePanel.Controls.Add(this.SmallMouse);
            this.MousePanel.Controls.Add(this.MouseSize);
            this.MousePanel.Location = new System.Drawing.Point(647, 359);
            this.MousePanel.Margin = new System.Windows.Forms.Padding(2);
            this.MousePanel.Name = "MousePanel";
            this.MousePanel.Size = new System.Drawing.Size(162, 126);
            this.MousePanel.TabIndex = 19;
            // 
            // ColorPanel
            // 
            this.ColorPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ColorPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ColorPanel.Controls.Add(this.blackBackground);
            this.ColorPanel.Controls.Add(this.MultiCollor);
            this.ColorPanel.Controls.Add(this.BackCollor);
            this.ColorPanel.Location = new System.Drawing.Point(417, 359);
            this.ColorPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(212, 126);
            this.ColorPanel.TabIndex = 20;
            this.ColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ColorPanel_Paint);
            // 
            // LevelPanel
            // 
            this.LevelPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LevelPanel.AutoSize = true;
            this.LevelPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.LevelPanel.Controls.Add(this.CustomLevel);
            this.LevelPanel.Controls.Add(this.numericUpDown1);
            this.LevelPanel.Controls.Add(this.HardLevel);
            this.LevelPanel.Controls.Add(this.GameLevel);
            this.LevelPanel.Controls.Add(this.EseyLevel);
            this.LevelPanel.Location = new System.Drawing.Point(128, 359);
            this.LevelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LevelPanel.Name = "LevelPanel";
            this.LevelPanel.Size = new System.Drawing.Size(254, 152);
            this.LevelPanel.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(620, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "חיפוש תלמיד לפי שם";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(454, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 20);
            this.textBox1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(684, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "שם התלמיד";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(686, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "תעודת זהות";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(422, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "כתובת";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(422, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "כיתה";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(523, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 28;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(523, 161);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 20);
            this.textBox3.TabIndex = 29;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(249, 161);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(139, 20);
            this.textBox4.TabIndex = 30;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(249, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(139, 20);
            this.textBox5.TabIndex = 31;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Miriam", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(357, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 32;
            this.button1.Text = "מחק תלמיד";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.AutoSize = true;
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Miriam", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button2.Location = new System.Drawing.Point(679, 525);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 46);
            this.button2.TabIndex = 33;
            this.button2.Text = "עדכו משחק";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button3.Font = new System.Drawing.Font("Miriam", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button3.Location = new System.Drawing.Point(647, 210);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 46);
            this.button3.TabIndex = 34;
            this.button3.Text = "הוסף תלמיד";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(821, 631);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LevelPanel);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.MousePanel);
            this.Controls.Add(this.ExitTeacherForm);
            this.Controls.Add(this.StudentEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}