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
    public partial class lotto : Form
    {
        public lotto()
        {
            InitializeComponent();
        }
        int[] arr = new int[6];
        string dir = @"../Debug/";  //create a folder
        private void lotto_Load(object sender, EventArgs e)
        {

            if (Directory.Exists(dir) == false)    // check the folder whether exist
                Directory.CreateDirectory(dir);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random(unchecked((int)DateTime.Now.Ticks));   //create a object of the Random

            int tmp;


            string p = "";
            string g = "";

            for (int i = 0; i < 6; i++)  // get the the number random and then stored to an array.
            {

                tmp = random.Next(1, 49);
                arr[i] = getNum(arr, tmp, random);

                p += arr[i] + "\n";
                g += arr[i].ToString() + " ";

            }
            richTextBox1.Text = p;



            DateTime currentdate = DateTime.Now;   //create a object of the date
            DateTime currentime = DateTime.Now;
            string date, time;
            date = currentdate.ToLongDateString();  //read date and time
            time = currentime.ToLongTimeString();


            FileStream fileStream = null;
            int indexspace = g.LastIndexOf(" ");    //loading for the index of last space
            g = g.Insert(indexspace - 2, " Extra"); //using insert to add  string "Extra" before last number
            //write to text file
            try
            {
                fileStream = new FileStream(dir + "loto.txt", FileMode.Append, FileAccess.Write);
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.Write("Loto649" + " " + g + " " + date + " " + time + "\n");
                streamWriter.Close();
            }
            //catch error
            catch (FileNotFoundException)   
            {
                MessageBox.Show("loto.txt" + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("loto.txt" + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }



        }//The end the button click
        public int getNum(int[] arrnum, int tmp, Random random)
        {
            //The function use the approach of Recursion to reduce odds getting same number
            int n = 0;
            while (n <= arrnum.Length - 1)
            {
                if (arrnum[n] == tmp)
                {
                    tmp = random.Next(1, 49);
                    getNum(arrnum, tmp, random);

                }

                n++;
            }
            return tmp;
        }//The end the function of getNum

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
                richTextBox1.Clear();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Read the content of the file.

            string line;
            string b = "";
            try
            {
                FileStream fileStreamloto = new FileStream(dir + "loto.txt", FileMode.Open); //open file
                StreamReader sr = new StreamReader(fileStreamloto);

                while ((line = sr.ReadLine()) != null)  //read the file util the null
                {

                    b += line + "\n";

                }
                MessageBox.Show(b);
                sr.Close();  //close file
            }
            catch (IOException a)
            {
                MessageBox.Show(a.Message);
            }

        }// The end of the button of the read file


    }
}


