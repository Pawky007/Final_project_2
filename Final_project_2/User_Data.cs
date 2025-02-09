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
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string Email = selectedRow.Cells["Email"].Value.ToString();

                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";

                    if (rowsAffected > 0)
                    {
                        dataGridView1.Rows.Remove(selectedRow);
                        MessageBox.Show("Data deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the given Email.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No rows are selected.");
            }

        }
    }
}
