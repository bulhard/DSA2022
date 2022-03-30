using System;

namespace Lesson_09_Combinatorics
{
    static class Program
    {
        static int[] arr;
        static bool[] used;
        static int n = 5;
        static int k = 4;

        static void Main(string[] args)
        {
            arr = new int[k];
            used = new bool[n];

            // GenerateVariations(0);

            // GenerateVariationsNoReps(0);

            var arr1 = new int[] { 3, 5, 1, 5, 5 };

            Array.Sort(arr);

            Perm(arr1, 0);

            Console.WriteLine("----");

            PermuteRep(arr1, 0, arr.Length);

        }

        static void GenerateVariations(int index)
        {
            if (index >= k)
            {
                Print(arr);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    arr[index] = i;
                    GenerateVariations(index + 1);
                }
            }
        }


        static void GenerateVariationsNoReps(int index)
        {
            if (index >= k)
            {
                // PrintVariations();
                Print(arr);
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if (!used[i])
                    {
                        used[i] = true;
                        arr[index] = i;
                        GenerateVariationsNoReps(index + 1);
                        used[i] = false;
                    }
                }
            }
        }

        static void Perm(int[] arr, int k)
        {
            if (k >= arr.Length)
            {
                Print(arr);
            }
            else
            {
                Perm(arr, k + 1);
                for (int i = k + 1; i < arr.Length; i++)
                {
                    Swap(ref arr[k], ref arr[i]);
                    Perm(arr, k + 1);
                    Swap(ref arr[k], ref arr[i]);
                }
            }
        }

        static void PermuteRep(int[] arr, int start, int n)
        {
            Print(arr);
            for (int left = n - 2; left >= start; left--)
            {
                for (int right = left + 1; right < n; right++)
                    if (arr[left] != arr[right])
                    {
                        Swap(ref arr[left], ref arr[right]);
                        PermuteRep(arr, left + 1, n);
                    }
                var firstElement = arr[left];
                for (int i = left; i < n - 1; i++)
                    arr[i] = arr[i + 1];
                arr[n - 1] = firstElement;
            }
        }

        private static void Swap(ref int v1, ref int v2)
        {
            int temp = v1;
            v1 = v2;
            v2 = temp;
        }

        private static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
        }
    }
}
