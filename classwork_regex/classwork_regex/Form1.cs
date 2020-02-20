using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace classwork_regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool test = false;
            Regex reg1 = new Regex(@"[A-Z]([a-z]+)?(\s)?(([A-Z][a-z]+)?)+$"); //^=starting with 
            //$=ending with
            //+=one or many
            //*=zero, one or many
            test=reg1.IsMatch(textBox1.Text);
            if (test == true)
            {
                MessageBox.Show("your entry is:" + test);
            }
            else
            {
                MessageBox.Show("your entry is :"+test+ "\n use only UPPERCASE letter");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool test = false;
            Regex reg1 = new Regex(@"^([0-9]{1,5})\s[A-Z][a-z]+(\.)?(\s)?(([A-Z][a-z]+)?(\.|-)?)*"); //^=starting with 
            //$=ending with
            //+=one or many
            //*=zero, one or many
            test = reg1.IsMatch(textBox2.Text);
            if (test == true)
            {
                MessageBox.Show("your entry is:" + test);
            }
            else
            {
                MessageBox.Show("your entry is :" + test + "\n use numbers and letter (dot or dash included)");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool test = false;
            Regex reg1 = new Regex(@"^([A-Z]([a-z]+)((\s)?([A-Z]([a-z]+)))?)$"); //^=starting with 
            //$=ending with
            //+=one or many
            //*=zero, one or many
            test = reg1.IsMatch(textBox3.Text);
            if (test == true)
            {
                MessageBox.Show("your entry is:" + test);
            }
            else
            {
                MessageBox.Show("your entry is :" + test + "\n use numbers and letter (dot or dash included)");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool test = false;
            Regex reg1 = new Regex(@"[A-z][a-z](\s)?(([A-Z][a-z]+)?)$"); //^=starting with 
            //$=ending with
            //+=one or many
            //*=zero, one or many
            test = reg1.IsMatch(textBox4.Text);
            if (test == true)
            {
                MessageBox.Show("your entry is:" + test);
            }
            else
            {
                MessageBox.Show("your entry is :" + test + "\n use numbers and letter (dot or dash included)");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool test = false;
            Regex reg1 = new Regex(@"^([A-Z][0-9][A-Z])(\s|-)?([0-9][A-Z][0-9])$");
            test = reg1.IsMatch(textBox5.Text);

            if (test == true)
            {
                MessageBox.Show("Accepted postalcode:");
            }
            else
            {
                MessageBox.Show("your postalcode should follow this formate." + "H3N 1A7");
                textBox1.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool test = false;
            Regex reg1 = new Regex(@"^([0-9]{3})(\-)[0-9]{3}(\-)[0-9]{4}$");
            test = reg1.IsMatch(textBox6.Text);

            if (test == true)
            {
                MessageBox.Show("Accepted phonenumber:");
            }
            else
            {
                MessageBox.Show("your phonenumber should follow this formate." + "000-000-000");
                textBox1.Focus();
            }
        }
    }
}
