using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Controls;
using Image = System.Drawing.Image;

namespace p.hotel1
{
    public partial class Form4 : Form
    {

        public static string J;
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public string g;

        public Form4()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0 || textBox2.Text.Length == 0 || textBox3.Text.Length == 0 || textBox4.Text.Length == 0 || textBox6.Text.Length == 0 || pictureBox1.Image == null)
            {
                MessageBox.Show("Fill all info");
            }
            else
            {
                if (textBox2.Text.Length == 17)
                {



                    SqlConnection con1 = new SqlConnection(cs);
                    con1.Open();
                    SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) AS COUNT FROM Registration WHERE Birthno = @BirthC", con1);



                    cmd2.Parameters.AddWithValue("@BirthC", textBox2.Text);
                    cmd2.ExecuteNonQuery();
                    SqlDataReader P = cmd2.ExecuteReader();
                    P.Read();
                    string A = (P["COUNT"].ToString());
                    int Count = int.Parse(A);
                    if (Count == 0)
                    {
                        string tt = textBox4.Text;
                        if (tt.StartsWith("13") || tt.StartsWith("14") || tt.StartsWith("15") || tt.StartsWith("16") || tt.StartsWith("17") || tt.StartsWith("18") || tt.StartsWith("19"))
                        {
                            SqlConnection con3 = new SqlConnection(cs);
                            con3.Open();
                            SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) AS COUNT1 FROM Registration WHERE Phone = '+880'+@Phone", con3);



                            cmd3.Parameters.AddWithValue("@Phone", textBox4.Text);
                            cmd3.ExecuteNonQuery();
                            SqlDataReader Pp = cmd3.ExecuteReader();
                            Pp.Read();
                            string Aa = (Pp["COUNT1"].ToString());
                            int Count1 = int.Parse(Aa);
                            if (textBox4.Text.Length == 10 && Count1 == 0)
                            {
                                System.Drawing.Image i = pictureBox1.Image;
                                ImageConverter Converter = new ImageConverter();
                                var ImageConverter = Converter.ConvertTo(i, typeof(byte[]));
                                SqlConnection con = new SqlConnection(cs);
                                con.Open();
                                SqlCommand cmd = new SqlCommand("INSERT INTO Registration(Name,Birthno,Gender,Birthdate,Address,Phone,Email,Image)" + "VALUES(@Name,@bn,@gn,@bd,@adr,'+880'+@Phone,@email,@image)", con);
                                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                               
                                cmd.Parameters.AddWithValue("@bn", textBox2.Text);
                               
                                cmd.Parameters.AddWithValue("@gn",  comboBox1.Text);
                                cmd.Parameters.AddWithValue("@bd", dateTimePicker1.Text);
                                cmd.Parameters.AddWithValue("@adr", textBox3.Text);
                                cmd.Parameters.AddWithValue("@Phone", textBox4.Text);
                                cmd.Parameters.AddWithValue("@email", textBox6.Text);
                                cmd.Parameters.AddWithValue("@Image", ImageConverter);




                                J=textBox6.Text;
                                cmd.ExecuteNonQuery();
                                con.Close();



                                MessageBox.Show("Information inserted");
                                this.Hide();
                                Form5 F5 = new Form5();
                                F5.Tag = this;
                                F5.StartPosition = FormStartPosition.Manual;
                                F5.Location = this.Location;
                                F5.Show();






                            }
                            else if (Count1 > 0)
                            {
                                MessageBox.Show("Phone no already taken");
                            }
                            else
                            {
                                MessageBox.Show("Invalid phone no");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid phone no");
                        }
                    }
                    else if (Count > 0)
                    {
                        MessageBox.Show("Birth certificate number already taken");
                    }
                    else
                    {
                        MessageBox.Show("Birth certificate number is incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Birth certificate number is incorrect");
                }
            }

        }



        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {


            




        }
        static bool IsStrongPassword(string password)
        {

            Regex uppercaseRegex = new Regex(@"[A-Z]");
            Regex specialCharRegex = new Regex(@"[!@#$%^&*()_+{}\[\]:;<>,.?~]");




            bool hasUppercase = uppercaseRegex.IsMatch(password);
            bool hasSpecialChar = specialCharRegex.IsMatch(password);



            return hasUppercase && hasSpecialChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*JPG;*PNG;*GIF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("MALE");
            comboBox1.Items.Add("FEMALE");
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f12 = new Form2();
            f12.Tag = this;
            f12.StartPosition = FormStartPosition.Manual;
            f12.Location = this.Location;
            f12.Show();
        }
    }
}

