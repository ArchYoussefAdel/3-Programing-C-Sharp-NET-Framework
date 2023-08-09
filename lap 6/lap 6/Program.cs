//using System;

//class Lap_6_1
//{
//    public static void Main()
//    {
//        int[] Given_Array = new int[10];

//        int Max_Number = Given_Array[0];
//        int Min_Number = 1000000000;
//        foreach (int Given_Numbers in Given_Array)
//        {
//            Given_Array[Given_Numbers] = int.Parse(Console.ReadLine());

//            Console.WriteLine($"Enter Number :");


//            if (Given_Array[Given_Numbers] > Max_Number)
//            {
//                Max_Number = Given_Array[Given_Numbers];
//            }
//            else if (Given_Array[Given_Numbers] < Min_Number)
//            {
//                Min_Number = Given_Array[Given_Numbers];
//            }
//        }
//        Console.WriteLine($"Max=  {Max_Number}");
//        Console.WriteLine($"Min=  {Min_Number}");
//    }
//}

using System;

//class Lap_6_1
//{
//    public static void Main()
//    {
//        int[] Given_Array = new int[10];

//        for (int Given_Numbers = 0; Given_Numbers < Given_Array.Length; Given_Numbers++)
//        {
//            Console.WriteLine($"Enter Number {Given_Numbers + 1}: ");
//            Given_Array[Given_Numbers] = int.Parse(Console.ReadLine());
//        }

//        int Max_Number = Given_Array[0];
//        int Min_Number = Given_Array[0];

//        foreach (int Given_Numbers in Given_Array)
//        {
//            if (Given_Numbers > Max_Number)
//            {
//                Max_Number = Given_Numbers;
//            }
//            if (Given_Numbers < Min_Number)
//            {
//                Min_Number = Given_Numbers;
//            }
//        }

//        Console.WriteLine($"Max = {Max_Number} and it's index is ");
//        //Console.WriteLine($"Min = {Min_Number} and it's index is {Given_Array[Min_Number]}");
//    }
//}


//using System;

//class Lap_6_1
//{
//    public static void Main()
//    {
//        int[] Given_Array = new int[10];
//        int Max_Number = Given_Array[0];
//        int Min_Number = Given_Array[0];

//        int Max_Index = 0;
//        int Min_Index = 0;
//        int index = 0;

//        for (int Given_Numbers = 0; Given_Numbers < Given_Array.Length; Given_Numbers++)
//        {
//            Console.WriteLine($"Enter Number {Given_Numbers + 1}: ");
//            Given_Array[Given_Numbers] = int.Parse(Console.ReadLine());
//        }

//        foreach (int Given_Numbers in Given_Array)
//        {
//            if (Given_Numbers > Max_Number)
//            {
//                Max_Number = Given_Numbers;
//                Max_Index = index;
//            }
//            if (Given_Numbers < Min_Number)
//            {
//                Min_Number = Given_Numbers;
//                Min_Index = index;
//            }
//            index++;
//        }
//        Console.WriteLine($"Max = {Max_Number} and its index is {Max_Index}");
//        Console.WriteLine($"Min = {Min_Number} and its index is {Min_Index}");
//    }
//}


using System;

class Lap_6_1_5
{
    public static void Main()
    {
        int[] Given_Array = new int[10];

        for (int Given_Numbers = 0; Given_Numbers < Given_Array.Length; Given_Numbers++)
        {
            Console.WriteLine($"Enter Number {Given_Numbers + 1}: ");
            Given_Array[Given_Numbers] = int.Parse(Console.ReadLine());
        }

        int Max_Number = Given_Array[0];
        int Min_Number = Given_Array[0];
        int Max_Index = 0;
        int Min_Index = 0;

        for (int i = 1; i < Given_Array.Length; i++)
        {
            if (Given_Array[i] > Max_Number)
            {
                Max_Number = Given_Array[i];
                Max_Index = i;
            }
            if (Given_Array[i] < Min_Number)
            {
                Min_Number = Given_Array[i];
                Min_Index = i;
            }
        }

        Console.WriteLine($"Max = {Max_Number} and its index is {Max_Index}");
        Console.WriteLine($"Min = {Min_Number} and its index is {Min_Index}");
    }
}

//using System;

//class Lap_6_2
//{
//    public static void Main()
//    {
//        Console.WriteLine($"Enter the number of students: ");
//        int Given_Count = int.Parse(Console.ReadLine());
//        string[] Students_Names_Array = new string[Given_Count];

//        Fill_Array(Given_Count, Students_Names_Array);
//        Print_Students_Name(Students_Names_Array);

//    }

//    public static void Fill_Array(int Given_Count, string[] Students_Names_Array)
//    {
//        for (int i = 0; i < Given_Count; i++)
//        {
//            Console.WriteLine($"Enter student number {i + 1} name");

//            string Students_Names = Console.ReadLine();
//            Students_Names_Array[i] = Students_Names;
//        }
//    }

//    public static void Print_Students_Name(string Students_Names_Array)
//    {
//        foreach (string i in Students_Names_Array)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}


//using System;

//class Lap_6_2
//{
//    public static void Main()
//    {
//        Console.WriteLine("Enter the number of students:");
//        int Given_Count = int.Parse(Console.ReadLine());
//        string[] Students_Names_Array = new string[Given_Count];

//        Fill_Array(Given_Count, Students_Names_Array);
//        Print_Students_Name(Students_Names_Array);
//    }

//    public static void Fill_Array(int Given_Count, string[] Students_Names_Array)
//    {
//        for (int i = 0; i < Given_Count; i++)
//        {
//            Console.WriteLine($"Enter student number {i + 1} name:");
//            string Students_Names = Console.ReadLine();
//            Students_Names_Array[i] = Students_Names;
//        }
//    }

//    public static void Print_Students_Name(string[] Students_Names_Array)
//    {
//        Console.WriteLine("Students' names:");
//        foreach (string name in Students_Names_Array)
//        {
//            Console.WriteLine(name);
//        }
//    }
//}
