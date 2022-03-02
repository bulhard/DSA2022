using System;
using System.Collections.Generic;
using System.Text;
using Wintellect.PowerCollections;

namespace Lesson_05_Advanced_Data_Structures
{
    public class PriorityQueue<T> 
    {
        private OrderedBag<T> queue;
        public int Count
        {
            get { return this.queue.Count; }
        }
        public PriorityQueue()
        {
            this.queue = new OrderedBag<T>();
        }
        public void Enqueue(T element)
        {
            this.queue.Add(element);
        }
        public T Dequeue()
        {
            return this.queue.RemoveFirst();
        }
    }
}
