using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p.hotel1
{
    public partial class Form8 : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Form8()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "UPDATE Registration SET STATUS = @status WHERE Email=@email";
           
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", "Proceeding");
            cmd.Parameters.AddWithValue("@email", Form11.B);



            cmd.ExecuteNonQuery();
            con.Close();
            
            this.Hide();

            Form  F79 = new Form();

            F79.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form7 F87 = new Form7();

            F87.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            label1.Text = "Email :      " + Form11.B;
        }
    }
}
