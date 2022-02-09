using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace Lesson_02_Linear_Data_Structures
{
    /*
     * 7. Write a program that finds in given array of integers
     * (all belonging to the range [0..1000]) how many times each of them occurs.
     *
     * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
     * 2 -> 2 times
     * 3 -> 4 times
     * 4 -> 3 times
     */

    public static class OccursOfElements
    {
        public static void Run()
        {
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../../input_occurences.txt"));
#endif

            var elements = ConsoleUtility.ReadSequenceOfElements<int>().ToList();
            var occurrences = FindElementsOccurrences(elements);

            PrintResult(occurrences);
        }

        public static IDictionary<T, int> FindElementsOccurrences<T>(IList<T> collection)
        {
            var dictionary = new Dictionary<T, int>();

            for (int i = 0; i < collection.Count; i++)
            {
                if (dictionary.ContainsKey(collection[i]))
                {
                    dictionary[collection[i]]++;
                }
                else
                {
                    dictionary[collection[i]] = 1;
                }
            }

            return dictionary;
        }

        public static void PrintResult<T>(IDictionary<T, int> dictionary)
        {
            foreach (KeyValuePair<T, int> item in dictionary)
            {
                Console.WriteLine("{0} -> {1} time(s).", item.Key, item.Value);
            }
        }
    }
}