using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System;
using System.Diagnostics;

namespace LearnMath
{
    public partial class ShowProgres : Form
    {
        public static int totalGrade = 0;
        public static int GmameIndex=0;
        public static string connectionstr = "";
        public static int StudentUserId = 0;
        string connetionString = null;
        string sql = null;
        SqlCommand command;
        SqlConnection connection;
        SqlDataReader dataReader;
        public static int j = 0;
        public ShowProgres()
        {
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
            fillClassCombox();
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenegerAndTeacherForm m = new MenegerAndTeacherForm();
            m.Show();
        }
        private void ShowProgres_Load(object sender, EventArgs e)
        {           
        }
        //report in PDf for one student and one game
        private void ShowReport_Click(object sender, EventArgs e)
        {
            int UserId = 0;
            int GmameIndex = 0;
            int level = 0;      
            string GameName = null;
            if (!(comboBox1.Items.Contains("some value")))
            {
                try
                {
                    GameName = comboBox1.SelectedItem.ToString();
                }
                catch
                {
                }              
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
            }         
            if (IdSerchTxt.Text == "" || GmameIndex==0)
            {
                MessageBox.Show("אנא בחר את כל הפרטים");
            }
            else
            {
                connection.Open();
                sql = "SELECT UserId,GameCode,Grade FROM LearnMath.dbo.[StudentPlay] where StudentPlay.UserId ='" + IdSerchTxt.Text + "' and StudentPlay.GameCode='" + GmameIndex + "' ";
                command = new SqlCommand(sql, connection);
                SqlDataAdapter da = new SqlDataAdapter(command);
                dataReader = command.ExecuteReader();
                if (!(dataReader.HasRows))
                {
                    MessageBox.Show("תלמיד לא נמצא");
                    IdSerchTxt.Clear();
                    comboBox1.ResetText();
                    connection.Close();        
                }
                else
                {
                    while (dataReader.Read())
                    {
                        UserId = int.Parse(dataReader.GetValue(0).ToString());
                        totalGrade += int.Parse(dataReader.GetValue(2).ToString());
                    }                
                connection.Close();        
                IdSerchTxt.Clear();
                Document Doc = new Document();
                PdfWriter.GetInstance(Doc,new FileStream("C:/Users/felix/Desktop/repoetPerStudent.pdf",FileMode.Create));
                Doc.Open();
                Paragraph p1 = new Paragraph(totalGrade.ToString());
                Doc.Add(p1);
                Doc.Close();
                Process op = new Process();
                op.StartInfo.FileName = "C:/Users/felix/Desktop/repoetPerStudent.pdf";
                op.Start();
                totalGrade = 0;
                comboBox1.ResetText();                                
              }
          }           
        }

        // all students report in PDF
        private void button2_Click_1(object sender, EventArgs e)
        {
            int UserId = 0;
            connection.Open();
            sql = "SELECT sum ([Grade])as TotalGrade,UserId FROM LearnMath.dbo.StudentPlay group by UserId";
            command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dataReader = command.ExecuteReader();
            IdSerchTxt.Clear();
            Document Doc = new Document();
            PdfWriter.GetInstance(Doc, new FileStream("C:/Users/felix/Desktop/reportForAll.pdf", FileMode.Create));
            Doc.Open();
            while (dataReader.Read())
            {              
                totalGrade = int.Parse(dataReader.GetValue(0).ToString());
                UserId = int.Parse(dataReader.GetValue(1).ToString());
                Paragraph p1 = new Paragraph ("User Id " + UserId + "  Total Grade " + totalGrade.ToString());
                Doc.Add(p1);
            }
            connection.Close();
            Doc.Close();
            Process op = new Process();
            op.StartInfo.FileName = "C:/Users/felix/Desktop/reportForAll.pdf";
           
            op.Start();
        }
        private void ShowProgres_Load_1(object sender, EventArgs e)
        {
         
        }

        // Pdf report per Class
        private void button3_Click(object sender, EventArgs e)
        {
            Document Doc = new Document();
            PdfWriter.GetInstance(Doc, new FileStream("C:/Users/felix/Desktop/reportPerClass.pdf", FileMode.Create));
            Doc.Open();
            connection.Open();
            string Class = comboBox2.SelectedItem.ToString();
            sql = "SELECT UserID FROM LearnMath.dbo.[User] where Class= '" + Class + "'";
            
            command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {                       
                int Grade = int.Parse(dataReader.GetValue(0).ToString()); ;
                Paragraph p1 = new Paragraph("User Id " + Grade + "  Total Grade " + Grade.ToString());
                Doc.Add(p1);
          
            }
            connection.Close();
            Doc.Close();
            Process op = new Process();
            op.StartInfo.FileName = "C:/Users/felix/Desktop/reportPerClass.pdf";

            op.Start();
        }

        private void fillClassCombox()
        {
            string Class = null;
            connection.Open();
            sql = "SELECT Class FROM LearnMath.dbo.[User]";
            command = new SqlCommand(sql, connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            dataReader = command.ExecuteReader();          
                

            while (dataReader.Read())
            {              
             
                Class = dataReader.GetValue(0).ToString();
                comboBox2.Items.Add(Class);
            }
            connection.Close();
    
        }    

    }
}