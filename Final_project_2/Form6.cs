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
            label3.Visible = true;
            pictureBox5.Visible = true;
        }
    }
}
