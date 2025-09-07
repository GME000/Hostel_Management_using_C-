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

namespace p.hotel1
{
    public partial class Form10 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {



            if ((textBox1.Text != "" && textBox2.Text != "")&&(textBox1.Text==textBox2.Text))
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "INSERT INTO Registration02(Email,Password,Repassword) VALUES(@email,@bn,@bn)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@email",Form9.H);
                cmd.Parameters.AddWithValue("@bn", textBox2.Text);
                cmd.Parameters.AddWithValue("@gn", textBox2.Text);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Inserted");

                this.Hide();
                Form11 F2 = new Form11();
                F2.Show();

            }
            else
            {
                MessageBox.Show("Password doesn't match.");

            }
            this.Hide();

            Form11 F31 = new Form11();

            F31.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f1 = new Form9();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
        }
    }
}
