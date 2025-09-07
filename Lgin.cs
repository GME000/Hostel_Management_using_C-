using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace p.hotel1
{
    public partial class Form11 : Form
    {
        public static string B;
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "12345" && textBox2.Text == "mm12345")
            {
                

                Mealmanager F79 = new Mealmanager();
                F79.Tag = this;
                F79.StartPosition = FormStartPosition.Manual;
                F79.Location = this.Location;
                F79.Show();
            }
            else if (textBox1.Text=="1234"&&textBox2.Text=="emp1234")
            {
                this.Hide();

                Employee F79 = new Employee();
                F79.Tag = this;
                F79.StartPosition = FormStartPosition.Manual;
                F79.Location = this.Location;

                F79.Show();
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM Registration02 where Email = @user and Password = @pass";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@user", textBox1.Text);
                cmd.Parameters.AddWithValue("@pass", textBox2.Text);

                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                B = textBox1.Text;
                if (dr.HasRows == true)
                {
                    
                    MessageBox.Show("User Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    UHOME F79 = new UHOME();
                    F79.Tag = this;
                    F79.StartPosition = FormStartPosition.Manual;
                    F79.Location = this.Location;

                    F79.Show();


                }

                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();



            }





            else
            {

                MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form9 F9 = new Form9();

            F9.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void Form11_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
              if (textBox1.Text != "" && textBox2.Text != "")
            {
                SqlConnection cop = new SqlConnection(cs);
                string query = "SELECT * FROM ADMIN where Email = @auser and Password = @apass";
                SqlCommand cmd = new SqlCommand(query, cop);
                cmd.Parameters.AddWithValue("@auser", textBox1.Text);
                cmd.Parameters.AddWithValue("@apass", textBox2.Text);

                cop.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {

                    MessageBox.Show("Admin Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();

                    Admin F77 = new Admin(); 
                    F77.Tag = this;
                    F77.StartPosition = FormStartPosition.Manual;
                    F77.Location = this.Location;

                    F77.Show();


                }


                else
                {
                    MessageBox.Show("Login Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                cop.Close();
            }


            else
            {

                MessageBox.Show("Enter Fields", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form9 v9 = new Form9();
            v9.Tag = this;
            v9.StartPosition = FormStartPosition.Manual;
            v9.Location = this.Location;
            v9.Show();
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar= true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f1 = new Form2();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
        }
    }
        }
    

