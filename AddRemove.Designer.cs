namespace LearnMath
{
    partial class AddRemove
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
            this.ExitARbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExitARbutton
            // 
            this.ExitARbutton.Location = new System.Drawing.Point(67, 419);
            this.ExitARbutton.Name = "ExitARbutton";
            this.ExitARbutton.Size = new System.Drawing.Size(75, 23);
            this.ExitARbutton.TabIndex = 0;
            this.ExitARbutton.Text = "יציאה";
            this.ExitARbutton.UseVisualStyleBackColor = true;
            // 
            // AddRemove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1171, 496);
            this.Controls.Add(this.ExitARbutton);
            this.Name = "AddRemove";
            this.Text = "AddRemove";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExitARbutton;
    }
}