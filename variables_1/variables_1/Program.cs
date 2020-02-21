using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string name ;
            string collegename;
            string city ;
            string address;
            sbyte age=-1;
           int ID;
            

            Console.WriteLine("Please enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your college name : ");
            collegename = Console.ReadLine();

            Console.WriteLine("Please enter your city : ");
            city = Console.ReadLine();


            Console.WriteLine("Please enter your address :");
            address = Console.ReadLine();


            do { Console.Write("Enter your age: ");

                try { age = Convert.ToSByte(Console.ReadLine());
                }
                catch (Exception ex1) { Console.WriteLine(ex1.Message + "\n Enter a value 0 to 125 only");
                }
            }
            while ((age < 0) || (age > 125));

            Console.WriteLine("your age is:{0,5}", age);
            Console.ReadKey();
        


        Console.WriteLine("Enter ID : ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your Complete Address:");
            Console.WriteLine("============\n");

            Console.WriteLine("Name = {0} \t Age = {1} \t ID={2}", name,age,ID );
            Console.WriteLine("CollegeName = {0}\t City = {1} \t Address = {2}  ", collegename,city,address);
            //Console.WriteLine("City = {0}", city);
            //Console.WriteLine("Address = {0}", address);
            //Console.WriteLine("ID = {0}", ID);
            //Console.WriteLine("Age = {0}", age);

            Console.WriteLine("===============");

            Console.ReadLine();
           
        }
    }
}
