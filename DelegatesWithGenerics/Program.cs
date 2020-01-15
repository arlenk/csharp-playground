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

            Predicate<double> doublePredicate = new Predicate<double>(SimplePredicate<double>);

            int[] filteredIntValues = FilterArray(intValues, SimplePredicate<int>);
            PrintArray(filteredIntValues);

            double[] filteredDoubleValues = FilterArray(doubleValues, doublePredicate);
            PrintArray(filteredDoubleValues);
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

        static void PrintArray<T>(T[] array)
        {
            foreach (T val in array)
                Console.WriteLine("value: {0}", val);
        }

    }
}
