using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_project_2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(customTextBox2.Text))
            {
                MessageBox.Show("Please Enter Your Email!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrWhiteSpace(customTextBox1.Text))
            {
                MessageBox.Show("Please Enter Your Password!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(customTextBox1.Text == "admin" && customTextBox2.Text == "admin")
            {
                Admin_Panel admin_Panel = new Admin_Panel();
                admin_Panel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }
    }
}
