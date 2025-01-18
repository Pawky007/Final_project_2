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
using System.Windows.Media.Animation;

namespace Final_project_2
{
    public partial class Form3 : Form
    {

        int age;
        public Form3()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            label1.Visible = false;
            label4.Visible = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dateTime = dateTimePicker1.Value;
            DateTime dateTime1 = DateTime.Now;
            age = dateTime1.Year - dateTime.Year;
            if (string.IsNullOrWhiteSpace(customTextBox1.Text) || string.IsNullOrWhiteSpace(customTextBox2.Text) || string.IsNullOrWhiteSpace(customTextBox3.Text) || string.IsNullOrWhiteSpace(customTextBox4.Text))
            {
                MessageBox.Show("Please Enter Your All Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label5.Text = "Enter Your Email";
                label6.Text = "Phone Number Is Empty";
                label7.Text = "Please Enter Your Password";
                label8.Text = "Please Confirm Your Password";
                if (age < 15)
                {
                    label9.Text = "NOT ELIGIBLE!!! Under Age.";
                }
                else
                {
                    label9.Text = "Date Of Birth IS Empty.";
                }

            }
            else if(customTextBox3.Text != customTextBox4.Text )
            {
                MessageBox.Show("Password Does Not Match!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(customTextBox2.Text.Length != 11)
            {
                MessageBox.Show("Phone Number Is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label6.Text = "Phone Number Is Not Correct";
            }
            else if(!customTextBox2.Text.StartsWith("01"))
            {
                MessageBox.Show("Phone Number Must Start With 01", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label6.Text = "Phone Number Must Start With 01";
            }
            else if(!customTextBox1.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Email Type Is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                label5.Text = "Incorrect Email Type!!!!";
            }
            else
            {
                if (age < 15)
                {
                    label9.Text = "NOT ELIGIBLE!!! Under Age.";
                    label5.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label8.Text = "";
                    MessageBox.Show("NOT ELIGIBLE!!! Age Is Under 15.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        con.Open();
                        string query = "INSERT INTO User_Information (Email, Phone_Number, Password, Date_Of_Birth) VALUES (@Email, @Phone, @Password, @DOB)";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@Email", customTextBox1.Text);
                            cmd.Parameters.AddWithValue("@Phone", customTextBox2.Text);
                            cmd.Parameters.AddWithValue("@Password", customTextBox3.Text);
                            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
                            cmd.ExecuteNonQuery();
                        }
                    }


                    customTextBox1.Visible = false;
                    customTextBox2.Visible = false;
                    customTextBox3.Visible = false;
                    customTextBox4.Visible = false;
                    pictureBox2.Visible = false;
                    pictureBox8.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox6.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox9.Visible = false;
                    label2.Visible = false;
                    dateTimePicker1.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    pictureBox4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                    label8.Visible = false;
                    label9.Visible = false;

                    //pictureBox3.Image = Image.FromFile("C:\\Users\\abrar\\Downloads\\verified.gif");
                    pictureBox3.Visible = true;
                    label1.Visible = true;
                    label4.Visible = true;

                    Timer timer = new Timer();
                    timer.Interval = 3000;
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        pictureBox3.Visible = false;
                        Form4 form = new Form4();
                        form.Show();
                        this.Hide();
                    };
                    timer.Start();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
