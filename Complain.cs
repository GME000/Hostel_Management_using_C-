using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace p.hotel1
{
    public partial class Complain : Form
    {
        
        public static string K;
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Complain()
        {
            InitializeComponent();
        }

        private void Complain_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd4 = new SqlCommand("SELECT Roomno FROM BR WHERE Email=@email", con);
            cmd4.Parameters.AddWithValue("@email", Form11.B);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd4;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "Roomno";
            K = comboBox1.Text;
          
        }




        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) AS COUNT FROM BR WHERE Email = @email", con);
            cmd1.Parameters.AddWithValue("@email", Form11.B);
            cmd1.ExecuteNonQuery();
            SqlDataReader q = cmd1.ExecuteReader();
            q.Read();
            string S = (q["COUNT"].ToString());
            int COUNT = int.Parse(S);
            if (COUNT==1)
            {
                con.Close();
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO COMPLAIN1(Email,COMPLAIN_DATE,COMPLAIN,Roomno) VALUES(@email,GetDate(),@complain,@roomno) ", con);

                cmd.Parameters.AddWithValue("@email",Form11.B);
               
                cmd.Parameters.AddWithValue("@complain", textBox1.Text);
                cmd.Parameters.AddWithValue("@roomno",comboBox1.Text);

                
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your problem has been noted");


            }
            else
            {
                MessageBox.Show("Sorry,give correct informatiin ");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            UHOME f1 = new UHOME();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
           
            f1.Show();
        }
    }
}
