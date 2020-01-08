using System;
using System.Collections.Generic;

namespace DelegatesWithGenericsApp
{
    delegate bool Predicate<T>(T value);

    class Program
    {
        static void Main(string[] args)
        {
            int[] intValues = { 1, 4, 5, 10, 20, 15, -5 };
            double[] doubleValues = { 1, 4.5, 5.5, 10, 20, 15, -5 };

            int[] filteredIntValues = FilterArray(intValues, SimplePredicate);
            foreach (int i in filteredIntValues)
            {
                Console.WriteLine("value: {0}", i);
            }

            double[] filteredDoubleValues = FilterArray(doubleValues, SimplePredicate);
            foreach (double i in filteredDoubleValues)
            {
                Console.WriteLine("value: {0}", i);
            }
        }

        static bool SimplePredicate<T>(T value)
        {
            return Convert.ToInt32(value) < 5;
        }

        static T[] FilterArray<T>(T[] array, Predicate<T> test)
        {
            var result = new List<T>();

            foreach (T value in array)
            {
                if (test(value))
                    result.Add(value);
            }
            return result.ToArray();
        }
    }
}
