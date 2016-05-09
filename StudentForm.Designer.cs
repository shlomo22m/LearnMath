namespace LearnMath
{
    partial class StudentForm
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
            this.Games = new System.Windows.Forms.Label();
            this.KnowNumbers = new System.Windows.Forms.Button();
            this.CountNumbers = new System.Windows.Forms.Button();
            this.MatchNumbers = new System.Windows.Forms.Button();
            this.SequenceNumbers = new System.Windows.Forms.Button();
            this.MemoryGame = new System.Windows.Forms.Button();
            this.AddSubNumbers = new System.Windows.Forms.Button();
            this.ExitGames = new System.Windows.Forms.Button();
            this.GamesPanel = new System.Windows.Forms.Panel();
            this.GamesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Games
            // 
            this.Games.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Games.AutoSize = true;
            this.Games.Font = new System.Drawing.Font("Aharoni", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Games.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Games.Location = new System.Drawing.Point(506, -11);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(269, 79);
            this.Games.TabIndex = 0;
            this.Games.Text = "משחקים";
            // 
            // KnowNumbers
            // 
            this.KnowNumbers.AutoSize = true;
            this.KnowNumbers.ForeColor = System.Drawing.Color.SeaGreen;
            this.KnowNumbers.Location = new System.Drawing.Point(838, 15);
            this.KnowNumbers.Name = "KnowNumbers";
            this.KnowNumbers.Size = new System.Drawing.Size(350, 200);
            this.KnowNumbers.TabIndex = 1;
            this.KnowNumbers.Text = "הכרת הספרות";
            this.KnowNumbers.UseVisualStyleBackColor = true;
            this.KnowNumbers.Click += new System.EventHandler(this.KnowNumbers_Click);
            // 
            // CountNumbers
            // 
            this.CountNumbers.ForeColor = System.Drawing.Color.SeaGreen;
            this.CountNumbers.Location = new System.Drawing.Point(442, 15);
            this.CountNumbers.Name = "CountNumbers";
            this.CountNumbers.Size = new System.Drawing.Size(350, 200);
            this.CountNumbers.TabIndex = 2;
            this.CountNumbers.Text = "מנייה";
            this.CountNumbers.UseVisualStyleBackColor = true;
            this.CountNumbers.Click += new System.EventHandler(this.CountNumbers_Click);
            // 
            // MatchNumbers
            // 
            this.MatchNumbers.ForeColor = System.Drawing.Color.SeaGreen;
            this.MatchNumbers.Location = new System.Drawing.Point(66, 15);
            this.MatchNumbers.Name = "MatchNumbers";
            this.MatchNumbers.Size = new System.Drawing.Size(350, 200);
            this.MatchNumbers.TabIndex = 3;
            this.MatchNumbers.Text = "התאמת ספרה לכמות";
            this.MatchNumbers.UseVisualStyleBackColor = true;
            this.MatchNumbers.Click += new System.EventHandler(this.MatchNumbers_Click);
            // 
            // SequenceNumbers
            // 
            this.SequenceNumbers.ForeColor = System.Drawing.Color.SeaGreen;
            this.SequenceNumbers.Location = new System.Drawing.Point(838, 272);
            this.SequenceNumbers.Name = "SequenceNumbers";
            this.SequenceNumbers.Size = new System.Drawing.Size(350, 200);
            this.SequenceNumbers.TabIndex = 4;
            this.SequenceNumbers.Text = "רצף מספרים";
            this.SequenceNumbers.UseVisualStyleBackColor = true;
            this.SequenceNumbers.Click += new System.EventHandler(this.SequenceNumbers_Click);
            // 
            // MemoryGame
            // 
            this.MemoryGame.ForeColor = System.Drawing.Color.SeaGreen;
            this.MemoryGame.Location = new System.Drawing.Point(442, 272);
            this.MemoryGame.Name = "MemoryGame";
            this.MemoryGame.Size = new System.Drawing.Size(350, 200);
            this.MemoryGame.TabIndex = 5;
            this.MemoryGame.Text = "משחק הזיכרון";
            this.MemoryGame.UseVisualStyleBackColor = true;
            this.MemoryGame.Click += new System.EventHandler(this.MemoryGame_Click);
            // 
            // AddSubNumbers
            // 
            this.AddSubNumbers.ForeColor = System.Drawing.Color.SeaGreen;
            this.AddSubNumbers.Location = new System.Drawing.Point(66, 272);
            this.AddSubNumbers.Name = "AddSubNumbers";
            this.AddSubNumbers.Size = new System.Drawing.Size(350, 200);
            this.AddSubNumbers.TabIndex = 6;
            this.AddSubNumbers.Text = "חיבור וחיסור";
            this.AddSubNumbers.UseVisualStyleBackColor = true;
            this.AddSubNumbers.Click += new System.EventHandler(this.AddSubNumbers_Click);
            // 
            // ExitGames
            // 
            this.ExitGames.Location = new System.Drawing.Point(64, 32);
            this.ExitGames.Name = "ExitGames";
            this.ExitGames.Size = new System.Drawing.Size(75, 23);
            this.ExitGames.TabIndex = 7;
            this.ExitGames.Text = "יציאה";
            this.ExitGames.UseVisualStyleBackColor = true;
            this.ExitGames.Click += new System.EventHandler(this.ExitGames_Click);
            // 
            // GamesPanel
            // 
            this.GamesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamesPanel.AutoSize = true;
            this.GamesPanel.Controls.Add(this.SequenceNumbers);
            this.GamesPanel.Controls.Add(this.MemoryGame);
            this.GamesPanel.Controls.Add(this.MatchNumbers);
            this.GamesPanel.Controls.Add(this.AddSubNumbers);
            this.GamesPanel.Controls.Add(this.CountNumbers);
            this.GamesPanel.Controls.Add(this.KnowNumbers);
            this.GamesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GamesPanel.Location = new System.Drawing.Point(50, 136);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(1276, 990);
            this.GamesPanel.TabIndex = 8;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1392, 753);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.ExitGames);
            this.Controls.Add(this.Games);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.GamesPanel.ResumeLayout(false);
            this.GamesPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Games;
        private System.Windows.Forms.Button KnowNumbers;
        private System.Windows.Forms.Button CountNumbers;
        private System.Windows.Forms.Button MatchNumbers;
        private System.Windows.Forms.Button SequenceNumbers;
        private System.Windows.Forms.Button MemoryGame;
        private System.Windows.Forms.Button AddSubNumbers;
        private System.Windows.Forms.Button ExitGames;
        private System.Windows.Forms.Panel GamesPanel;
    }
}