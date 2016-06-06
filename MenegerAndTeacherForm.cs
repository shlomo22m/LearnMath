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
        public static int StudentUserId = 0;
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
                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox3.Text == "")
            {
                MessageBox.Show("אנא בחר תלמיד");
            }
            else
            {
                      int studentId = int.Parse(textBox3.Text); 
                    this.Hide();
                    UserGmaneUpdate UserGmaneUpdate = new UserGmaneUpdate(StudentUserId);
                    UserGmaneUpdate.Show();
            }
          

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
   
            connection.Open();
            sql = "SELECT UserId,Fname,Lname,Class,Email,pasword  FROM LearnMath.dbo.[User] where [User].UserType= '1' and [User].Fname ='" + textBox1.Text + "' ";
          
           command = new SqlCommand(sql, connection);
           SqlDataAdapter da = new SqlDataAdapter(command);
           dataReader = command.ExecuteReader();
           while (dataReader.Read())
                    {
                        textBox2.Text = textBox1.Text;
                       textBox5.Text = dataReader.GetValue(3).ToString();
                       textBox3.Text= dataReader.GetValue(0).ToString();
                       StudentUserId = int.Parse(textBox3.Text);
                       textBox4.Text=  dataReader.GetValue(4).ToString();
                       textBox14.Text = dataReader.GetValue(5).ToString();
                       textBox13.Text = dataReader.GetValue(3).ToString();
                  
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "" || textBox8.Text == "" || textBox16.Text == "" || textBox7.Text == "" || textBox12.Text == "")
            {
                MessageBox.Show("אנא הכנס את כל הפרטים");

            }
            else
            {
                connection.Open();
                sql = "INSERT INTO [User](UserId,Fname,Email,UserType,Lname,Pasword) VALUES('" + int.Parse(textBox16.Text) + "','" + textBox17.Text + "','" + textBox12.Text + "','0','" + textBox8.Text + "','" + textBox7.Text + "')";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                connection.Close();
                textBox16.Clear();
                textBox17.Clear();
                textBox12.Clear();
                textBox8.Clear();
                textBox7.Clear();
               
                MessageBox.Show("מורה נוסף");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox17.Clear();
            textBox8.Clear();
            textBox16.Clear();
            textBox7.Clear();  
            textBox12.Clear();
    
            connection.Open();
            sql = "SELECT UserId,Fname,Lname,Class,Email,pasword  FROM LearnMath.dbo.[User] where [User].UserType= '0' and [User].Fname ='" + textBox11.Text + "'and [User].Fname ='" + textBox11.Text + "' ";
            //       sql = "SELECT UserId,Password  FROM ILMApp.dbo.LearnMath";
            command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                textBox17.Text = textBox11.Text;
                textBox8.Text = dataReader.GetValue(2).ToString();
                textBox16.Text = dataReader.GetValue(0).ToString();
                textBox12.Text = dataReader.GetValue(4).ToString();
                textBox7.Text = dataReader.GetValue(5).ToString();
            }
            connection.Close();
            if (textBox16.Text == "")
            {
                MessageBox.Show("מורה לא נמצא");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("אנא בחר תלמיד");
            }
            else
            {
                connection.Open();
                sql = "UPDATE [User] SET  UserId='" + int.Parse(textBox16.Text) + "',Fname='" + textBox17.Text + "',Email='" + textBox12.Text + "',UserType='0',Lname='" + textBox8.Text + "',Pasword='" + textBox7.Text + "' WHERE UserId= '" + int.Parse(textBox16.Text) + "' and UserType='0'";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                connection.Close();
                textBox11.Clear();
                textBox17.Clear();
                textBox8.Clear();
                textBox16.Clear();
                textBox7.Clear();
                textBox12.Clear();
                MessageBox.Show("עודכנו פרטי מורה");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                MessageBox.Show("אנא בחר מורה");
            }
            else
            {
                connection.Open();
                sql = "DELETE FROM [User] WHERE UserId= '" + int.Parse(textBox16.Text) + "' and UserType='0'";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);

                command.ExecuteNonQuery();
                connection.Close();
                textBox11.Clear();
                textBox17.Clear();
                textBox8.Clear();
                textBox16.Clear();
                textBox7.Clear();
                textBox12.Clear();
                MessageBox.Show("נמחקו פרטי מורה");
            }
        }
          // student report
        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowProgres s = new ShowProgres();
            s.Show();
        }

    }
}
