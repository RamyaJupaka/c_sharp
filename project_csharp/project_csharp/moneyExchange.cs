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
    public partial class moneyExchange : Form
    {
        public moneyExchange()
        {
            InitializeComponent();
        }

        string dir = @"../Debug/";
        string write = "";
        string put = "";
       

        private void button1_Click(object sender, EventArgs e)
        {
            MoneyConversions objEchange = new MoneyConversions();
            bool check = false;
            double res;
            bool _check = false;
            //MessageBox.Show(lradioCAD.ToString());
            try
            {
                do
                {
                    objEchange.Money = Convert.ToDouble(textBox1.Text);
                    if (objEchange.Money < 0)
                    {
                        textBox1.Text = "";

                    }
                } while (objEchange.Money <= 0);
            }
            catch
            {
                check = true;
            }
            finally
            {
                if (check == true)
                {
                    textBox1.Text = " ";
                    textBox1.Focus();
                }
                else
                {
                    if (radioButton1.Checked)
                    {
                        if (radioButton6.Checked)
                        {
                            textBox2.Text = textBox1.Text.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("CAD", "CAD", write, put);
                        }
                        else if (radioButton7.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrC[0]); //call the function of the MoneyConversions
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("CAD", "USD", write, put); //call the function of the writetext
                        }

                        else if (radioButton8.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrC[1]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("CAD", "EUR", write, put);
                        }
                        else if (radioButton9.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrC[2]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("CAD", "GBP", write, put);
                        }
                        else if (radioButton10.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrC[3]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("CAD", "INR", write, put);
                        }
                    }//the end of CAD
                    else if (radioButton2.Checked)
                    {
                        if (radioButton6.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrU[0]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("USD", "CAD", write, put);
                        }
                        else if (radioButton7.Checked)
                        {
                            textBox2.Text = textBox1.Text.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("USD", "USD", write, put);
                        }
                        else if (radioButton8.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrU[1]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("USD", "EUR", write, put);
                        }
                        else if (radioButton9.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrU[2]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("USD", "GBP", write, put);
                        }
                        else if (radioButton10.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrU[3]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("USD", "INR", write, put);
                        }
                    }//the end of USD
                    else if (radioButton3.Checked)
                    {
                        if (radioButton6.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrE[0]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("EUR", "CAD", write, put);
                        }
                        else if (radioButton7.Checked)
                        {

                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrE[1]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("EUR", "USD", write, put);
                        }
                        else if (radioButton8.Checked)
                        {
                            textBox2.Text = textBox1.Text.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("EUR", "EUR", write, put);
                        }
                        else if (radioButton9.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrE[2]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("EUR", "GBP", write, put);
                        }
                        else if (radioButton10.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrE[3]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("EUR", "INR", write, put);
                        }
                    }//the end of EUR
                    else if (radioButton4.Checked)
                    {
                        if (radioButton6.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrG[0]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("GBP", "CAD", write, put);
                        }
                        else if (radioButton7.Checked)
                        {

                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrG[1]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("GBP", "USD", write, put);

                        }
                        else if (radioButton8.Checked)
                        {

                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrG[2]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("GBP", "EUR", write, put);

                        }
                        else if (radioButton9.Checked)
                        {
                            textBox2.Text = textBox1.Text.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("GBP", "GBP", write, put);
                        }
                        else if (radioButton10.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrG[3]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("GBP", "INR", write, put);
                        }
                    }//the end of GBP
                    else if (radioButton5.Checked)
                    {
                        if (radioButton6.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrINR[0]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("INR", "CAD", write, put);
                        }
                        else if (radioButton7.Checked)
                        {

                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrINR[1]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("INR", "USD", write, put);
                        }
                        else if (radioButton8.Checked)
                        {

                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrINR[2]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("INR", "ENR", write, put);
                        }
                        else if (radioButton9.Checked)
                        {
                            res = objEchange.Exchange(objEchange.Money, objEchange.ArrINR[3]);
                            textBox2.Text = res.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("INR", "GBP", write, put);

                        }
                        else if (radioButton10.Checked)
                        {
                            textBox2.Text = textBox1.Text.ToString();
                            write = textBox1.Text;
                            put = textBox2.Text;
                            writetext("INR", "CNY", write, put);
                        }
                    }//the end of INR
                }

                
            }
        }
        public void writetext(string text1, string text2, string read, string get)
        {
            // read date and time
            DateTime currentdate = DateTime.Now;
            DateTime currentime = DateTime.Now;
            string date, time;
            date = currentdate.ToShortDateString();
            time = currentime.ToLongTimeString();

            //create a file under the folder // FileInfo fs = new FileInfo(dir +"Moneyexchange.txt");
            FileStream fileStream = null;
            try
            {
                fileStream = new FileStream(dir + "Moneyexchange.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write(read + text1 + " " + "=" + " " + get + text2 + " " + date + " " + time + "\n");
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
            { MessageBox.Show(ex.Message, "IOException"); }





        }//The end the function to write
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
                textBox2.Clear();
            }

        }

        public class MoneyConversions
        {
            double money;
            double[] arrC = { 0.77, 0.68, 0.61, 52.31 };
            double[] arrU = { 1.31, 0.89, 0.80, 68.87 };
            double[] arrE = { 1.47, 1.13, 0.90, 76.75 };
            double[] arrG = { 1.64, 1.26, 1.11, 85.26 };
            double[] arrINR = { 0.19, 0.15, 0.13, 0.12 };


            public double Money { get => money; set => money = value; }
            public double[] ArrC { get => arrC; set => arrC = value; }
            public double[] ArrU { get => arrU; set => arrU = value; }
            public double[] ArrE { get => arrE; set => arrE = value; }
            public double[] ArrG { get => arrG; set => arrG = value; }
            public double[] ArrINR { get => arrINR; set => arrINR = value; }

            public double Exchange(double money, double rate)
            {
                //the function for calucator
                double res;
                res = money * rate;
                return res;
            }

        }//The end the calss of MoneyConversions

        private void button2_Click(object sender, EventArgs e)
        {
            string line;
            string b = "";
            try
            {
                FileStream fileStream = new FileStream(dir + "Moneyexchange.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fileStream);

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
        }//The end of the button of the read file

        private void lradioCAD_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
 
    

