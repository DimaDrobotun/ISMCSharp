using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadEquationWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            if (double.TryParse(textBox1.Text, out a) && double.TryParse(textBox2.Text, out b) && double.TryParse(textBox3.Text, out c))
            {
                double D = b * b - 4 * a * c;
                textBox4.Text = D.ToString();
                if(D>0)
                {
                    double x1 = (-b + Math.Sqrt(D)) / 2 * a;
                    double x2 = (-b - Math.Sqrt(D)) / 2 * a;
                    label5.Visible = true;
                    label6.Visible = true;
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                    textBox5.Text = x1.ToString();
                    textBox6.Text = x2.ToString();
                }
                if(D==0)
                {
                    double x = (-b) / 2 * a;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    textBox5.Text = x.ToString();
                    label6.Visible = false;
                    textBox6.Visible = false;
                }
                if(D<0)
                {
                    label4.Visible = false;
                    label5.Visible = false;
                    label6.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    textBox6.Visible = false;
                    MessageBox.Show("Дискриминант не має розвязкив");
                }
            }
            else
            {
                textBox4.Text = "Error";
            }
        }
    }
}
