using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FName LName, Date, Description

namespace ConsoleAppPrepMidterm
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertArea ca1 = new ConvertArea();
            byte ans = 0;
            do
            {
                Console.Write("Menu\nChoose an oprion :\n1. to sq. cm into sq in\n2. sq. m to sq yd\n3. hectars to acres\n4. sq km to sq. miles\n5. to quit\n Enter the option : ");
                ans = Convert.ToByte(Console.ReadLine());

                switch (ans)
                {
                    case 1:
                        {
                            Console.Write("Enter the value to be converted (sq cm to sq in):");
                            try
                            {
                                ca1.EnteredValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("The result in sq in is: " + ca1.SqCmSqIn());
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        break;
                    case 2:
                        {
                            Console.Write("Enter the value to be converted (sq m to sq yd):");
                            try
                            {
                                ca1.EnteredValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("The result in sq yd is: " + ca1.SqMSqYd());
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        break;
                    case 3:
                        {
                            Console.Write("Enter the value to be converted (hectar to acres):");
                            try
                            {
                                ca1.EnteredValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("The result in acres is: " + ca1.HectarAcres());
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        break;
                    case 4:
                        {
                            Console.Write("Enter the value to be converted (sq km to sq mile):");
                            try
                            {
                                ca1.EnteredValue = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine("The result in sq Mile is: " + ca1.SqKmSqMile());
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        break;
                    case 5:
                        { Console.WriteLine("Bye"); Console.ReadKey(); }
                        break;
                    default:
                        { }
                        break;
                }
            } while (ans != 5);

            Console.ReadKey();
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

        public double SqCmSqIn()
        {
            return (EnteredValue * 0.1550);
        }
        public double SqMSqYd()
        {
            return (EnteredValue * 1.1960);
        }
        public double HectarAcres()
        {
            return (EnteredValue * 2.4711);
        }
        public double SqKmSqMile()
        {
            return (EnteredValue * 0.3861);
        }
    }
}
