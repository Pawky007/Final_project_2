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
    
    public partial class Top_Up_page_for_employe_and_Admin : Form
    {
        bool sidebarExpanded;
        bool peopleCollapsed;
        bool deleteCollapsed;

        public Top_Up_page_for_employe_and_Admin()
        {
            InitializeComponent();
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            /*if (sidebartimer)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebartimer.Stop();
                    sidebartimer = false;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebartimer.Stop();
                    sidebartimer = true;
                }
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            People_timer.Start();
        }

        private void People_timer_Tick(object sender, EventArgs e)
        {
            if (peopleCollapsed)
            {
                UserContainer.Height += 10;
                if (UserContainer.Height == UserContainer.MaximumSize.Height)
                {
                    People_timer.Stop();
                    peopleCollapsed = false;
                }
            }
            else
            {
                UserContainer.Height -= 10;
                if (UserContainer.Height == UserContainer.MinimumSize.Height)
                {
                    People_timer.Stop();
                    peopleCollapsed = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "SELECT USER_NID FROM User_NID WHERE USER_NID = @value";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@value", Convert.ToInt32(customTextBox1.Text));
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    pictureBox7.Visible = true;
                    pictureBox9.Visible = false;

                    Timer timer = new Timer();
                    timer.Interval = 2000;
                    timer.Tick += (s, args) =>
                    {
                        timer.Stop();
                        pictureBox7.Visible = false;
                        pictureBox9.Visible = false;
                    };
                    timer.Start();
                }
                pictureBox8.Visible = true;
            }
            else
            {
                MessageBox.Show("No data found.");
                pictureBox9.Visible = true;
            }
            reader.Close();
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DateTime dateTime1 = DateTime.Now;
            string connectionString = @"Data Source=ABRARLAPTOP\SQLEXPRESS;Initial Catalog=TapNgo Metro Service;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "INSERT INTO Recharge (Email, Recharge_Amount, Payment_Type, Recharge_time) VALUES (@Email, @Recharge_Amount, @Payment_Type, @Recharge_time)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Email", customTextBox1.Text);
            cmd.Parameters.AddWithValue("@Recharge_Amount", customTextBox2.Text);
            cmd.Parameters.AddWithValue("@Payment_Type", "Offline");
            cmd.Parameters.AddWithValue("@Recharge_time", dateTime1);
            cmd.ExecuteNonQuery();
            con.Close();

            AdminPanel adminPanel = new AdminPanel();
            adminPanel.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            delete_timer.Start();
        }

        private void delete_timer_Tick(object sender, EventArgs e)
        {
            if (deleteCollapsed)
            {
                deleteContainer.Height += 10;
                if (deleteContainer.Height == deleteContainer.MaximumSize.Height)
                {
                    delete_timer.Stop();
                    deleteCollapsed = false;
                }
            }
            else
            {
                deleteContainer.Height -= 10;
                if (deleteContainer.Height == deleteContainer.MinimumSize.Height)
                {
                    delete_timer.Stop();
                    deleteCollapsed = true;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            User_Data user_Data = new User_Data();
            user_Data.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Update_Employe update_Employe = new Update_Employe();
            update_Employe.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 ww = new Form5();
            ww.Show();
            ww.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top_Up_page_for_employe_and_Admin ww = new Top_Up_page_for_employe_and_Admin();
            ww.Show();
            ww.Hide();
        }
    }
}
