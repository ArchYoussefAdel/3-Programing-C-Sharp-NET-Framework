using System;

#region
class Power
{
    public static int Calc(int bs, int exp)
    {
        int result = 1;
        if (exp <= 1)
        {
            return 1;
        }
        else
        {
            result = bs * Calc(bs, exp - 1);
        }
        return result;
    }
    public static void Main()
    {
        Console.WriteLine($"please enter the and press enter\nnow the power and press enter");
        int bs = int.Parse(Console.ReadLine());
        int exp = int.Parse(Console.ReadLine());
        int result = Calc(bs, exp); ;
        Console.WriteLine($"{result}");
    }
}

#endregion


//class MyClass
//{
//    public static float Calc(int a, int b, out int x)
//    {
//        x = a + b;
//        return (x / 2f);
//    }
//    public static void Main()
//    {
//        Console.WriteLine($"enter the 2 numbers you want to see theire avg and sum followed by pressing enter");
//        int l = int.Parse(Console.ReadLine()), m = int.Parse(Console.ReadLine()), s;
//        float avg;
//        avg = Calc(l, m, out s);
//        Console.WriteLine($"The sum of {l} and {m} is {s}\nThe average of {l} and {m} is {avg}");
//    }
//}
