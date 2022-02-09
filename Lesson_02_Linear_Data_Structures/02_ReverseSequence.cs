using System;
using System.Collections.Generic;
using Utility;

namespace Lesson_02_Linear_Data_Structures
{
    /*
     * 2. Write a program that reads N integers from the console
     * and reverses them using a stack. Use the Stack<int> class.
     */

    public static class ReverseSequence
    {
        public static void Run()
        {
#if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../../input.txt"));
#endif

            var numbers = ConsoleUtility.ReadSequenceOfElements<int>();

            var elementsBackwards = new Stack<int>(numbers);

            PrintElementsBackwards(elementsBackwards);
        }

        public static void PrintElementsBackwards(Stack<int> elements)
        {
            while (elements.Count > 0)
            {
                Console.WriteLine(elements.Pop());
            }
        }
    }
}