using System;
using System.Collections.Generic;

class CustomeReplaceInt
{
    public static void ReplaceAll(List<int> list, int oldValue, int newValue)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] == oldValue)
            {
                list[i] = newValue;
            }
        }
    }

    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        ReplaceAll(numbers, 3, 6);
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
    }
}