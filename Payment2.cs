using p.hotel1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApp2
{
    public partial class Payment2 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Payment2()
        {
            InitializeComponent();
        }



       /* private void Form16_Load(object sender, EventArgs e)
        {
          /*  label1.Text = Form8.Pay;
            label5.Text = ("Pay Amount = " + Form8.TotalDue);
            label2.Text = ("Enter your " + Form8.Pay + " No:");
            label6.Text = ("Pay Month = " + Form8.Month);

        }*/



        private void button1_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            UHOME form8 = new UHOME();
            form8.Show();*/
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            /*if (Form8.Pay == "Bkash" || Form8.Pay == "Nagad" || Form8.Pay == "Rocket")
            {
                if (textBox1.Text.Length == 11)
                {
                    MessageBox.Show("Your otp is 1234 .Dont share your opt or pin ");
                }
                else
                {
                    MessageBox.Show("Enter correct Number");
                }



            }
            else if (Form8.Pay == "Card")
            {
                if (textBox1.Text.Length == 17)
                {
                    MessageBox.Show("Your otp is 1234 .Dont share your opt or pin ");
                }
                else
                {
                    MessageBox.Show("Enter Correct Card Number");
                }



            }
            else
            {
                MessageBox.Show("Invalid Number");
            }*/
        }



        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }



        private void button2_Click(object sender, EventArgs e)
        {
            
        }

           

        private void Payment2_Load_1(object sender, EventArgs e)
        {
            label1.Text = UHOME.Pay;
            label2.Text = ("Pay Amount = " + UHOME.TotalDue);
            label4.Text = ("Enter your " + UHOME.Pay + " No:");
            label3.Text = ("Pay Month = " + UHOME.Month);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (UHOME.Pay == "Bkash" || UHOME.Pay == "Nagad" || UHOME.Pay == "Rocket")
            {
                if (textBox1.Text.Length == 11)
                {
                    MessageBox.Show("Your otp is 1234 .Dont share your opt or pin ");
                }
                else
                {
                    MessageBox.Show("Enter correct Number");
                }



            }
            else if (UHOME.Pay == "Card")
            {
                if (textBox1.Text.Length == 17)
                {
                    MessageBox.Show("Your otp is 1234 .Dont share your opt or pin ");
                }
                else
                {
                    MessageBox.Show("Enter Correct Card Number");
                }



            }
            else
            {
                MessageBox.Show("Invalid Number");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "1234" && textBox3.Text.Length == 4)
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE PAYMENT1 SET TotalDue = @TP,TotalPay =@TP WHERE Email = @email ", con);

                cmd.Parameters.AddWithValue("@TP", UHOME.TotalDue);
                cmd.Parameters.AddWithValue("@email", Form11.B);



                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                SqlCommand cmd3 = new SqlCommand("INSERT INTO PAYMENT2 (Date,Email,PayAmount) VALUES (GETDATE(),@email,@TP) ", con);

                cmd3.Parameters.AddWithValue("@email", Form11.B);
                cmd3.Parameters.AddWithValue("@TP", UHOME.TotalDue);





                cmd3.ExecuteNonQuery();
                con.Close();



                MessageBox.Show("Payment tk " + UHOME.TotalDue + " to THE Premium Hostelry");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            UHOME F79 = new UHOME();
            F79.Tag = this;
            F79.StartPosition = FormStartPosition.Manual;
            F79.Location = this.Location;

            F79.Show();
        }
    }

    
    }

    
            
    
    


