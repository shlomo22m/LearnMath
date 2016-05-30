using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LearnMath
{
    public partial class LearnDigit : Form
    {
        public static int UserId = 0;             
        public static string connectionstr = "";     
        string connetionString = null;
        string sql = null;
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader dataReader;
        public LearnDigit(int UserID)
        {
            InitializeComponent();
            UserId = UserID;
            connectionstr = "Data Source=192.168.1.9;Initial Catalog=LearnMath;User ID=ilmwriter;Password=ilmwriter";

            connetionString = connectionstr;
            connection = new SqlConnection(connetionString);       
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        //start Game
        private void button2_Click(object sender, EventArgs e)
        {
            int PlayGameCode=0;
            int GameCode=0;
            int Level = 0;
           
            string MarkSize = null;
            string background = null;

            connection.Open();
            sql = "SELECT  top 1 PlayGameCode,GameCode,Level,UserId,MarkSize,background FROM LearnMath.dbo.StudentPlay where UserId= '" + UserId + "' and GameCode='1' ORDER BY PlayGameCode DESC";

            command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {

                PlayGameCode = int.Parse(dataReader.GetValue(0).ToString());
                GameCode = int.Parse(dataReader.GetValue(1).ToString());
                Level = int.Parse(dataReader.GetValue(2).ToString());
                MarkSize = dataReader.GetValue(4).ToString();
                background = dataReader.GetValue(5).ToString();                

            }
            connection.Close();
            MessageBox.Show("נתונים הוטענו התחל לשחק");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentForm form1 = new StudentForm(-1);
            form1.Show();
        }

        private void LearnDigit_Load(object sender, EventArgs e)
        {

        }
    }
}
