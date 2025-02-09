using QRCoder;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            pictureBox3.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            pictureBox5.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(customTextBox1.Text))
            {
                MessageBox.Show("Please Enter Your Number!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
                QRCodeData data = qrGenerator.CreateQrCode(customTextBox1.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(data);
                pictureBox3.Image = qrCode.GetGraphic(50);
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox2.Visible = false;
                button1.Visible = false;
                customTextBox1.Visible = false;
                label1.Visible = false;
                label2.Visible = true;
                label4.Visible = false;
                linkLabel1.Visible = false;
                label3.Visible = true;
                pictureBox5.Visible = true;

                Timer timer = new Timer();
                timer.Interval = 2000;
                timer.Tick += (s, args) =>
                {
                    timer.Stop();
                    Faiyaz_2 form = new Faiyaz_2();
                    form.Show();
                    this.Hide();
                };
                timer.Start();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void customTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
             
        }
    }
}
