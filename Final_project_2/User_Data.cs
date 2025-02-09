using Final_project_2.Custom;
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
    public partial class User_Data : Form
    {
        public User_Data()
        {
            InitializeComponent();

        }

        private void User_Data_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tapNgo_Metro_ServiceDataSet.User_Information' table. You can move, or remove it, as needed.
            this.user_InformationTableAdapter.Fill(this.tapNgo_Metro_ServiceDataSet.User_Information);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminPanel admin_Panel = new AdminPanel();
            admin_Panel.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        string Email;
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customTextBox2.Text))
            {
                MessageBox.Show("USER NID IS NOT FILLED!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[0];
                Email = row.Cells[0].Value.ToString();

                string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string query = "DELETE FROM User_Information WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("User Delete Successfully" ,"Error", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
                AdminPanel admin = new AdminPanel();
                admin.Show();
                this.Hide();
            }

        }
    }
}
