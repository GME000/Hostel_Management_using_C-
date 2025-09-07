using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace p.hotel1
{
    public partial class Employee : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            gridbind4();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd4 = new SqlCommand("SELECT Email FROM COMPLAIN1 WHERE COMPLAIN_STATUS='PENDING'", con);
            
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd4;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "Email";
            gridbind4();
         
            SqlCommand cmd = new SqlCommand("SELECT EID FROM EMP1 ", con);

            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            da1.Fill(table2);
            comboBox2.DataSource = table2;
            comboBox2.DisplayMember = "EID";
            SqlCommand cmd1= new SqlCommand("SELECT Roomno FROM COMPLAIN1 WHERE COMPLAIN_STATUS='PENDING' ", con);

            SqlDataAdapter da2 = new SqlDataAdapter();
            da2.SelectCommand = cmd1;
            DataTable table3 = new DataTable();
            da2.Fill(table3);
            comboBox3.DataSource = table3;
            comboBox3.DisplayMember = "Roomno";
            SqlCommand cmd6 = new SqlCommand("SELECT CID FROM COMPLAIN1 WHERE COMPLAIN_STATUS='PENDING' ", con);

            SqlDataAdapter da02 = new SqlDataAdapter();
            da02.SelectCommand = cmd6;
            DataTable table4 = new DataTable();
            da02.Fill(table4);
            comboBox4.DataSource = table4;
            comboBox4.DisplayMember = "CID";
        }
        public void gridbind4()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Complain1 WHERE COMPLAIN_STATUS = 'PENDING' ", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
           
            
            string queryy= "UPDATE COMPLAIN1 SET COMPLAIN_STATUS = @status WHERE CID=@cid ";

            SqlCommand cmd7 = new SqlCommand(queryy, con);
            cmd7.Parameters.AddWithValue("@status", textBox1.Text);
            cmd7.Parameters.AddWithValue("@cid", comboBox4.Text);


           cmd7.ExecuteNonQuery();
            con.Close();

        

         

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f1 = new Form11();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
        }
    }
}
