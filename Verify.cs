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
    public partial class Form9 : Form
    {
        public static string G = "19909";
        public static string H;
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form9()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM Registration where Email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@email", textBox1.Text);
          
            H=textBox1.Text;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == true && G==textBox2.Text)
            {

                

                this.Hide();

                Form10 F77 = new Form10();

                F77.Show();


            }


            else
            {
                MessageBox.Show("Invalid information", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
           con.Close();


        }

            
            
            
           

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form11 F32 = new Form11();

            F32.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("YOUR OTP is 19909 ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
