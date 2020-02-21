using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variablesdatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            long result;

            long  num1=0 , num2=0 ;

            bool check;
            do
            {
                check = false;
                try
                {
                    Console.Write("Enter Your First Number to Calculate  : ");
                    num1 = Convert.ToInt64(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError : Please Enter Numeric Decimal Value\n");
                    check = true;
                }
            } while (check);

            do
            {
                check = false;
                try
                {
                    Console.Write("Enter Your Second Number to Calculate: ");
                    num2 = Convert.ToInt64(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError : Please Enter Numeric Decimal Value\n");
                    check = true;
                }
            } while (check);


            Console.WriteLine("=======================Result of Simple Calculator========= ");


            result = (num1 + num2);

            //Console.WriteLine("Addition Operator:  \n{0} + {1} = {2,20}" +num1 +"+" +num2 +"=" + result);

            Console.WriteLine("Addition: {0} + {1} = {2,20}", num1, num2, (decimal)num1 + num2);


            Console.WriteLine("============================================== ");



            result = (num1 - num2);
            //Console.WriteLine("Subtraction Operator: \n{0} - {1} = {2,20}" +num1 +" - " +num2 +" = " + result);

            Console.WriteLine("Substraction: {0} - {1} = {2,20}", num1, num2, (decimal)num1 - num2);



            Console.WriteLine("===================================================== ");



            result = (num1 * num2);
            //Console.WriteLine("Multiplication Operator: \n{0} * {1} = {2,20}" + num1 + " * " + num2 + " = " + result);

           Console.WriteLine("Multiplication: {0} * {1} = {2,20}", num1, num2, (decimal)num1 * num2);



            Console.WriteLine("===================================================== ");

            try
            {
                if (num2 != 0)
                {


                    result = (num1 / num2);

                    Console.WriteLine("Division : " + num1 + "/" + num2 + "=" + result);
                }
                else
                {
                    Console.WriteLine("Can't Divide by zero");
                }
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine(" you can't divide by zero");

            }
            Console.WriteLine("\n\n====================================================================\n");




            Console.WriteLine("Press Enter Key to Exit..");

            Console.ReadLine();
        }
    }
}



