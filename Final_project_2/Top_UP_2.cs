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
    public partial class Top_UP_2 : Form
    {
        public Top_UP_2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customTextBox1.Text) || string.IsNullOrWhiteSpace(customTextBox2.Text) || string.IsNullOrWhiteSpace(customTextBox3.Text) || string.IsNullOrWhiteSpace(customTextBox4.Text) || string.IsNullOrWhiteSpace(customTextBox5.Text) || string.IsNullOrWhiteSpace(customTextBox6.Text) || string.IsNullOrWhiteSpace(customTextBox7.Text))
            {
                MessageBox.Show("Please FillUP all the Field", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                DateTime dateTime1 = DateTime.Now;
                string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                string query = "INSERT INTO Recharge (Email, Recharge_Amount, Card_Name, Card_Number, Expair_Date, Expair_Year, Card_CCV, Payment_Type, Recharge_Time) VALUES (@Email, @Recharge_Amount, @Card_Name, @Card_Number, @Expair_Date, @Expair_Year, @Card_CCV, @Payment_Type, @Recharge_time)";
                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@Email", customTextBox7.Text);
                cmd.Parameters.AddWithValue("@Recharge_Amount", customTextBox6.Text);
                cmd.Parameters.AddWithValue("@Card_Name", customTextBox1.Text);
                cmd.Parameters.AddWithValue("@Card_Number", customTextBox2.Text);
                cmd.Parameters.AddWithValue("@Expair_Date", customTextBox5.Text);
                cmd.Parameters.AddWithValue("@Expair_Year", customTextBox4.Text);
                cmd.Parameters.AddWithValue("@Card_CCV", customTextBox3.Text);
                cmd.Parameters.AddWithValue("@Payment_Type", "Card Payment");
                cmd.Parameters.AddWithValue("@Recharge_time", dateTime1);
                cmd.ExecuteNonQuery();
                con.Close();


                loading_after_payment form = new loading_after_payment();
                form.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top_up_page_1 form = new Top_up_page_1();
            form.Show();
            this.Hide();
        }
    }
}
