using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Final_project_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            customTextBox2.Focus();
        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text Changed");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customTextBox2.Text))
             {
                 MessageBox.Show("USER NID IS NOT FILLED!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 label1.Text = "Enter User NID Number";

             }
             else if (!long.TryParse(customTextBox2.Text, out _) || customTextBox2.Text.Length != 10)
             {
                 MessageBox.Show("NID Number Is Not Correct Or Incorrect Type!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 label1.Text = "Enter Valid NID Number";
             }
             else
             {
                string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "INSERT INTO User_NID (User_NID) VALUES (@value)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@value", Convert.ToInt32(customTextBox2.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                Loading_After_NID form3 = new Loading_After_NID();
                form3.Show();
                this.Hide();
                label5.Text = "";
             }
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
          
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox2__TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel admin_Panel = new AdminPanel();
            admin_Panel.Show();
            this.Hide();
        }
    }
}
