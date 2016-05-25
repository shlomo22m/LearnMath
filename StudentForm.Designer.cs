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
            this.Games.Location = new System.Drawing.Point(269, 9);
            this.Games.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Games.Name = "Games";
            this.Games.Size = new System.Drawing.Size(450, 74);
            this.Games.TabIndex = 0;
            this.Games.Text = "נא לבחור משחק";
            // 
            // KnowNumbers
            // 
            this.KnowNumbers.AutoSize = true;
            this.KnowNumbers.BackColor = System.Drawing.Color.SkyBlue;
            this.KnowNumbers.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.KnowNumbers.ForeColor = System.Drawing.Color.Black;
            this.KnowNumbers.Location = new System.Drawing.Point(628, 12);
            this.KnowNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.KnowNumbers.Name = "KnowNumbers";
            this.KnowNumbers.Size = new System.Drawing.Size(267, 162);
            this.KnowNumbers.TabIndex = 1;
            this.KnowNumbers.Text = "הכרת הספרות";
            this.KnowNumbers.UseVisualStyleBackColor = false;
            this.KnowNumbers.Click += new System.EventHandler(this.KnowNumbers_Click);
            // 
            // CountNumbers
            // 
            this.CountNumbers.BackColor = System.Drawing.Color.SkyBlue;
            this.CountNumbers.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.CountNumbers.ForeColor = System.Drawing.Color.Black;
            this.CountNumbers.Location = new System.Drawing.Point(332, 12);
            this.CountNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.CountNumbers.Name = "CountNumbers";
            this.CountNumbers.Size = new System.Drawing.Size(262, 162);
            this.CountNumbers.TabIndex = 2;
            this.CountNumbers.Text = "מנייה";
            this.CountNumbers.UseVisualStyleBackColor = false;
            this.CountNumbers.Click += new System.EventHandler(this.CountNumbers_Click);
            // 
            // MatchNumbers
            // 
            this.MatchNumbers.BackColor = System.Drawing.Color.SkyBlue;
            this.MatchNumbers.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.MatchNumbers.ForeColor = System.Drawing.Color.Black;
            this.MatchNumbers.Location = new System.Drawing.Point(50, 12);
            this.MatchNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.MatchNumbers.Name = "MatchNumbers";
            this.MatchNumbers.Size = new System.Drawing.Size(262, 162);
            this.MatchNumbers.TabIndex = 3;
            this.MatchNumbers.Text = "התאמת ספרה לכמות";
            this.MatchNumbers.UseVisualStyleBackColor = false;
            this.MatchNumbers.Click += new System.EventHandler(this.MatchNumbers_Click);
            // 
            // SequenceNumbers
            // 
            this.SequenceNumbers.BackColor = System.Drawing.Color.SkyBlue;
            this.SequenceNumbers.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.SequenceNumbers.ForeColor = System.Drawing.Color.Black;
            this.SequenceNumbers.Location = new System.Drawing.Point(628, 221);
            this.SequenceNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.SequenceNumbers.Name = "SequenceNumbers";
            this.SequenceNumbers.Size = new System.Drawing.Size(262, 162);
            this.SequenceNumbers.TabIndex = 4;
            this.SequenceNumbers.Text = "רצף מספרים";
            this.SequenceNumbers.UseVisualStyleBackColor = false;
            this.SequenceNumbers.Click += new System.EventHandler(this.SequenceNumbers_Click);
            // 
            // MemoryGame
            // 
            this.MemoryGame.BackColor = System.Drawing.Color.SkyBlue;
            this.MemoryGame.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.MemoryGame.ForeColor = System.Drawing.Color.Black;
            this.MemoryGame.Location = new System.Drawing.Point(332, 221);
            this.MemoryGame.Margin = new System.Windows.Forms.Padding(2);
            this.MemoryGame.Name = "MemoryGame";
            this.MemoryGame.Size = new System.Drawing.Size(262, 162);
            this.MemoryGame.TabIndex = 5;
            this.MemoryGame.Text = "משחק הזיכרון";
            this.MemoryGame.UseVisualStyleBackColor = false;
            this.MemoryGame.Click += new System.EventHandler(this.MemoryGame_Click);
            // 
            // AddSubNumbers
            // 
            this.AddSubNumbers.BackColor = System.Drawing.Color.SkyBlue;
            this.AddSubNumbers.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Bold);
            this.AddSubNumbers.ForeColor = System.Drawing.Color.Black;
            this.AddSubNumbers.Location = new System.Drawing.Point(50, 221);
            this.AddSubNumbers.Margin = new System.Windows.Forms.Padding(2);
            this.AddSubNumbers.Name = "AddSubNumbers";
            this.AddSubNumbers.Size = new System.Drawing.Size(262, 162);
            this.AddSubNumbers.TabIndex = 6;
            this.AddSubNumbers.Text = "חיבור וחיסור";
            this.AddSubNumbers.UseVisualStyleBackColor = false;
      
            // 
            // ExitGames
            // 
            this.ExitGames.BackColor = System.Drawing.Color.DeepPink;
            this.ExitGames.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ExitGames.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitGames.Location = new System.Drawing.Point(50, 442);
            this.ExitGames.Margin = new System.Windows.Forms.Padding(2);
            this.ExitGames.Name = "ExitGames";
            this.ExitGames.Size = new System.Drawing.Size(113, 49);
            this.ExitGames.TabIndex = 7;
            this.ExitGames.Text = "חזרה";
            this.ExitGames.UseVisualStyleBackColor = false;
            this.ExitGames.Click += new System.EventHandler(this.ExitGames_Click);
            // 
            // GamesPanel
            // 
            this.GamesPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GamesPanel.AutoSize = true;
            this.GamesPanel.BackColor = System.Drawing.Color.White;
            this.GamesPanel.Controls.Add(this.SequenceNumbers);
            this.GamesPanel.Controls.Add(this.ExitGames);
            this.GamesPanel.Controls.Add(this.MemoryGame);
            this.GamesPanel.Controls.Add(this.MatchNumbers);
            this.GamesPanel.Controls.Add(this.AddSubNumbers);
            this.GamesPanel.Controls.Add(this.CountNumbers);
            this.GamesPanel.Controls.Add(this.KnowNumbers);
            this.GamesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.GamesPanel.Location = new System.Drawing.Point(38, 110);
            this.GamesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.GamesPanel.Name = "GamesPanel";
            this.GamesPanel.Size = new System.Drawing.Size(957, 804);
            this.GamesPanel.TabIndex = 8;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1044, 612);
            this.Controls.Add(this.GamesPanel);
            this.Controls.Add(this.Games);
            this.Margin = new System.Windows.Forms.Padding(2);
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