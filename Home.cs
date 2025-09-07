using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p.hotel1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form11 F3 = new Form11();
            F3.Tag = this;
            F3.StartPosition = FormStartPosition.Manual;
            F3.Location = this.Location;

            F3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form4 F2 = new Form4();
            F2.Tag = this;
            F2.StartPosition = FormStartPosition.Manual;
            F2.Location = this.Location;

            F2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Contact F2 = new Contact();
            F2.Tag = this;
            F2.StartPosition = FormStartPosition.Manual;
            F2.Location = this.Location;
            F2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 F6 = new Form6(); 
            F6.Tag = this;  
            F6.StartPosition = FormStartPosition.Manual;
            F6.Location = this.Location;
            F6.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            facilities F2 = new facilities();
            F2.Tag = this;
            F2.StartPosition = FormStartPosition.Manual;
            F2.Location = this.Location;

            F2.Show();
        }
    }
}
