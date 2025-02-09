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
    public partial class loading_after_payment : Form
    {
        public loading_after_payment()
        {
            InitializeComponent();
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, args) =>
            {
                timer.Stop();
                AdminPanel form = new AdminPanel();
                form.Show();
                this.Hide();
            };
            timer.Start();
        }

      
    }
}
