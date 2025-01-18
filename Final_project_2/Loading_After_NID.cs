using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.TimeZoneInfo;

namespace Final_project_2
{
    public partial class Loading_After_NID : Form
    {
        private Timer timer;

        public Loading_After_NID()
        {
            InitializeComponent();


            timer = new Timer();
            timer.Interval = 6000; 
            timer.Tick += Timer_Tick;

            pictureBox2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        }

        private void Loading_After_NID_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            Timer delayTimer = new Timer();
            delayTimer.Interval = 2500;
            delayTimer.Tick += (s, args) =>
            {
                delayTimer.Stop();
                Form3 form3 = new Form3(); 
                form3.Show();
                this.Hide();
            };
            delayTimer.Start();
        }
    }
}

