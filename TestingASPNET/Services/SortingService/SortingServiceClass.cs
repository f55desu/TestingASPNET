using TestingASPNET.Datastructures;

namespace SortingService
{
    public class SortingServiceClass : ISortingService
    {
        public int[] Sort(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new Exception("Empty array provided");
            }

            var sortingLL = new SortingLinkedList<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                sortingLL.Append(numbers[i]);
            }

            BubbleSort<int>.Sort(sortingLL);
            int[] sortedNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                sortedNumbers[i] = sortingLL.GetElementAt(i);
            }

            return sortedNumbers;
        }

        private class BubbleSort<T> where T : IComparable<T>
        {
            public static void Sort(SortingLinkedList<T> list)
            {
                /*list.head = QuickSortMethod(list.head, null);*/
                list.BubbleSortMethod();
            }
        }
    }
}