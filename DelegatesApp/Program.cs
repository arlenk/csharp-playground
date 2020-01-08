using System;
using System.Collections.Generic;

namespace DelegatesApp
{
    delegate bool IntPredicate(int value);
    delegate bool DoublePredicate(double value);

    class Program
    {
        static void Main(string[] args)
        {
            int[] intValues = { 1, 4, 5, 10, 20 , 15, -5 };
            double[] doubleValues = { 1, 4.5, 5.5, 10, 20, 15, -5 };

            int[] filteredIntValues = FilterIntArray(intValues, SimpleIntPredicate);
            foreach(int i in filteredIntValues)
            {
                Console.WriteLine("value: {0}", i);
            }

            double[] filteredDoubleValues = FilterDoubleArray(doubleValues, SimpleDoublePredicate);
            foreach (double i in filteredDoubleValues)
            {
                Console.WriteLine("value: {0}", i);
            }
        }

        static bool SimpleIntPredicate(int value)
        {
            return value < 5;
        }
        static bool SimpleDoublePredicate(double value)
        {
            return value < 5;
        }

        static int[] FilterIntArray(int[] array, IntPredicate test)
        {
            var result = new List<int>();

            foreach (int value in array)
            {
                if (test(value))
                    result.Add(value);
            }
            return result.ToArray();
        }

        static double[] FilterDoubleArray(double[] array, DoublePredicate test)
        {
            var result = new List<double>();

            foreach (double value in array)
            {
                if (test(value))
                    result.Add(value);
            }
            return result.ToArray();
        }

    }
}
