using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lottomax lmax = new lottomax();
            lmax.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            moneyExchange me = new moneyExchange();
            me.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CALC CAL = new CALC();
            CAL.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            temperature temp = new temperature();
            temp.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lotto lotto1 = new lotto();
            lotto1.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            verifyIP ip = new verifyIP();
            ip.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            byte button7_result = 0;
            button7_result = Convert.ToByte(
            MessageBox.Show("Do you really want to exit the app?", "Exit Ramya", MessageBoxButtons.YesNo, MessageBoxIcon.Question));
            this.Close();
        }
    }
}
