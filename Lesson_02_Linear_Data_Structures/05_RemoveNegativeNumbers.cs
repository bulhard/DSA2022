using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace Lesson_02_Linear_Data_Structures
{
    /*
     * 5. Write a program that removes from given sequence all negative numbers.
     */

    public static class RemoveNegativeNumbers
    {
        public static void Run()
        {
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../../input_with_negatives.txt"));
#endif

            var numbers = ConsoleUtility.ReadSequenceOfElements<decimal>().ToList();
            var positiveNumbers = ExtractPositiveNumbers(numbers);

            PrintResult(numbers, positiveNumbers);
        }

        /// <summary>
        /// Works for sbyte, byte, int, uint, long, ulong, double, decimal, etc.
        /// </summary>
        public static IList<T> ExtractPositiveNumbers<T>(IList<T> collection) where T : IComparable
        {
            var positiveNumbers = new List<T>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i].CompareTo((T)Convert.ChangeType(0, typeof(T))) > 0)
                {
                    positiveNumbers.Add(collection[i]);
                }
            }

            return positiveNumbers;
        }

        public static void PrintResult<T>(IEnumerable<T> collection, IEnumerable<T> positiveNumbers)
        {
            Console.WriteLine("All numbers: " + string.Join(" ", collection));
            Console.WriteLine("Positive numbers: " + string.Join(" ", positiveNumbers));
        }
    }
}