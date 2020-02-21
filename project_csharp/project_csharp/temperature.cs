using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project_csharp
{
    public partial class temperature : Form
    {
        public temperature()
        {
            InitializeComponent();
        }
        Convertemperature obj1 = new Convertemperature();//create a object for C to F
        Convertemperature obj2 = new Convertemperature();//create a object for F to C
        double res;
        string dir = @"../Debug/";
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label3.Text = "C";
                label4.Text = "F";
            }
            else
            {
                label3.Text = "F";
                label4.Text = "C";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (radioButton1.Checked)
            {
                try
                {
                    obj1.Num1 = Convert.ToDouble(textBox1.Text);
                }
                catch
                {

                    check = true;
                }
                finally
                {
                    if (check == true)
                    {
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        res = obj1.CtoF(obj1.Num1);
                        textBox2.Text = res.ToString();
                        //MessageBox.Show(res.ToString());
                        writetext("C", "F", obj1.Num1, res);
                        if (res > 212)
                        {
                            richTextBox1.Text = ("Water boils");
                        }
                        else if (res < 212 && res > 103)
                        {
                            richTextBox1.Text = ("Hot Bath");

                        }
                        else if (res < 104 && res > 98)
                        {
                            richTextBox1.Text = ("Body temperature");

                        }
                        else if (res < 98 && res > 85)
                        {
                            richTextBox1.Text = ("Beach weather");
                        }
                        else if (res < 85 && res > 70)
                        {
                            richTextBox1.Text = ("Room temperature");

                        }
                        else if (res < 70 && res > 49)
                        {
                            richTextBox1.Text = ("Cool Day");
                        }
                        else if (res < 50 && res > 31)
                        {
                            richTextBox1.Text = ("Freezing Point of water");
                        }
                        else if (res < 31 && res > -1)
                        {
                            richTextBox1.Text = ("Very Cold Day");
                        }
                        else if (res < -1 && res > -41)
                        {
                            richTextBox1.Text = ("Extremely Cold Day"
                                + "\n(and the same number!WOW....)");
                        }
                        else
                        {
                            richTextBox1.Text = ("Bold are exact");
                        }
                    }
                }
            }
            else if (radioButton2.Checked)
            {
                try
                {
                    obj2.Num1 = Convert.ToDouble(textBox1.Text);
                }
                catch
                {

                    check = true;
                }
                finally
                {
                    if (check == true)
                    {
                        textBox1.Text = "";
                        textBox1.Focus();
                    }
                    else
                    {
                        res = obj2.FtoC(obj2.Num1);
                        textBox2.Text = res.ToString();
                        writetext("F", "C", obj2.Num1, res);
                        //MessageBox.Show(res.ToString());

                        if (res > 99)
                        {
                            richTextBox1.Text = ("Water boils");
                        }
                        else if (res < 100 && res > 30)
                        {
                            richTextBox1.Text = ("Hot Bath");

                        }
                        else if (res < 40 && res > 36)
                        {
                            richTextBox1.Text = ("Body temperature");

                        }
                        else if (res < 37 && res > 29)
                        {
                            richTextBox1.Text = ("Beach weather");
                        }
                        else if (res < 30 && res > 20)
                        {
                            richTextBox1.Text = ("Room temperature");

                        }
                        else if (res < 21 && res > 9)
                        {
                            richTextBox1.Text = ("Cool Day");
                        }
                        else if (res < 10 && res > -1)
                        {
                            richTextBox1.Text = ("Freezing Point of water");
                        }
                        else if (res < 0 && res > -19)
                        {
                            richTextBox1.Text = ("Very Cold Day");
                        }
                        else if (res < -18 && res > -39)
                        {
                            richTextBox1.Text = ("Extremely Cold Day"
                                + "\n(and the same number!WOW....)");
                        }
                        else
                        {
                            richTextBox1.Text = ("Bold are exact");
                        }
                    }
                }

            }

        }//the end the button_convert
        private void temperature_Load(object sender, EventArgs e)
        {

        }

       

        private void button5_Click(object sender, EventArgs e)
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
                textBox2.Clear();
                richTextBox1.Clear();

            }
        }
        public void writetext(string text1, string text2, double num1, double res)
        {
            // read date and time
            DateTime currentdate = DateTime.Now;
            DateTime currentime = DateTime.Now;
            string date, time;
            date = currentdate.ToShortDateString();
            time = currentime.ToLongTimeString();

            //create a file under the folder //FileInfo fs = new FileInfo(dir + "temperature.txt");
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(dir + "temperature.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(num1.ToString() + text1 + " " + "=" + " " + res.ToString() + text2 + " " + date + " " + time + "\n");
                streamWriter.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("names.txt" + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("names.txt" + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException");
            }

        }//the end the function to write

        private void button4_Click(object sender, EventArgs e)
        {
            string line;
            string b = "";
            try
            {
                FileStream fileStreamloto = new FileStream(dir + "temperature.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fileStreamloto);

                while ((line = sr.ReadLine()) != null)
                {

                    b += line + "\n";

                }
                MessageBox.Show(b);
                sr.Close();
            }
            catch (IOException a)
            {
                MessageBox.Show(a.Message);
            }

        }//The end the button of the read file
        public class Convertemperature
        {
            double num1;


            public double Num1 { get => num1; set => num1 = value; }
            //to Calculate 
            public double CtoF(double num1)
            {
                double res;
                res = ((num1 * 1.8) + 32);
                return res;
            }
            public double FtoC(double num1)
            {
                double res;
                res = Math.Round(((num1 - 32) / 1.8));
               
                return res;
            }

        }//The end the class of Convertemperature

        private void Temperature_Load(object sender, EventArgs e)
        {


        }
    }
}

