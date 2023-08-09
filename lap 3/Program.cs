using System;
using FakeItEasy;

class Lap_3
{
    public static void Main()
    {
        //Console.WriteLine("enter 10 num");
        //int Max;


        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        //Max = int.Parse(Console.ReadLine());
        ////b = int.Parse(Console.ReadLine());
        ////c = int.Parse(Console.ReadLine());
        ////d = int.Parse(Console.ReadLine());
        ////e = int.Parse(Console.ReadLine());
        ////f = int.Parse(Console.ReadLine());
        ////g = int.Parse(Console.ReadLine());
        ////h = int.Parse(Console.ReadLine());
        ////i = int.Parse(Console.ReadLine());
        ////j = int.Parse(Console.ReadLine());

        ////int.Parse(Console.ReadLine());
        //int Maxiii;

        //for (Maxiii = 0; Max > Maxiii;)
        //{
        //    Console.WriteLine($"max={Maxiii},{Max}");
        //}


        Console.WriteLine($"how many numbers you want to see their max and min value? ");



        int max;
        int min;
        int val = int.Parse(Console.ReadLine());

        Console.WriteLine($"Enter the {val} numbers:");

        int num = int.Parse(Console.ReadLine());
        max = num;
        min = num;

        for (int i = 0; i < val; i++)
        {

            Console.WriteLine($"You Entered {val} numbers:");


            num = int.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }
        }

        //Console.WriteLine($"max={max}");
        //Console.WriteLine($"min={min}");

        //int Max = 0;
        //int Min = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Please enter number {0} ", i + 1);
        //    int num = int.Parse(Console.ReadLine());
        //    if (i == 0)
        //    {
        //        Max = num;
        //        Min = num;
        //    }
        //    else
        //    {
        //        if (Max < num)
        //            Max = num;
        //        else if (Min > num)
        //            Min = num;
        //    }

        //}
        //Console.WriteLine($"The maximum number = {Max}\nThe minimum number = {Min}");
        //Console.ReadLine();


        //int Max = 0;
        //int Min = 0;
        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine("Please enter number {0} ", i + 1);
        //    int num = int.Parse(Console.ReadLine());
        //    if (i < 10)
        //    {
        //        Max = num;
        //        Min = num;
        //    }
        //    else
        //    {
        //        if (Max < num)
        //            Max = num;
        //        else if (Min > num)
        //            Min = num;
        //    }

        //}
        //Console.WriteLine($"The maximum number = {Max}\nThe minimum number = {Min}");
        //Console.ReadLine();




        //int a = 1, b = 2, c = 3, d = 4, f = 5;



        //int good = int.Parse(Console.ReadLine());
        //int Grade = 0;

        /*
        Console.WriteLine("Enter Grade :");


        int Grade = int.Parse(Console.ReadLine());


        if (Grade > 85 && Grade < 100)
        {
            Grade = 1;
        }
        else if (Grade > 75 && Grade <= 85)
        {
            Grade = 2;
        }
        else if (Grade > 65 && Grade <= 75)
        {
            Grade = 3;
        }
        else if (Grade > 50 && Grade <= 65)
        {
            Grade = 4;
        }
        else if (Grade < 50)
        {
            Grade = 5;
        }

        //Console.WriteLine(value: $" {Grade}");

        switch (Grade)
        {
            case 1:
                Console.WriteLine("Grade: a");
                break;
            case 2:
                Console.WriteLine("Grade: b");
                break;
            case 3:
                Console.WriteLine("Grade: c");
                break;
            case 4:
                Console.WriteLine("Grade: d");
                break;
            case 5:
                Console.WriteLine("Grade: f");
                break;

        */


        //int t = 0;
        //for (int num = 0; num >= 1 && t <= 50; num++, t++)
        //{
        //    int x = 0;


        //    num = num + (1 * t) ;

        //    num =  num - (1 * t);

        //    x = x + (1 * t);

        //    x = x - (1 * t);
        //}



        // 1 <= num, t <= 50
        //x is the biggest acheivable when x=t  , after we do the following operations t times
        // x+1 or x-1 and num +1 or num -1 (*t)
    }
}


