namespace Lesson_02_Linear_Data_Structures._10_Queue
{
    public interface IQueue<T>
    {
        void Enqueue(T value);

        T Peek();

        T Dequeue();

        void Clear();
    }
}