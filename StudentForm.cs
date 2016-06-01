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
    public partial class StudentForm : Form
    {
        static public int UserID = 0;
        public StudentForm(int UserName)
        {
            InitializeComponent();
            UserID = UserName;
        }

        private void ExitGames_Click(object sender, EventArgs e)
        {
            StartPage s1 = new StartPage();
            s1.Show();
            this.Close();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {

        }

        private void KnowNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            LearnDigit L1 = new LearnDigit(UserID);
            L1.ShowDialog();
        }

        private void CountNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            Counting C1 = new Counting();
            C1.ShowDialog();
        }

        private void MatchNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            MatchDigitToCount M1 = new MatchDigitToCount(-1);
            M1.ShowDialog();
        }

        private void SequenceNumbers_Click(object sender, EventArgs e)
        {
            this.Hide();
            NumbersSequence N1 = new NumbersSequence(-1);
            N1.ShowDialog();
        }

        private void MemoryGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            MemoryGame G1 = new MemoryGame(-1);
            G1.ShowDialog();
        }

      
    }
}
