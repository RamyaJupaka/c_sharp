﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_csharp
{
    public partial class CALC : Form
    {
        public CALC()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";

        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

       

        private void button17_Click(object sender, EventArgs e)
        {
            byte button17_result = 0;
            button17_result = Convert.ToByte(
            MessageBox.Show("Do you really want to exit the app?", "Exit Ramya", MessageBoxButtons.YesNo,MessageBoxIcon.Question));
            this.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "-";
            textBox1.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "+";
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int a, b;
            a = int.Parse(label1.Text);
            b = int.Parse(textBox1.Text);

            string operation;
            int c;

            operation = label2.Text;
            try
            {
                if (operation == "+")
                {
                    c = a + b;
                    textBox1.Text = c.ToString();

                }
                else if (operation == "-")
                {
                    c = a - b;
                    textBox1.Text = c.ToString();

                }
                else if (operation == "*")
                {
                    c = a * b;
                    textBox1.Text = c.ToString();
                }
                else if (operation == "/")
                {
                    c = a / b;
                    textBox1.Text = c.ToString();

                }
            }
            catch (Exception p)
            {
                textBox1.Text = "value cannot divide by zero";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "*";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label2.Text = "/";
            textBox1.Text = "";
        }
    }
}
