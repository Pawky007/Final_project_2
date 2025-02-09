using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using myproject;

namespace Final_project_2
{
    public partial class Faiyaz_2 : Form
    {
        bool sidebarExpand = true;
        public Faiyaz_2()
        {
            InitializeComponent();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }
        private void Faiyaz_2_Load(object sender, EventArgs e)
        {

        }

        private void menuButton_Click_1(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                // Colse the sidebar
                sidebar.Width -= 10;
                if (sidebar.Width <= 70)
                {
                    sidebar.Width = 72;
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
            else
            {
                // Expand the sidebar
                sidebar.Width += 10; // Increment ONCE

                if (sidebar.Width >= 276)
                {
                    sidebar.Width = 276;
                    sidebarTransition.Stop();
                    sidebarExpand = true;

                }

            }
        }

        private void pnTopUp_Click(object sender, EventArgs e)
        {
            Top_up_page_1 top_Up_Page_1 = new Top_up_page_1();
            top_Up_Page_1.Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void pnBuyTicket_Click(object sender, EventArgs e)
        {
            myproject.Dashboard dashboard = new myproject.Dashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pnDashboard_Click(object sender, EventArgs e)
        {

        }
    }
}
