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
    public partial class AdminPanel : Form
    {
        bool sidebarExpanded;
        bool peopleCollapsed;
        bool deleteCollapsed;
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void sidebarTimer_click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebartimer.Stop();
                    sidebarExpanded = false;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebartimer.Stop();
                    sidebarExpanded = true;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
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
        private void button2_Click(object sender, EventArgs e)
        {
            People_timer.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Top_Up_page_for_employe_and_Admin f5 = new Top_Up_page_for_employe_and_Admin();
            f5.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Employe_Adding employe_Adding = new Employe_Adding();
            employe_Adding.Show();
            this.Hide();
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

        private void button10_Click(object sender, EventArgs e)
        {
            delete_timer.Start();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            User_Data user_Data = new User_Data();
            user_Data.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Update_Employe update_Employe = new Update_Employe();
            update_Employe.Show();
            this.Hide();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }
    }
}

        