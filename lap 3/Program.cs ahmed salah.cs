using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yousef
{
    internal class Program
    {
        public static double Sum(double x, double y)
        {
            double z = x + y;
            return z;
        }
        public static double Sub(double x, double y)
        {
            double z = x - y;
            return z;
        }
        public static double Divi(double x, double y)
        {
            double z = x / y;
            return z;
        }
        public static double Mult(double x, double y)
        {
            double z = x * y;
            return z;
        }

        static void Main(string[] args)
        {
            bool ch = true;
            do
            {
                double s = 0;
                Console.WriteLine("Welcome\nPlease Enter 2 Numbers and Select The Opreation You want to Apply  :");
                Console.WriteLine("Enter No. 1 :");
                double num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter No. 2 :");
                double num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Select The Opreation");
                Console.WriteLine("Note\nSum = Summation\nSub=Subtraction\n Divi=Division\nMult=Multiplication");
                string opre = Console.ReadLine();
                string Upper = opre.ToUpper();

                switch (Upper)
                {
                    case "SUM":
                        s = Sum(num1, num2);
                        break;
                    case "SUB":
                        s = Sub(num1, num2);
                        break;
                    case "DIVI":
                        s = Divi(num1, num2);
                        break;
                    case "MULT":
                        s = Mult(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Wrong Select ");
                        break;
                }
                Console.WriteLine(s);
                        Console.WriteLine("Are You  need to enter Another Number ?(yes/no)");
                        string Option = Console.ReadLine();
                        string Upper02 = Option.ToUpper();
                        if (Upper02 == "YES")
                        {
                            ch = true;
                        }
                        else if (Upper02 == "NO")
                        {
                            ch = false;
                        }
                        else { Console.WriteLine("Wrong Input"); }

                

            } while (ch);
        }
    }
}
