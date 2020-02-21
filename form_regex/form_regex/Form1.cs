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


namespace form_regex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            byte button6_result = 0;
            button6_result = Convert.ToByte(
            MessageBox.Show("Do you really want to exit the app?", "Exit", MessageBoxButtons.YesNo));
            this.Close();
        }
        private bool ValidMail(string adresse)
        {
            Regex myRegex = new Regex(@"^([\w]+)@([\w]+)\.([\w]+)$");

            return myRegex.IsMatch(adresse);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool test = false;
            test = ValidMail(textBox1.Text);
            if (test == true)
            {
                MessageBox.Show("Accepted e-mail address:");
            }
            else
            {
                MessageBox.Show("your e-mail should follow this formate." + "test@text.text");
                textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            string pattern = "\\s+";

            string replacement = " ";

            Regex rx = new Regex(pattern);
            string result = rx.Replace(text, replacement);  // call to replace space

            MessageBox.Show(result);

        }
        private bool Validpostal(string adresse)
        {
            Regex myRegex = new Regex(@"^([A-Z][0-9][A-Z])?\s?([0-9][A-Z][0-9])");

            return myRegex.IsMatch(adresse);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool test = false;
            test = Validpostal(textBox1.Text);
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

        private void button4_Click(object sender, EventArgs e)
        {
            string text;
            text = textBox1.Text;
            string pattern = "[abcd]";

            string replacement = " ";

            Regex rx = new Regex(pattern);
            string result = rx.Replace(text, replacement);  // call to replace space

            MessageBox.Show(result);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string text;
            string pattern = "\\s+";
            text = textBox1.Text;
            string[] result = Regex.Split(text, pattern);
            for (int i = 0; i < result.Length; i++)
            {
                MessageBox.Show(result[i].ToString());
                   
            }
                
        }
    }
}
