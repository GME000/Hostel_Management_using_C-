using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p.hotel1
{
    public partial class Form5 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form5()
        {
            InitializeComponent();
        }
        static bool IsStrongPassword(string password)
        {

            Regex uppercaseRegex = new Regex(@"[A-Z]");
            Regex specialCharRegex = new Regex(@"[!@#$%^&*()_+{}\[\]:;<>,.?~]");




            bool hasUppercase = uppercaseRegex.IsMatch(password);
            bool hasSpecialChar = specialCharRegex.IsMatch(password);



            return hasUppercase && hasSpecialChar;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string p = textBox2.Text;
            if (p.Length > 7 && IsStrongPassword(p))
            {
                if (textBox2.Text == textBox3.Text)
                {
                    SqlConnection con = new SqlConnection(cs);
                    con.Open();
                    string query = "INSERT INTO Registration02(Email,Password,Repassword) VALUES(@user,@bn,@gn)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@user", Form4.J);
                    cmd.Parameters.AddWithValue("@bn", textBox2.Text);
                    cmd.Parameters.AddWithValue("@gn", textBox3.Text);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Inserted");

                    this.Hide();
                    Form11 F2 = new Form11();
                    F2.Tag = this;
                    F2.StartPosition = FormStartPosition.Manual;
                    F2.Location = this.Location;
                    F2.Show();

                }
            }
            else
            {
                MessageBox.Show("Password doesn't match.");

            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "Email :      " + Form4.J;
                
                
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f41 = new Form4();
            f41.Tag = this;
            f41.StartPosition = FormStartPosition.Manual;
            f41.Location = this.Location;
            f41.Show();
        }
    }
}
