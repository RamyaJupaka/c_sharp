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


namespace project_csharp
{
    public partial class verifyIP : Form
    {
        public verifyIP()
        {
            InitializeComponent();
        }
        private bool ValidIP(string ipaddress)
        {
            Regex regex = new Regex(@"^(25[0-5]|2[0-4]\d|[0-1]?\d?\d)(\.(25[0-5]|2[0-4]\d|[0-1]?\d?\d)){3}$"); // set the ip address format
            return regex.IsMatch(ipaddress);
        }//The end of the function of the valid ip
        private void button1_Click(object sender, EventArgs e)
        {
            string ipaddress = textBox1.Text;
            bool check = false;

            check = ValidIP(ipaddress);
            //check the input from user is obey the format
            if (check == true)
            {
                MessageBox.Show(ipaddress + "\n The IP is correct.", "Valid IP");
            }
            else
            {
                MessageBox.Show("The IP must have 4 bytes\ninteger number between 0 to 255\nseparated by a dot(255.255.255.255)", "Error");
            }

        }// The end the button of the validate 

        private void verifyIP_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            string date;
            date = dateTime.ToLongDateString();
            label2.Text = "Today: " + date;
        }//The end of the show date and time

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }//The end of the button of the reset

        private void button3_Click(object sender, EventArgs e)
        {

            int i = 0;
            i = Convert.ToInt16(MessageBox.Show("Do your want\n to quit this application", "Exit Ramya", MessageBoxButtons.OKCancel, MessageBoxIcon.Question));
            if (i == 1)
            {
                this.Close();
            }
            else
            {
                textBox1.Clear();
            }
        }//The end of the button of the exit
    }
}
