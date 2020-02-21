using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace string_object
{
    public partial class Form1 : Form
    {
        private void button2_Click(object sender, EventArgs e)
        {
            Tel object1 = new Tel(textBox2.Text);
            string NumOnly = "", RegForm = "";
            NumOnly = object1.NumericOnly(object1.Nbr);
            RegForm = object1.RegularFormat(NumOnly);
            MessageBox.Show(object1.Nbr+ "\n\n" + NumOnly+ "\n\n" +RegForm);
        }
        public class Tel
    {
        public string nbr;

        public string Nbr
        {
            get { return nbr; }
            set { nbr = value; }
        }

        public Tel() { } 
        public Tel(string nbr)
        {
            this.Nbr = nbr;
        }
            public string NumericOnly(string telephone)
            {
                string NbrOnly = telephone;
                foreach (char c in telephone)
                {
                    if (!(c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7'|| c == '8'|| c == '9'))
                    {
                        NbrOnly = NbrOnly.Remove(NbrOnly.IndexOf(c), 1);
                    }
                }
                 
                return NbrOnly;

            }
            public string RegularFormat(string telephone)
            {
                string RegFormat = telephone;
                RegFormat = RegFormat.Insert(3, "_");
                RegFormat = RegFormat.Insert(7, "_");
                return RegFormat;


            }


        }

   
        public string CapitalStr { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte button2_result = 0;
            button2_result = Convert.ToByte(
            MessageBox.Show("Do you really want to exit the app?", "Exit", MessageBoxButtons.YesNo));
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "none";
            textBox2.Text = "000-000-00";
        }
        public string ToInitialCap(string str)
        {
            string CapitalStr = "";
            CapitalStr = str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
            return CapitalStr;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string full_name = " ";
            string[] names;
            full_name = textBox1.Text.Trim();
            names = full_name.Split(' ');
            if (names.Length == 3)
            {
                MessageBox.Show("First Name:\t" + ToInitialCap(names[0]) +
                                "\n\nmiddle name:\t" + ToInitialCap(names[1]) +
                                "\n\nlast name:\t" + ToInitialCap(names[2]),
                                "parse name");
            }

            else if(names.Length == 2)
            {
                MessageBox.Show("First Name:\t" + ToInitialCap(names[0]) +
                                "\n\nmiddle name:\t" + ToInitialCap(names[1]) ,
                              
                                "parse name");
            }
            else if (names.Length == 1)
            {
                MessageBox.Show("First Name:\t" + ToInitialCap(names[0]) ,
                       
                                "parse name");
            }
            else {
                MessageBox.Show("your name is having Mulptiple Middle Names");


                 }
        }

        
    }
}
