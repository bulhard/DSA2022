using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_07_Sort_Search
{
    public static class Program
    {
        private static Random rnd = new Random();

        static void Main(string[] args)
        {
            int[] arr;
            
            arr = GenerateArray(100, 0, 100);

            Console.WriteLine("Unsorted array 1:");
            PrintArray(arr);

            BubbleSort1(arr);
            Console.WriteLine("Sorted array 1: ");
            PrintArray(arr);

            arr = GenerateArray(100, 0, 100);
            Console.WriteLine("Unsorted array 2: ");
            PrintArray(arr);

            BubbleSort2(arr);
            Console.WriteLine("Sorted array 2: ");
            PrintArray(arr);
        }

        static void BubbleSort1(int[] arr)
        {
            int swaps = 0;
            int iteration = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int swap = arr[i];
                        arr[i] = arr[j];
                        arr[j] = swap;

                        swaps++;
                    }

                    iteration++;
                }
            }

            Console.WriteLine($"BubbleSort1: Iteration: {iteration} Swaps: {swaps}");
        }

        static void BubbleSort2(int[] arr)
        {
            int swaps = 0;
            int iteration = 0;

            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        // swap temp and arr[i]
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swaps++;
                    }
                    iteration++;
                }
            }

            Console.WriteLine($"BubbleSort2: Iteration: {iteration} Swaps: {swaps}");
        }

        /* Prints the array */
        static void PrintArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");
            Console.WriteLine();
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            var array = source.ToArray();
            var n = array.Length;

            for (var i = 0; i < n; i++)
            {
                // Exchange a[i] with random element in a[i..n-1]
                int r = i + rnd.Next(0, n - i);
                var temp = array[i];
                array[i] = array[r];
                array[r] = temp;
            }

            return array;
        }

        public static int[] GenerateArray(int capacity, int minValue, int maxValue)
        {
            int[] data = new int[capacity];

            for (int i = 0; i < capacity; i++)
            {
                data[i] = rnd.Next(minValue, maxValue);
            }

            return data;
        }

    }
}
