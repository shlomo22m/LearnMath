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
    public partial class UserGmaneUpdate : Form
    {
        public static int UserID = 0;
        public static string connectionstr = "";
        public static int CountNumGames = 0;
        string connetionString = null;
        string sql = null;
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader dataReader;
        public UserGmaneUpdate(int StudentUserId)
        {
            UserID = StudentUserId;
            InitializeComponent();
            connectionstr = "Data Source=192.168.1.9;Initial Catalog=LearnMath;User ID=ilmwriter;Password=ilmwriter";

            connetionString = connectionstr;
            connection = new SqlConnection(connetionString);
            comboBox1.Items.Add("הכרת ספרות");
            comboBox1.Items.Add("מנייה");
            comboBox1.Items.Add("התאמת ספרות לכמות");
            comboBox1.Items.Add("רצף מספרים");
            comboBox1.Items.Add("משחק הזיכרון");
            comboBox1.Items.Add("חיבור וחיסור");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenegerAndTeacherForm MenegerAndTeacherForm = new MenegerAndTeacherForm();
            MenegerAndTeacherForm.Show();
        }
        // update game settings
        private void button2_Click(object sender, EventArgs e)
        {
            int level = 0;
            int markSize = 0;
            string background = null;
             string GameName=null;
          
            if (!(comboBox1.Items.Contains("some value")))
            {
                try
                {

                    GameName = comboBox1.SelectedItem.ToString();
                }
               catch
                {

                }
                int GmameIndex = 0;
                switch (GameName)
                {
                    case "הכרת ספרות":
                        GmameIndex = 1;
                        break;
                    case "מנייה":
                        GmameIndex = 2;
                        break;

                    case "התאמת ספרות לכמות":
                        GmameIndex = 3;
                        break;
                    case "רצף מספרים":
                        GmameIndex = 4;
                        break;
                    case "משחק הזיכרון":
                        GmameIndex = 5;
                        break;
                    case "חיבור וחיסור":
                        GmameIndex = 6;
                        break;
                    default:
                  
                        GmameIndex = 0;
                        break;
                }

                if(SmallMouse.Checked)
                {
                    markSize = 0;
                }
                else
                {
                    markSize = 1;
                }

                if (MultiCollor.Checked)
                {
                    background = "MultiCollor";
                }
                else
                {
                    background = "blackBackground";
                }

                level = (int)(numericUpDown1.Value);
              
                if (GmameIndex==0)
                {
                    MessageBox.Show("בחר משחק");
                }
                else
                {
                    CountNumGames++;
                    connection.Open();
                        sql = "INSERT INTO [StudentPlay](PlayGameCode,GameCode,Level,UserId,MarkSize,background) VALUES('" + CountNumGames + "','" + GmameIndex + "', '" + level + "','" + UserID + "','" + markSize + "','" + background + "')";
                        command = new SqlCommand(sql, connection);
                        SqlDataAdapter da = new SqlDataAdapter(command);

                        command.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("פרטי משחק נשמרו");
                        connection.Close();
                        this.Hide();
                        MenegerAndTeacherForm mf = new MenegerAndTeacherForm();
                        mf.Show();


                }
            }
            else
            {
                MessageBox.Show("בחר משחק");
            }
        }

        private void UserGmaneUpdate_Load(object sender, EventArgs e)
        {

        }

       
    }
}
