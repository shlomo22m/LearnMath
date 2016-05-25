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
    public partial class StartPage : Form
    {
        public static string connectionstr = "";
        string connetionString = null;
        string sql = null;
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader dataReader;      
        public StartPage()
        {
           InitializeComponent();
           connectionstr = "Data Source=192.168.1.9;Initial Catalog=LearnMath;User ID=ilmwriter;Password=ilmwriter";
           
           connetionString = connectionstr;
           connection = new SqlConnection(connetionString);

         
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
         
            string pasword = null;
            int userType = 1;
            connection.Open();
            sql = "SELECT UserType,UserId,Pasword  FROM LearnMath.dbo.[User] where UserId= '" + UserName.Text + "' and Pasword= '" + Password.Text + "' and UserType= '1' ";
    //       sql = "SELECT UserId,Password  FROM ILMApp.dbo.LearnMath";

           command = new SqlCommand(sql, connection);

           SqlDataAdapter da = new SqlDataAdapter(command);

           dataReader = command.ExecuteReader();

            //while (dataReader.Read())
            //{
            //    userType = (int)dataReader.GetValue(0);
            //}

            if (!(dataReader.HasRows) || userType!=1)
            {
                MessageBox.Show("שם משתמש או סיסמא אינם נכונים");
            }
            else
            {
                this.Hide();
                StudentForm st = new StudentForm();
                st.ShowDialog();
            }
            connection.Close();
        }

        private void TeacherEntrance_Click(object sender, EventArgs e)
        {

          
            string pasword = null;
            int userType = 0;
            connection.Open();
            sql = "SELECT UserType,UserId,Pasword  FROM LearnMath.dbo.[User] where UserId= '" + UserName.Text + "' and Pasword= '" + Password.Text + "' and UserType= '0'";
            //       sql = "SELECT UserId,Password  FROM ILMApp.dbo.LearnMath";

            command = new SqlCommand(sql, connection);

            SqlDataAdapter da = new SqlDataAdapter(command);

            dataReader = command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    userType = (int)dataReader.GetValue(0);
            //}

            if (!(dataReader.HasRows) || userType != 0)
            {
                MessageBox.Show("שם משתמש או סיסמא אינם נכונים");
            }
            else
            {
                int i = 1;
                this.Hide();
                MenegerAndTeacherForm T1 = new MenegerAndTeacherForm(i);

                T1.ShowDialog();

            }
            connection.Close();
         
                      
        }

        private void ExitMAinPage_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void MannagerEntrance_Click(object sender, EventArgs e)
        {
            

            string username = null;
            string pasword = null;
            int userType = 2;
            connection.Open();
            sql = "SELECT UserType,UserId,Pasword  FROM LearnMath.dbo.[User] where UserId= '" + UserName.Text + "' and Pasword= '" + Password.Text + "' and UserType= '2'";
            //       sql = "SELECT UserId,Password  FROM ILMApp.dbo.LearnMath";

            command = new SqlCommand(sql, connection);

            SqlDataAdapter da = new SqlDataAdapter(command);

            dataReader = command.ExecuteReader();
            //while (dataReader.Read())
            //{
            //    userType = (int)dataReader.GetValue(0);
            //}

            if (!(dataReader.HasRows) || userType != 2)
            {
                MessageBox.Show("שם משתמש או סיסמא אינם נכונים");
            }
            else
            {
                int i = 0;
                this.Hide();
                MenegerAndTeacherForm T1 = new MenegerAndTeacherForm(i);

                T1.ShowDialog();

            }
            connection.Close();
        }

        private void Excit_Click(object sender, EventArgs e)
        {
            Application.Exit();
          
            
        }
    }
}
