using System;
using System.Collections.Generic;

namespace DelegatesApp
{
    delegate bool FilterTest(int value);

    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 1, 4, 5, 10, 20 , 15, -5 };
            int[] filteredValues = FilterArray(values, MyTest);
            foreach(int i in filteredValues)
            {
                Console.WriteLine("value: {0}", i);
            }
        }

        static bool MyTest(int value)
        {
            return value < 5;
        }

        static int[] FilterArray(int[] array, FilterTest test)
        {
            var result = new List<int>();

            foreach (int value in array)
            {
                if (test(value))
                    result.Add(value);
            }
            return result.ToArray();
        }
    }
}
