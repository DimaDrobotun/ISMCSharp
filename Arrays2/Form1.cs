using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays2
{
    public partial class FormArrays2 : Form
    {
        double[] Array;

        public FormArrays2()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            short N;

            if (short.TryParse(textBoxN.Text, out N) && N > 0 && N < 100)
            {
                double[] StartArr = new double[N];
                dataGridViewMass.ColumnCount = 0;
                for (int i = 0; i < N; i++)
                {
                    dataGridViewMass.Columns.Add(i.ToString(), (i + 1).ToString());
                }
                buttonGenerate.Enabled = true;
                Array = StartArr;
            }
            else
            {
                MessageBox.Show("Неверно задано кличество элементов!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = Math.Round(rnd.NextDouble() * 100 - 50, 3);
                dataGridViewMass.Rows[0].Cells[i].Value = Array[i];
            }
        }

        private void dataGridViewMass_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
           bool MinTrig = false,
                BTrig = false,
                CTrig = false,
                DTrig = false;

            int MinInd = -1,
                MinAbsInd = -1,
                MaxAbsInd = -1,
                SecondPosTrig = 0,
                FirstNegInd = -1,
                SecondPosInd = -1,
                LastZeroInd = -1;

            double CellVal,
                Min = double.MaxValue,
                MaxAbs = double.MinValue,
                MinAbs = double.MaxValue,
                A = 1,
                B = 0,
                C = 0,
                D = 1;

            if (dataGridViewMass.CurrentCell != null &&
                double.TryParse(dataGridViewMass.Rows[0].
                Cells[dataGridViewMass.CurrentCell.ColumnIndex].
                Value.ToString(), out CellVal))
            {
                Array[dataGridViewMass.CurrentCell.ColumnIndex] = CellVal;
            }

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < Min)
                {
                    Min = Array[i];
                    MinInd = i;
                }

                if (Array[i] < 0 && FirstNegInd == -1) FirstNegInd = i;
                if (Array[i] >= 0 && SecondPosTrig < 2) SecondPosTrig++;
                if (SecondPosTrig == 2)
                {
                    SecondPosInd = i;
                    SecondPosTrig++;
                }

                if (Array[i] == 0) LastZeroInd = i;

                if (Math.Abs(Array[i]) > MaxAbs)
                {
                    MaxAbs = Math.Abs(Array[i]);
                    MaxAbsInd = i;
                }
                if (Math.Abs(Array[i]) < MinAbs)
                {
                    MinAbs = Math.Abs(Array[i]);
                    MinAbsInd = i;
                }
            }

            for (int i = 0; i < Array.Length; i++)
            {
                if (MinTrig) A *= Array[i];
                if (i == MinInd) MinTrig = true;

                if (FirstNegInd != -1 && SecondPosInd != -1)
                {
                    if (i == SecondPosInd && BTrig) BTrig = false;
                    if (BTrig) B += Array[i];
                    if (i == FirstNegInd) BTrig = true;
                }

                if (LastZeroInd != -1)
                {
                    if (i == LastZeroInd && CTrig) CTrig = false;
                    if (CTrig) C += Array[i];
                    if (Array[i] == 0 && C == 0) CTrig = true;
                }

                if (i == MinAbsInd && DTrig) DTrig = false;
                if (DTrig) D *= Array[i];
                if (i == MaxAbsInd) DTrig = true;
            }

            if (A == 1) A = 0;
            if (D == 1) D = 0;

            labelA_val.Text = Math.Round(A, 3).ToString();
            labelB_val.Text = B.ToString();
            labelC_val.Text = C.ToString();
            labelD_val.Text = Math.Round(D, 3).ToString();
        }

        private void labelA_Click(object sender, EventArgs e)
        {

        }
    }
}
