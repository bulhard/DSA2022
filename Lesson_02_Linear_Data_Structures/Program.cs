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