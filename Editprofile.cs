using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace p.hotel1
{
    public partial class Editprofile : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public Editprofile()
        {
            InitializeComponent();
        }

        private void Editprofile_Load(object sender, EventArgs e)
        {
            label1.Text = "Email:     " + Form11.B;
        }
       



       /* private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }
       */





        private void label3_Click(object sender, EventArgs e)
        {



        }







       /* private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            Image i = pictureBox1.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConverter = Converter.ConvertTo(i, typeof(byte[]));

            con.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Registration SET Image = @E1 WHERE eMAIL = @E2", con);
            cmd.Parameters.AddWithValue("@E1", ImageConverter);
            cmd.Parameters.AddWithValue("@E2", Form11.B);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Image Updated");
        }
       */


        private void label1_Click(object sender, EventArgs e)
        {



        }



      /*  private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); con.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Registration SET Email = @E1 WHERE Email = @E2", con);
            cmd.Parameters.AddWithValue("@E1", textBox1.Text);
            cmd.Parameters.AddWithValue("@E2", Form11.B);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("UPDATE Login SET Email = @E1 WHERE Email = @E2", con);
            cmd2.Parameters.AddWithValue("@E1", textBox1.Text);
            cmd2.Parameters.AddWithValue("@E2", Form11.B);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Email Updated");
        }
      */


       /* private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); con.Open();
            con.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Registration SET Phone = @E1 WHERE Phone = @E2", con);
            cmd.Parameters.AddWithValue("@E1", textBox2.Text);
            cmd.Parameters.AddWithValue("@E2", Form11.B);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Phone No. Updated");
        }
       */


        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            UHOME f8 = new  UHOME();
            f8.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); con.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Registration SET Email = @E1 WHERE Email = @E2", con);
            cmd.Parameters.AddWithValue("@E1", textBox1.Text);
            cmd.Parameters.AddWithValue("@E2", Form11.B);
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            SqlCommand cmd2 = new SqlCommand("UPDATE Registration02 SET Email = @E1 WHERE Email = @E2", con);
            cmd2.Parameters.AddWithValue("@E1", textBox1.Text);
            cmd2.Parameters.AddWithValue("@E2", Form11.B);
            cmd2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Email Updated");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open Image";
            openFileDialog.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            Image i = pictureBox1.Image;
            ImageConverter Converter = new ImageConverter();
            var ImageConverter = Converter.ConvertTo(i, typeof(byte[]));

            con.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Registration SET Image = @E1 WHERE eMAIL = @E2", con);
            cmd.Parameters.AddWithValue("@E1", ImageConverter);
            cmd.Parameters.AddWithValue("@E2", Form11.B);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Image Updated");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs); 
            con.Open();



            SqlCommand cmd = new SqlCommand("UPDATE Registration SET Phone = @E1 WHERE Phone = @E2", con);
            cmd.Parameters.AddWithValue("@E1", textBox2.Text);
            cmd.Parameters.AddWithValue("@E2", Form11.B);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Phone No. Updated");
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            this.Hide();
            Form11 f1 = new Form11();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            UHOME f1 = new UHOME();
            f1.Tag = this;
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = this.Location;
            f1.Show();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
