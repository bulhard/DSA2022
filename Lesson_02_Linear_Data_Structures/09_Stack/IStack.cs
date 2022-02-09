namespace Lesson_02_Linear_Data_Structures._09_Stack
{
    public interface IStack<T>
    {
        void Push(T value);

        T Peek();

        T Pop();

        void Clear();
    }
}