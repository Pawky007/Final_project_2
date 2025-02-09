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
    public partial class Top_up_page_1 : Form
    {
        public Top_up_page_1()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(customTextBox1.Text) || string.IsNullOrWhiteSpace(customTextBox2.Text) || string.IsNullOrWhiteSpace(customTextBox3.Text) || string.IsNullOrWhiteSpace(customTextBox4.Text))
            {
                MessageBox.Show("Please FillUP all the Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DateTime dateTime1 = DateTime.Now;

                string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "INSERT INTO Recharge (Email, Recharge_Amount, Account_Number,Payment_Type, Recharge_time) VALUES (@Email, @Recharge_Amount, @Account_Number, @Payment_Type, @Recharge_time)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", customTextBox4.Text);
                cmd.Parameters.AddWithValue("@Recharge_Amount", customTextBox3.Text);
                cmd.Parameters.AddWithValue("@Account_Number", customTextBox1.Text);
                cmd.Parameters.AddWithValue("@Payment_Type", "Mobile Banking");
                cmd.Parameters.AddWithValue("@Recharge_time", dateTime1);
                cmd.ExecuteNonQuery();
                con.Close();


                loading_after_payment form = new loading_after_payment();
                form.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Top_UP_2 form = new Top_UP_2();
            form.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Faiyaz_2 form = new Faiyaz_2();
            form.Show();
            this.Hide();
        }
    }
}
