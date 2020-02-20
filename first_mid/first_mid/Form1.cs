using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_mid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            byte button8_result = 0;
            button8_result = Convert.ToByte(
            MessageBox.Show("Do you really want to exit the app?", "Exit", MessageBoxButtons.YesNo));
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox9.Text = "c";
            textBox10.Text = "b";
            textBox11.Text = "c";
            textBox12.Text = "a b c";
            textBox13.Text = "c";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "a, b, c, d";
            textBox10.Text = "a, b, c, d";
            textBox11.Text = "a, b, c, d";
            textBox12.Text = "a, b, c, d";
            textBox13.Text = "a, b, c, d";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";

            textBox1.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox8.ReadOnly = false;

        }
        ConvertArea ca1;//global object name
        private void frmAreaConvert_Load(object sender, EventArgs e)
        {
            ca1 = new ConvertArea();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ca1 = new ConvertArea();
                ca1.EnteredValue = Convert.ToDouble(textBox1.Text);
              //  MessageBox.Show(ca1.EnteredValue.ToString());
                textBox2.Text = ca1.metricmm().ToString();
                textBox1.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ca1 = new ConvertArea();

                ca1.EnteredValue = Convert.ToDouble(textBox4.Text);
                textBox3.Text = ca1.metriccm().ToString();
                textBox4.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                ca1 = new ConvertArea();

                ca1.EnteredValue = Convert.ToDouble(textBox6.Text);
                textBox5.Text = ca1.metricm().ToString();
                textBox6.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                ca1 = new ConvertArea();
                ca1.EnteredValue = Convert.ToDouble(textBox8.Text);
                textBox7.Text = ca1.metrickm().ToString();
                textBox8.ReadOnly = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBox14.Text);
            int num2 = Convert.ToInt32(textBox15.Text);
            int num3 = Convert.ToInt32(textBox16.Text);
            int num4 = Convert.ToInt32(textBox17.Text);
            int num5 = Convert.ToInt32(textBox18.Text);
            int num6 = Convert.ToInt32(textBox19.Text);
            int num7 = Convert.ToInt32(textBox20.Text);


            textBox21.Text = Convert.ToString(num1 + num2 + num3 + num4 + num5 + num6 + num7);
        }
    }
    class ConvertArea
    {
        private double enteredValue;

        public double EnteredValue
        {
            set { enteredValue = value; }
            get { return enteredValue; }
        }

        public ConvertArea() { }
        public ConvertArea(double num1)
        {
            enteredValue = num1;
        }

        public double metricmm()
        {
            return (EnteredValue * 0.03937);
        }
        public double metriccm()
        {
            return (EnteredValue * 0.3937);
        }
        public double metricm()
        {
            return (EnteredValue * 1.0936);
        }
        public double metrickm()
        {
            return (EnteredValue * 0.6214);
        }
    }
}
