using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_02_Linear_Data_Structures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // SumAndAverage.Run();

            // ReverseSequence.Run();

            // SortInputElements.Run();

            // LongestSubsequenceOfEquals.Run();

            // RemoveNegativeNumbers.Run();

            // EvenOccurrencesFinder.Run();

            // OccursOfElements.Run();

            TestDoubleLinkedList();

            // LiveDemo();
        }

        private static void LiveDemo()
        {
            string expression = "1 + (2 - (2+3) * 4 / (3+1)) * 5";
            Stack<int> stack = new Stack<int>();

            for (int index = 0; index < expression.Length; index++)
            {
                char ch = expression[index];
                if (ch == '(')
                {
                    stack.Push(index);
                }
                else if (ch == ')')
                {
                    int startIndex = stack.Pop();
                    int length = index - startIndex + 1;
                    string contents = expression.Substring(startIndex, length);
                    Console.WriteLine(contents);
                }
            }

        }



        private static void TestDoubleLinkedList()
        {
            DoubleLinkedList<int> list = new DoubleLinkedList<int>();
            
            list.AddFirst(1);
            
            list.AddFirst(2);
            
            var node1 = list.Find(1);
            
            list.AddAfter(node1, 3);
        }
    }
}