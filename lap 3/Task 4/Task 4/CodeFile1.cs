using System;
using System.Threading;

class Program
{
    public static void Main()
    {

        do
        {
            Console.Clear();


            Console.WriteLine("Choose Operation: \n" + "1-Sum \n" + "2-Sub \n" + "3-Multi \n" + "4-Devide \n" + "5-Exit \n");
            int Type = Convert.ToInt32(Console.ReadLine());

            if(Type == 5)
            {
                break;
            }
            else if(!(Type==1||Type==2||Type==3||Type==4))
            {
                Console.Clear();
                Console.WriteLine("Choose a correct operation");
                Console.ReadLine();
                continue;
            }

            Console.Write("Enter First Number: ");
            double Num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Second Number: ");
            double Num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"The Result = {Math_Operations(Num1, Num2, Type)}");
                Console.WriteLine("Press Enter to Calculate Again");
         
            Console.ReadLine();
        } while (true);


    }
    public static double Math_Operations(double n1, double n2, int sort)
    {
        double Result = 0;
        switch (sort)
        {
            case 1:
                Result = n1 + n2;
                break;

            case 2:
                Result = n1 - n2;
                break;

            case 3:
                Result = n1 * n2;
                break;

            case 4:
                Result = n1 / n2;
                break;

        }
        return Result;
    }




}