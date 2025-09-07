using FontAwesome.Sharp;
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
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace p.hotel1
{
    public partial class Admin : Form
    {
       
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public Admin()
        {
            InitializeComponent();
            BindData();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'modelDataSet4.PAYMENT1' table. You can move, or remove it, as needed.
            this.pAYMENT1TableAdapter.Fill(this.modelDataSet4.PAYMENT1);
            // TODO: This line of code loads data into the 'modelDataSet3.LVAPP' table. You can move, or remove it, as needed.
            //this.lVAPPTableAdapter.Fill(this.modelDataSet3.LVAPP);
            gridbind();
            gridbind2();
            gridbind3();
           // gridbind4();
            gridbind5();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd8 = new SqlCommand("SELECT Email FROM LVAPP WHERE Status='Pending'", con);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd8;
            DataTable table1 = new DataTable();
            da.Fill(table1);
            comboBox1.DataSource = table1;
            comboBox1.DisplayMember = "Email";
            comboBox2.Items.Add("Accept");
            comboBox2.Items.Add("Reject");
            

        }
        void BindData()
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM LVAPP;", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView4.DataSource = dt;
            con.Close();



            /*con.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("SELECT * FROM N;", con);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dataGridView2.DataSource = dt3;*/
        }
        public void gridbind()
        {
            using (SqlConnection con = new SqlConnection(cs)) 
            { 
            con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BR WHERE Email IS NULL", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView2.DataSource = dt;
                con.Close();
            }
        }
        public void gridbind2()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BR WHERE Email IS NOT NULL", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        public void gridbind3()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Registration WHERE STATUS ='Proceeding' ", con);
               
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView3.DataSource = dt;
                con.Close();
            }
        }
        public void gridbind4()
        {
            /*using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM BR  ", con);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView4.DataSource = dt;
                con.Close();
            }*/
        }
        public void gridbind5()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Registration", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView5.DataSource = dt;
                con.Close();
            }
        }
        private void panellogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSideMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
               
              


               
            }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /*SqlConnection con = new SqlConnection(cs);
           
            con.Open();

            string q = "SELECT Email From Registration WHERE  STATUS = @status";
            SqlCommand cmd1 = new SqlCommand(q, con);
            cmd1.Parameters.AddWithValue("@status", "Proceeding");
           
            cmd1.ExecuteNonQuery();

            SqlDataReader dr = cmd1.ExecuteReader();
            dr.Read();
            string W = (dr["Email"].ToString());
            con.Close();*/
           
            /*if (W == textBox1.Text )
            {
                
                con.Open();
                string query = "UPDATE BR SET Email = @email WHERE Roomno=@room";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", textBox1.Text);
                cmd.Parameters.AddWithValue("@room", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully Inserted.");
                con.Close();

                con.Open() ;
                string quer = "UPDATE Registration SET STATUS = @status WHERE STATUS = 'Proceeding'";
                SqlCommand cmd2 = new SqlCommand(quer, con);
                cmd2.Parameters.AddWithValue("@status", "Accepted");
              
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Status changed.");
                con.Close();


            }
            else
            {
                MessageBox.Show("Invalid Email or Roomno");
            }*/
        }

       
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
            
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();

            Insertmember F79 = new  Insertmember();

            F79.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rejectrequest F79 = new Rejectrequest();
            F79.Tag = this;
            F79.StartPosition = FormStartPosition.Manual;
            F79.Location = this.Location;

            F79.Show();
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE LVAPP SET Status=@Status WHERE Email = @email;", con);
            cmd.Parameters.AddWithValue("@email", comboBox1.Text);
            cmd.Parameters.AddWithValue("@Status", comboBox2.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            BindData();
            MessageBox.Show("Updated");
        }

        private void tabPage6_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11();  
            f11.Show();
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
    }
    }

