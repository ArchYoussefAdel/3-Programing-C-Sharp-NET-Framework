//using System;

//class Lap_7_1_1
//{
//    public static void Main()
//    {
//        int[,] Array = new int[3, 4];

//        for (int Row = 0; Row < 3; Row++)
//        {
//            int SumRow = 0;

//            for (int Column = 0; Column < 4; Column++)
//            {
//                Array[Row, Column] = int.Parse(Console.ReadLine());
//                SumRow = SumRow + Array[Row, Column];
//            }
//            Console.WriteLine($"Student No. {Row + 1} Grade Sum= {SumRow}");
//        }

//        for (int Column = 0; Column < 4; Column++)
//        {
//            float AvgColumn = 0;
//            float SumColumn = 0;

//            for (int Row = 0; Row < 3; Row++)
//            {
//                SumColumn = SumColumn + Array[Row, Column];
//                AvgColumn = SumColumn / 3;
//            }
//            Console.WriteLine($"Subject No. {Column + 1} Grade Sum= {SumColumn}, Grade Avg={AvgColumn}");
//        }
//    }
//}


//using System;

//class Lap_7_2_1
//{
//    public static void Main()
//    {
//        int[][] Array = new int[3][];

//        for (int NumberOfStudent = 0; NumberOfStudent < Array.Length; NumberOfStudent++)
//        {
//            Console.WriteLine($"Enter the how many subjects for student {NumberOfStudent + 1}");

//            int SubjectCount = int.Parse(Console.ReadLine());

//            Array[NumberOfStudent] = new int[SubjectCount];

//            for (int Subject = 0; Subject < SubjectCount; Subject++)
//            {
//                Array[NumberOfStudent][Subject] = int.Parse(Console.ReadLine());
//                Console.WriteLine($"Enter  grades for Subject No.{Subject + 1}");
//            }
//        }


//    }
//}



//using System;

//class Lap_7_2_2
//{
//    public static void Main()
//    {
//        int[][] Array = new int[3][];

//        for (int NumberOfStudent = 0; NumberOfStudent < Array.Length; NumberOfStudent++)
//        {
//            Console.WriteLine($"Enter the how many subjects for student {NumberOfStudent + 1}");

//            int SubjectCount = int.Parse(Console.ReadLine());

//            Array[NumberOfStudent] = new int[SubjectCount];

//            for (int Subject = 0; Subject < SubjectCount; Subject++)
//            {
//                Console.WriteLine($"Enter grades for Subject No.{Subject + 1}");
//                Array[NumberOfStudent][Subject] = int.Parse(Console.ReadLine());
//            }
//        }
//    }
//}