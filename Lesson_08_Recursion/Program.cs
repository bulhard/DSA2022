using System;

namespace Lesson_08_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 4;
            int[] vector = new int[size];
            Gen01(size - 1, vector);

        }

        static void Gen01(int index, int[] vector)
        {
            if (index == -1)
            {
                Print(vector);
            }
            else
            {
                for (int i = 0; i <= 4; i++)
                {
                    vector[index] = i;
                    Gen01(index - 1, vector);
                }
            }
        }

        private static void Print(int[] vector)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i]);
            }
            Console.WriteLine();
        }
    }
}
