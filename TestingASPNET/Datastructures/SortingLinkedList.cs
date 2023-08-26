using Microsoft.AspNetCore.Mvc;

namespace TestingASPNET.Datastructures
{
    public class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class SortingLinkedList<T> where T : IComparable<T>
    {
        private Node<T> head;
        private int lenght = 0;
        public int Lenght { get; }
        public void Append(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node<T> current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            lenght++;
        }
        public T GetElementAt(int index)
        {
            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                current = current.Next;
            }
            if (current == null)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            return current.Data;
        }
        public void SetElementAt(int index, T data)
        {
            Node<T> current = head;
            for (int i = 0; i < index; i++)
            {
                if (current == null)
                {
                    throw new IndexOutOfRangeException("Index out of range");
                }
                current = current.Next;
            }
            if (current == null)
            {
                throw new IndexOutOfRangeException("Index out of range");
            }
            current.Data = data;
        }
        public void BubbleSortMethod()
        {
            if (head == null)
                return;

            bool swapped;
            Node<T> current;
            Node<T> last = null;

            do
            {
                swapped = false;
                current = head;

                while (current.Next != last)
                {
                    if (current.Data.CompareTo(current.Next.Data) > 0)
                    {
                        T temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
                last = current;
            }
            while (swapped);
        }
    }
}
