using FontAwesome.Sharp;
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
    public partial class Rejectrequest : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Rejectrequest()
        {
            InitializeComponent();
        }

        private void Rejectrequest_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
           
            SqlCommand cmd = new SqlCommand("SELECT Email FROM Registration WHERE STATUS = @email", con);
            cmd.Parameters.AddWithValue("@email", "Proceeding");
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand = cmd;
            DataTable table2 = new DataTable();
            da1.Fill(table2);
            comboBox1.DataSource = table2;
            comboBox1.DisplayMember = "Email";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            string query = "UPDATE Registration SET STATUS=@status WHERE Email = @email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@status", "Rejected");
            cmd.Parameters.AddWithValue("@email", comboBox1.Text);
         
            cmd.ExecuteNonQuery();
            MessageBox.Show("Done", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

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
