using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p.hotel1
{
    public partial class Mealmanager : Form
    {


        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Mealmanager()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void gridbind()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM MEAL1 ", con);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }


        }
        private void Mealmanager_Load(object sender, EventArgs e)
        {
            gridbind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Breakfast")
            {

                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "UPDATE MEAL1 SET Breakfast = @bf  WHERE Day=@day";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@day", comboBox1.Text);
                cmd.Parameters.AddWithValue("@bf", textBox1.Text);
                //cmd.Parameters.AddWithValue("@ln", textBox2.Text);

                //cmd.Parameters.AddWithValue("@dn",textBox3);
                MessageBox.Show("Menu Updated.", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);




                cmd.ExecuteNonQuery();
                con.Close();


            }
            else if (comboBox2.Text == "Lunch")
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "UPDATE MEAL1 SET Lunch = @ln  WHERE Day=@day";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@day", comboBox1.Text);
                //cmd.Parameters.AddWithValue("@bf", textBox1.Text);
                cmd.Parameters.AddWithValue("@ln", textBox2.Text);

                //cmd.Parameters.AddWithValue("@dn",textBox3);
                MessageBox.Show("Menu Updated.", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);




                cmd.ExecuteNonQuery();
                con.Close();

            }
            else if (comboBox2.Text == "Dinner")
            {
                SqlConnection con = new SqlConnection(cs);
                con.Open();
                string query = "UPDATE MEAL1 SET Dinner = @dn  WHERE Day=@day";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@day", comboBox1.Text);
                //cmd.Parameters.AddWithValue("@bf", textBox1.Text);
                //cmd.Parameters.AddWithValue("@ln", textBox2.Text);

                cmd.Parameters.AddWithValue("@dn", textBox3);
                MessageBox.Show("Menu Updated.", "Wait", MessageBoxButtons.OK, MessageBoxIcon.Information);




                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

            private void Mealmanager_Load_1(object sender, EventArgs e)
            {
                // TODO: This line of code loads data into the 'modelDataSet2.MEAL1' table. You can move, or remove it, as needed.
                this.mEAL1TableAdapter.Fill(this.modelDataSet2.MEAL1);

                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd4 = new SqlCommand("SELECT Day FROM MEAL1 ", con);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd4;
                DataTable table1 = new DataTable();
                da.Fill(table1);
                comboBox1.DataSource = table1;
                comboBox1.DisplayMember = "Day";



                comboBox2.Items.Add("Breakfast");
                comboBox2.Items.Add("Lunch");
                comboBox2.Items.Add("Dinner");
                this.Controls.Add(comboBox2);


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

