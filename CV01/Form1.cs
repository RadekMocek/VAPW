using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CV01
{
    public partial class Form1 : Form
    {
        private readonly int arrayLen = 20;
        private readonly int maxValue = 10;

        Random random;
        private int[] array;
        private string arrayToString;
        private int[] occurences;

        public Form1()
        {
            InitializeComponent();

            random = new Random();
            array = new int[arrayLen];

            FillArray();
        }

        private void BtnFill_Click(object sender, EventArgs e)
        {
            FillArray();
        }

        private void BtnModus_Click(object sender, EventArgs e)
        {
            occurences = new int[maxValue + 1];

            for (int i = 0; i < arrayLen; i++) {
                occurences[array[i]]++;
            }

            int times = occurences.Max();
            int value = Array.IndexOf(occurences, times);

            LblModus.Text = $"Value {value} is present {times} times.";
        }

        private void FillArray()
        {
            arrayToString = "";

            for (int i = 0; i < arrayLen; i++) {
                int temp = random.Next(1, maxValue + 1);
                array[i] = temp;
                arrayToString += temp + ((i == arrayLen - 1) ? string.Empty : ", ");
            }

            LblArray.Text = arrayToString;
        }
    }
}
