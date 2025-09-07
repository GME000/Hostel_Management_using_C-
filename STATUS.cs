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
using System.Windows.Controls;
using System.Windows.Forms;


namespace p.hotel1
{
    public partial class STATUS : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public STATUS()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            gridbind4();
            label3.Text = "Email :      " + Form11.B;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
        public void gridbind4()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
              
                string query = "SELECT STATUS FROM  Registration WHERE Email = @email ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", Form11.B);


                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
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
