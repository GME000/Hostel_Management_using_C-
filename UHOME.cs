using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using WindowsFormsApp2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace p.hotel1
{
    public partial class UHOME : Form
    {
        public static int TotalDue;
        public static string Month;
        public static string Pay;

        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public UHOME()
        {
            
            InitializeComponent();
            Fillcombo();
        }

        private void UHOME_Load(object sender, EventArgs e)
        {
           
            label7.Text = ("Email:   " + Form11.B);

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "Select * FROM Registration  WHERE Email=@email";

            SqlCommand cmd = new SqlCommand(query, con);
         
            cmd.Parameters.AddWithValue("@email", Form11.B);

            cmd.ExecuteNonQuery();
            SqlDataReader q = cmd.ExecuteReader();
            q.Read();
            string Name = (q["Name"].ToString());
            
          
            string Birthno = (q["Birthno"].ToString());
            string Address = (q["Address"].ToString());
            string phone = (q["Phone"].ToString());
            label2.Text = Name;
        
         
            label6.Text = Birthno ;
            label3.Text = Address;
            label5.Text = phone;
            
            byte[] b = new byte[0];
            b = (Byte[])(q["Image"]);
            MemoryStream ms = new MemoryStream(b);
            pictureBox1.Image = Image.FromStream(ms);
            con.Close();
          
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT * FROM Meal1 Where Day = DATENAME(WEEKDAY, GETDATE());", con);

            cmd1.ExecuteNonQuery();
            SqlDataReader P5 = cmd1.ExecuteReader();
            P5.Read();
            string BF = (P5["Breakfast"].ToString());
            string L = (P5["Lunch"].ToString());
            string D = (P5["Dinner"].ToString());
            label8.Text = BF;
            label11.Text = L;
            label14.Text = D;
        }

    

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            
    
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd1 = new SqlCommand("SELECT STATUS FROM Registration WHERE Email=@email", con);
                cmd1.Parameters.AddWithValue("@email", Form11.B);
                cmd1.ExecuteNonQuery();
                SqlDataReader q = cmd1.ExecuteReader();
                q.Read();
                string S = (q["STATUS"].ToString());
                if(S == "NOT_Requested")
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Registration SET STATUS = 'Proceeding' WHERE Email = @email", con);
                cmd.Parameters.AddWithValue("@email", Form11.B);
                cmd.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("Your request has been taken");

            }
                else
            {
                System.Windows.Forms.MessageBox.Show("You have already submited a request");
            }
           
         
            

    
         
          



        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Editprofile F79 = new Editprofile();
            F79.Tag = this;
            F79.StartPosition = FormStartPosition.Manual;
            F79.Location = this.Location;

            F79.Show();

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
           


        }
        
        private void button5_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT STATUS FROM Registration WHERE Email = @email", con);////// label1.Text = ("Email:   " + Form11.B);  label4.Text = ("Roomno:" + Insertmember.C);

            cmd1.Parameters.AddWithValue("@email", Form11.B);
            cmd1.ExecuteNonQuery();
            SqlDataReader q = cmd1.ExecuteReader();
            q.Read();
            string S = (q["STATUS"].ToString());
            if (S == "NOT_Requested")
            {
                con.Close();
                
                cmd1.ExecuteNonQuery();
                System.Windows.Forms.MessageBox.Show("You have not requested yet.");

            }
            else if(S == "Proceeding")
            {
                System.Windows.Forms.MessageBox.Show("Your request is pending");
            }
            else if(S == "Accepted")
            {
                con.Close();
                con.Open();
                SqlCommand cmd2 = new SqlCommand("SELECT * FROM BR WHERE Email = @email1", con);

                cmd2.Parameters.AddWithValue("@email1", Form11.B);
                cmd2.ExecuteNonQuery();
                SqlDataReader q2 = cmd2.ExecuteReader();
                q2.Read();
                string ee= (q2["Email"].ToString()) ;
                string rr = (q2["Roomno"].ToString());
                label1.Text = ("Email:" + ee);
                label4.Text = ("Roomno:"+ rr );
            }
            else if (S == "Rejected")
            {
                System.Windows.Forms.MessageBox.Show("Your request is Rejected.");
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            Complain F79 = new Complain();

            F79.Show();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Complain complain = new Complain();
            complain.Tag = this;
            complain.StartPosition = FormStartPosition.Manual;
            complain.Location = this.Location;
            complain.Show();

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            weekmenu w9 = new weekmenu();
            w9.Tag = this;
            w9.StartPosition = FormStartPosition.Manual;
            w9.Location = this.Location;
            w9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           
                try
                {
                SqlConnection con = new SqlConnection(cs);
                
                    con.Open();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM LVAPP WHERE LID = (SELECT MAX(LID) WHERE Email = @email);", con);
                    cmd.Parameters.AddWithValue("@Email", Form11.B);
                    cmd.ExecuteNonQuery();
                    SqlDataReader P = cmd.ExecuteReader();
                    P.Read();
                    string S = (P["Status"].ToString());
                    DateTime SD = (DateTime)P["StartDate"];
                    DateTime ED = (DateTime)P["EndDate"];
                    string FSD = SD.ToString("dd MMMM yyyy");
                    string FED = ED.ToString("dd MMMM yyyy");



                System.Windows.Forms.MessageBox.Show("Your Leave Application For " + FSD + " to " + FED + " is " + S);



                }
                catch
                {
                System.Windows.Forms.MessageBox.Show("You have no Application");
                }
            }

        private void button9_Click(object sender, EventArgs e)
        {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) AS COUNT FROM LVAPP WHERE Status = 'Pending' AND Email = @email", con);
                cmd.Parameters.AddWithValue("@email", Form11.B);
                cmd.ExecuteNonQuery();
                SqlDataReader P = cmd.ExecuteReader();
                P.Read();
                string A = (P["COUNT"].ToString());
                int Count = int.Parse(A);
                if (Count == 0)
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO LVAPP (Reason,StartDate,EndDate,Email) VALUES(@Reason,@StartDate,@EndDate,@email)", con);
                   
                    cmd3.Parameters.AddWithValue("@Reason", textBox1.Text);
                    cmd3.Parameters.AddWithValue("@StartDate", dateTimePicker1.Text);
                    cmd3.Parameters.AddWithValue("@EndDate", dateTimePicker2.Text);
                    cmd3.Parameters.AddWithValue("@email", Form11.B); 





                cmd3.ExecuteNonQuery();
                    con.Close();
                System.Windows.MessageBox.Show("Request sent");



                }
                else
                {
                System.Windows.MessageBox.Show("You have one pending request,Please wait for the response");
                }
            }

        private void button10_Click(object sender, EventArgs e)
        {
            PayAmount();
            Month = comboBox1.Text;
            Pay = button10.Text;
            Payment2 F16 = new Payment2();
            F16.Tag = this;
            F16.StartPosition = FormStartPosition.Manual;
            F16.Location = this.Location;
            F16.Show();
        }
        void PayAmount()
        {
            Dictionary<string, int> monthMap = new Dictionary<string, int>
     {
         {"January", 1},
         {"February", 2},
         {"March", 3},
         {"April", 4},
         {"May", 5},
         {"June", 6},
         {"July", 7},
         {"August", 8},
         {"September", 9},
         {"October", 10},
         {"November", 11},
         {"December", 12}
      };
            string MMM = comboBox1.Text;
            int MN = monthMap[MMM] + 1;

            SqlConnection con = new SqlConnection(cs);


            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT ((DATEDIFF(MONTH,JOINDATE ,@MONTH))*1500) +(DATEDIFF(DAY,JOINDATE ,@MONTH)*170)-TotalPay AS TD FROM Payment1 WHERE Email=@email;", con);
            cmd.Parameters.AddWithValue("@email", Form11.B);
            cmd.Parameters.AddWithValue("@MONTH", new DateTime(2023, MN, 1));
            cmd.ExecuteNonQuery();
            SqlDataReader P = cmd.ExecuteReader();
            P.Read();
            string TD1 = (P["TD"].ToString());
            int TD = int.Parse(TD1);
            con.Close();
            con.Open();
            SqlCommand cmd3 = new SqlCommand("SELECT ISNULL((SUM(DATEDIFF(DAY,StartDate,EndDate))+1)*170,0) AS TLDP FROM LVAPP WHERE Email = @email AND Status = 'Accepted' AND StartDate <= @MONTH AND EndDate <= @MONTH;", con);
            cmd3.Parameters.AddWithValue("@email", Form11.B);
            cmd3.Parameters.AddWithValue("@MONTH", new DateTime(2023, MN, 1));
            cmd3.ExecuteNonQuery();
            SqlDataReader Q = cmd3.ExecuteReader();
            Q.Read();
            string TLDP1 = (Q["TLDP"].ToString());
            int TLDP = int.Parse(TLDP1);
            con.Close();
            TotalDue = TD - TLDP;



        }
        void Fillcombo()
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT DATENAME(MONTH, DATEADD(MONTH, 0, GETDATE())) AS MONTH1 , DATENAME(MONTH, DATEADD(MONTH, 1, GETDATE())) AS MONTH2 ,DATENAME(MONTH, DATEADD(MONTH, 2, GETDATE())) AS MONTH3;", con);
            SqlDataReader dr2;

            con.Open();
            dr2 = cmd.ExecuteReader();
            dr2.Read();

            string MONTH1 = (dr2["MONTH1"].ToString());
            string MONTH2 = (dr2["MONTH2"].ToString());
            string MONTH3 = (dr2["MONTH3"].ToString());



            comboBox1.Items.Add(MONTH1);
            comboBox1.Items.Add(MONTH2);
            comboBox1.Items.Add(MONTH3);




        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f1=new Form11();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f1=new Form11();
            f1.Tag = this;
                f1.StartPosition = FormStartPosition.Manual;
                f1.Location = this.Location;
            f1.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            PayAmount();
            Month = comboBox1.Text;
            Pay = button10.Text;
            Payment2 F16 = new Payment2();
            F16.Tag = this;
            F16.StartPosition = FormStartPosition.Manual;
            F16.Location = this.Location;
            F16.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }
    }
    }
    

