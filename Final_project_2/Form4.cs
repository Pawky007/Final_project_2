using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
                AdminPanel admin_Panel = new AdminPanel();
                admin_Panel.Show();
                this.Hide();
            }
            else
            {
                string connection = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                string query = "SELECT Email, Password FROM Employe_Information WHERE Email = '" + customTextBox2.Text + "' AND Password = '" + customTextBox1.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MessageBox.Show("Successfully Log In!!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Employe_panel top_Up_Page = new Employe_panel();
                        top_Up_Page.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Email Or Password Or Contact The Admin Office!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
