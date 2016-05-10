using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LearnMath
{
    
    public partial class TeacherForm : Form
    {
        private StartPage s1=new StartPage();
       
        
       
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void ExitTeacherForm_Click(object sender, EventArgs e)
        {
           
           s1.Show();
           this.Close();

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
       

        }

        private void ColorPanel_Paint(object sender, PaintEventArgs e)
        {

            if (blackBackground.Checked == true)
            {
                ColorPanel.BackColor = Color.White;
                MousePanel.BackColor = Color.White;
                LevelPanel.BackColor = Color.White;
                this.BackgroundImage = null;    
               
            }

        }

        private void blackBackground_CheckedChanged(object sender, EventArgs e)
        {
          
            
            
        }

        private void StudentDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProgres S2 = new ShowProgres();
            S2.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MultiCollor_CheckedChanged(object sender, EventArgs e)
        {


        }
    }
}
