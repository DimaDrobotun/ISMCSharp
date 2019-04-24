using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, x = 0, y = 0;

            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out x))
                {
                y = 2.4 * (Math.Abs(Math.Pow(x, 2) + b) / a) + (a - b) * Math.Pow(Math.Sin(1), 2) * (a - b) + Math.Pow(10, -2) * (x - b);
                textBox4.Text = y.ToString();
            }
            else
            {
                textBox4.Text = "Error";
            }
        }
    }
}
