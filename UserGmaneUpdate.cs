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
    public partial class UserGmaneUpdate : Form
    {
        public UserGmaneUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenegerAndTeacherForm MenegerAndTeacherForm = new MenegerAndTeacherForm();
            MenegerAndTeacherForm.Show();
        }
    }
}
