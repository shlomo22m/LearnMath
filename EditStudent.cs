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
    public partial class EditStudent : Form
    {
        
        public EditStudent()
        {
            InitializeComponent();
        }

        private void ExitUpdate_Click(object sender, EventArgs e)
        {
            StartPage s1 = new StartPage();
            s1.Show();
            this.Close();
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddStudent A1 = new AddStudent();
            A1.ShowDialog();           
        }

        private void DeleteStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProgres S1 = new ShowProgres();
            S1.ShowDialog();
        }

        private void AddTecher_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTeacher At1 = new AddTeacher();
            At1.ShowDialog();
        }
    }
}
