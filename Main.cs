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
    public partial class StartPage : Form
    {
        
        public StartPage()
        {
            InitializeComponent();
        }

        private void StartPage_Load(object sender, EventArgs e)
        {
            cokorchancing();
        }

       public void cokorchancing()
        {
            if (this.BackColor == Color.Black)
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
               
            }
            
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void StudentEntrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm st=new StudentForm();
            st.ShowDialog();
        }

        private void TeacherEntrance_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            TeacherForm T1= new TeacherForm();
            T1.ShowDialog();
         
                      
        }

        private void ExitMAinPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void MannagerEntrance_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditStudent e1=new EditStudent();
            e1.ShowDialog();
        }

        private void Excit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
