using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int mas = Convert.ToInt32(textBox1.Text);
                double[] array = new double[mas];

                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Math.Round((rnd.NextDouble() * 100) - 50, 3);
                }

                listBox1.Items.Clear();

                for (int i = 0; i < array.Length; i++)
                {
                    listBox1.Items.Insert(i, "array[" + i + "]=" + array[i]);
                }
                double sumvid = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        sumvid += array[i];
                    }
                }
                textBox2.Text = Convert.ToString(sumvid);

                double maxelem = 0;
                int maxindex = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > maxelem)
                    {
                        maxelem = array[i];
                        maxindex = i;
                    }
                }
                textBox3.Text = Convert.ToString(maxelem);
                textBox4.Text = Convert.ToString(maxindex);

                double maxmod = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (Math.Abs(array[i]) > maxelem)
                    {
                        maxmod = array[i];
                    }
                }
                textBox5.Text = Convert.ToString(maxmod);

                int sumid = 0;
                for (int i= 0; i < array.Length; i++)
                {
                    if(array[i]>0)
                    {
                        sumid += i;
                    }
                }
                textBox6.Text = Convert.ToString(sumid);

                int chisla = 0;
                for(int i=0;i<array.Length;i++)
                {
                    if(array[i]%1==0)
                    {
                        chisla++;
                    }
                }
                textBox7.Text = Convert.ToString(chisla);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
   