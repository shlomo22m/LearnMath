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
    public partial class NumbersSequence : Form
    {
        public NumbersSequence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm form1 = new StudentForm(-1);
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
