using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p.hotel1
{
    public partial class Insertmember : Form
    {
        public static string C;
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Insertmember()
        {
            InitializeComponent();
        }

        private void Insertmember_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd4 = new SqlCommand("SELECT Roomno FROM BR WHERE Email IS NULL", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd4;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "Roomno";
            C = comboBox1.Text;
            //SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("SELECT Email FROM Registration WHERE STATUS = @email", con);
            cmd.Parameters.AddWithValue("@email","Proceeding");
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            da1.Fill(table2);
            comboBox2.DataSource = table2;
            comboBox2.DisplayMember = "Email";
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           SqlConnection con = new SqlConnection(cs);

           /*con.Open();

           string q = "SELECT Email From Registration WHERE  STATUS = @status";
           SqlCommand cmd1 = new SqlCommand(q, con);
           cmd1.Parameters.AddWithValue("@status", "Proceeding");

           cmd1.ExecuteNonQuery();

           SqlDataReader dr = cmd1.ExecuteReader();
           dr.Read();
           string W = (dr["Email"].ToString());
           con.Close();

            if (W == comboBox1.Text )
            {
              */  
                con.Open();
                string query = "UPDATE BR SET Email = @email WHERE Roomno=@room";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email",comboBox2.Text);
                cmd.Parameters.AddWithValue("@room", comboBox1.Text);
                C = comboBox1.Text;    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted.");
                con.Close();

                con.Open() ;
                string quer = "UPDATE Registration SET STATUS = @status WHERE Email = @email";
                SqlCommand cmd2 = new SqlCommand(quer, con);
                  cmd2.Parameters.AddWithValue("@email", comboBox2.Text);
            cmd2.Parameters.AddWithValue("@status", "Accepted");
              
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Status changed.");
                con.Close();
               con.Open();
            string queri = "INSERT INTO PAYMENT1(Email,JOINDATE) VALUES(@email,GETDATE())";
            SqlCommand cmd3 = new SqlCommand(queri, con);
            cmd3.Parameters.AddWithValue("@email", comboBox2.Text);

            cmd3.ExecuteNonQuery();
            MessageBox.Show("Status changed.");
            con.Close();


            /* }
             else
             {
                 MessageBox.Show("Invalid Email or Roomno");
             }*/
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin F79 = new Admin();
            F79.Tag = this;
            F79.StartPosition = FormStartPosition.Manual;
            F79.Location = this.Location;

            F79.Show();
        }
    }
}
