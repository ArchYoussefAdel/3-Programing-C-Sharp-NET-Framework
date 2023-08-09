using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        public static float SumArry(float[] student)
        {
            float sum = 0;
            for (int i = 0; i < student.Length; i++)
            {
                sum += student[i];
            }
            return sum;

        }
        // public static float Subavg(float[][] student)
        // {
        //     float sum = 0;
        //     float avg = sum/4;
        //     for (int i = 0; i < student.Length; i++)
        //     {
        //         for (int j = 0;j < student[i].Length; j++)
        //         { 
        //             sum += student[i][j]; 
        //         }
        //         
        //     }
        //     return avg;
        // }


        static void Main(string[] args)
        {

            #region jagged array 
            float[][] arr1;
            Console.WriteLine($"Please Enter  number Of Students");
            int Sudenum1 = int.Parse(Console.ReadLine());
            arr1 = new float[Sudenum1][];
            Console.WriteLine($"Please Enter  number Of Sub. For  STudents");
            int size1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = new float[size1];
                for (int j = 0; j < size1; j++)
                {
                    Console.WriteLine($"Please Enter the of Degree Subject no {j + 1} For Student No.{i + 1}");
                    arr1[i][j] = float.Parse(Console.ReadLine());
                }
            }
            foreach (var item in arr1)
            {
                int Count = 1;
                float sum = SumArry(item);
                Console.WriteLine($"The Summtion For Sb No.{Count} = {sum}");
            }
            ;
            //float sum1 = 0;
            //float avg = sum1 / 3;
            for (int i = 0; i < size1; i++)
            {
                float sum1 = 0;
                for (int j = 0; j < Sudenum1; j++)
                {
                    sum1 += arr1[j][i];
                }
                Console.WriteLine($"The avg For Subject No.{i + 1} = {sum1 / Sudenum1}");
            }
            #endregion


            #region task 2
            float[][] arr2;
            Console.WriteLine($"Please Enter  number Of Students");
            int Sudenum = int.Parse(Console.ReadLine());
            arr2 = new float[Sudenum][];
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine($"Please Enter  number Of Sub. For  STD{i + 1}");
                int size = int.Parse(Console.ReadLine());
                arr2[i] = new float[size];
                for (int j = 0; j < arr2[i].Length; j++)
                {
                    Console.WriteLine($"Please Enter the of Degree Subject no {j + 1} For Student No.{i + 1}");
                    arr2[i][j] = float.Parse(Console.ReadLine());
                }
            }
        
            #endregion



        }
    }
}
