using System;
using System.Collections.Generic;
using System.Linq;
using Utility;

namespace Lesson_02_Linear_Data_Structures
{
    /*
    * 3. Write a program that reads a sequence of integers (List<int>)
    * ending with an empty line and sorts them in an increasing order.
    */

    public static class SortInputElements
    {
        public static void Run()
        {
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../../input_unsorted.txt"));
#endif

            var elements = ConsoleUtility.ReadSequenceOfElements<int>();

            List<int> sortedCollection = elements.OrderBy(a => a).ToList();
            Console.WriteLine("Sorted list: " + string.Join(" ", sortedCollection));

            SortedSet<int> sortedSet = new SortedSet<int>(elements);
            Console.WriteLine("Sorted set: " + string.Join(" ", sortedSet));
        }
    }
}