/*
 * 1. Write a program that counts in a given array of double
 * values the number of occurrences of each value.
 * Use Dictionary<TKey,TValue>.
 *
 * Example: array = {3, 4, 4, -2.5, 3, 3, 4, 3, -2.5}
 * -2.5 -> 2 times
 * 3 -> 4 times
 * 4 -> 3 times
 */

using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace Lesson_04_Collections
{
    public static class _01_OccurrencesOfElement
    {
        public static void Run()
        {
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../../01_input.txt"));
#endif

            var elements = ConsoleUtility.ReadSequenceOfElements<double>().ToList();

            var occurrences = FindElementsOccurrences(elements);

            ConsoleUtility.PrintDictionaryElements(occurrences);
        }

        public static IDictionary<T, int> FindElementsOccurrences<T>(IList<T> collection)
        {
            var dict = new Dictionary<T, int>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (!dict.ContainsKey(collection[i]))
                {
                    dict[collection[i]] = 0;
                }

                dict[collection[i]]++;
            }

            return dict;
        }
    }
}