using System;
using System.Collections.Generic;

namespace Lesson_05_Advanced_Data_Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Handler handler = new Handler();
            //handler.Add("s1");
            //handler.Add("s2");
            //handler.Add("s3");
            //handler.Remove("s1");

            //PriorityQueue<Student> queue = new PriorityQueue<Student>();

            //queue.Enqueue(new Student { Name = "Ivan", Priority = 2 });
            //queue.Enqueue(new Student { Name = "John", Priority = 3 });
            //queue.Enqueue(new Student { Name = "James", Priority = 2 });
            //queue.Enqueue(new Student { Name = "Maria", Priority = 1 });
            //queue.Enqueue(new Student { Name = "Eva", Priority = 1 });

            //while (queue.Count > 0)
            //{
            //    var student = queue.Dequeue();

            //    Console.WriteLine(student);
            //}


            //HeapPriorityQueue<int> heapQueue = new HeapPriorityQueue<int>();

            //heapQueue.Enqueue(11);
            //heapQueue.Enqueue(111);
            //heapQueue.Enqueue(1111);
            //heapQueue.Enqueue(112);
            //heapQueue.Enqueue(112);
            //heapQueue.Enqueue(113);

            //while (heapQueue.Count > 0)
            //{
            //    var item = heapQueue.Dequeue();

            //    Console.WriteLine(item);
            //}


            Store store = new Store();

            for (int i = 1; i <= 500000; i++)
            {
                store.AddProduct(new Product("Product " + i.ToString(), i));
            }

            var productsInRange = store.SearchInPriceRange(100, 2000);
        }
    }
}
