namespace LearnMath
{
    partial class LearnDigit
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
            this.components = new System.ComponentModel.Container();
            this.Start_game = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Start_game
            // 
            this.Start_game.BackColor = System.Drawing.Color.MistyRose;
            this.Start_game.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Start_game.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Start_game.Location = new System.Drawing.Point(12, 12);
            this.Start_game.Name = "Start_game";
            this.Start_game.Size = new System.Drawing.Size(159, 37);
            this.Start_game.TabIndex = 3;
            this.Start_game.Text = "התחל משחק";
            this.Start_game.UseVisualStyleBackColor = false;
            this.Start_game.Click += new System.EventHandler(this.Start_game_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.MistyRose;
            this.Exit.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Exit.Location = new System.Drawing.Point(26, 526);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(104, 37);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "חזרה";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.Silver;
            this.LeftPanel.Location = new System.Drawing.Point(131, 57);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(242, 439);
            this.LeftPanel.TabIndex = 4;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.Color.White;
            this.RightPanel.Location = new System.Drawing.Point(513, 57);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(234, 439);
            this.RightPanel.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(778, 10);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(56, 19);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 600;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(529, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 19);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LearnDigit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1070, 574);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.Start_game);
            this.Controls.Add(this.Exit);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LearnDigit";
            this.Text = "LearnDigit";
            this.Load += new System.EventHandler(this.LearnDigit_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start_game;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;

    }
}