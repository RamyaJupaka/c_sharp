using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_project1
{
    class Sum
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine(Number(3, 9));
            //    Console.WriteLine(Number(3, 3));
            //    Console.ReadLine();

            int num1 = 0, num2 = 0, res = 0;
            Console.Write("Enter the first number :");
            num1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            res = num1 + num2;
            Console.WriteLine("The result is : " + res);
            Console.Read();
            Console.ReadKey();
            Console.ReadLine();

        }

    }
    }
