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
   
    
    public partial class MenegerAndTeacherForm : Form
    {
        public static string connectionstr = "";

        string connetionString = null;
        string sql = null;
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader dataReader;      
        public static int j = 0;
        private StartPage s1=new StartPage();
       
        
       public MenegerAndTeacherForm(int i)
        {

            j = i;
            InitializeComponent();
            connectionstr = "Data Source=192.168.1.9;Initial Catalog=LearnMath;User ID=ilmwriter;Password=ilmwriter";

            connetionString = connectionstr;
            connection = new SqlConnection(connetionString);
       
        }
        


        public MenegerAndTeacherForm()
        {
            InitializeComponent();
            connectionstr = "Data Source=192.168.1.9;Initial Catalog=LearnMath;User ID=ilmwriter;Password=ilmwriter";

            connetionString = connectionstr;
            connection = new SqlConnection(connetionString);
        }

        private void ExitTeacherForm_Click(object sender, EventArgs e)
        {
           
          
           this.Close();
           s1.Show();

        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            if (j == 1)
            {
                ManagerPanel.Hide();
            
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
        //delete student
        private void button1_Click(object sender, EventArgs e)
        {
            if( textBox3.Text== "")
            {
                MessageBox.Show("אנא בחר תלמיד");
            }
            else
            { 
                connection.Open();
                sql = "DELETE FROM [User] WHERE UserId= '" + int.Parse(textBox3.Text) + "' and UserType='1'";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                connection.Close();
                textBox3.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox4.Clear();
                textBox13.Clear();
                textBox14.Clear();
                MessageBox.Show("נמחקו פרטי תלמיד");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserGmaneUpdate UserGmaneUpdate = new UserGmaneUpdate();
            UserGmaneUpdate.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
   
    
         //DefaultView.RowFilter = string.Format("User LIKE '%{0}%'", textBox1.Text);

         
        }

        //show student ditealis 
        private void button7_Click(object sender, EventArgs e)
        {

            textBox2.Clear();
            textBox5.Clear();
            textBox3.Clear();
            textBox4.Clear();   
            string username = null;
            string pasword = null;
            int userType = 0;
            connection.Open();
            sql = "SELECT UserId,Fname,Lname,Class,Email  FROM LearnMath.dbo.[User] where [User].UserType= '1' and [User].Fname ='" + textBox1.Text + "' ";
            //       sql = "SELECT UserId,Password  FROM ILMApp.dbo.LearnMath";
           command = new SqlCommand(sql, connection);
           SqlDataAdapter da = new SqlDataAdapter(command);
           dataReader = command.ExecuteReader();
           while (dataReader.Read())
                    {
                        textBox2.Text = textBox1.Text;
                       textBox5.Text = dataReader.GetValue(3).ToString();
                       textBox3.Text= dataReader.GetValue(0).ToString();
                       textBox4.Text=  dataReader.GetValue(4).ToString();                                             
                    }     
            connection.Close();
            if (textBox5.Text=="")
           {
               MessageBox.Show("תלמיד לא נמצא");
           }
        }


        //add student
        private void button3_Click(object sender, EventArgs e)
        {


            if (textBox3.Text == "" || textBox2.Text == "" || textBox5.Text == "" || textBox4.Text == "" || textBox13.Text == "" || textBox14.Text == "")
            {
                MessageBox.Show("אנא הכנס את כל הפרטים");

            }
            else
            {
                connection.Open();
                sql = "INSERT INTO [User](UserId,Fname,Class,Email,UserType,Lname,Pasword) VALUES('" + int.Parse(textBox3.Text) + "','" + textBox2.Text + "', '" + textBox5.Text + "','" + textBox4.Text + "','1','" + textBox13.Text + "','" + textBox14.Text + "')";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                connection.Close();
                textBox3.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox4.Clear();
                textBox13.Clear();
                textBox14.Clear();
                MessageBox.Show("תלמיד נוסף");
            }

        }

        //edit student
        private void StudentEdit_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("אנא בחר תלמיד");
            }
            else
            {
                connection.Open();
                sql = "UPDATE [User] SET  UserId='" + int.Parse(textBox3.Text) + "',Fname='" + textBox2.Text + "',Class= '" + textBox5.Text + "',Email='" + textBox4.Text + "',UserType='1',Lname='" + textBox13.Text + "',Pasword='" + textBox14.Text + "' WHERE UserId= '" + int.Parse(textBox3.Text) + "' and UserType='1'";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                connection.Close();
                textBox3.Clear();
                textBox2.Clear();
                textBox5.Clear();
                textBox4.Clear();
                textBox13.Clear();
                textBox14.Clear();
                MessageBox.Show("עודכנו פרטי תלמיד");
            }
        }

    }
}
