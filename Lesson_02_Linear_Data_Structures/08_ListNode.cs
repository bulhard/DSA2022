namespace Lesson_02_Linear_Data_Structures
{
    public class ListNode<T>
    {
        public ListNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; set; }

        public ListNode<T> Previous { get; set; }

        public ListNode<T> Next { get; set; }

        public override string ToString()
        {
            return this.Value.ToString();
        }
    }
}