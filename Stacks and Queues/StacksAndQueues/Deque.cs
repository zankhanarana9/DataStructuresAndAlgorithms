using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace StacksAndQueues
{
    public class Deque<T> where T : IComparable
    {
        DoubleLinkedList<T> DLLQueue;
        T[] Array;
        int Front { get; set; }
        Node<T> Rear { get; set; }

        public Deque()
        {
            Array = new T[5];
            DLLQueue = new DoubleLinkedList<T>();
        }

        public void InsertAtFront(T data)
        {
            DLLQueue.InsertAtBeginning(data);
        }

        private void UpdateRear()
        {
            Node<T> p = DLLQueue.Start;
            while (p.Next != null)
            {
                p = p.Next;
            }
            Rear = p;
        }

        public void InsertAtEnd(T data)
        {
            DLLQueue.InsertAtEnd(data);
            UpdateRear();
        }

        public void DeleteFromFront()
        {
            DLLQueue.DeleteFirstNode();
        }

        public void DeleteFromEnd()
        {
            DLLQueue.DeleteLastNode();
            UpdateRear();
        }

        public void Display()
        {
            DLLQueue.DisplayList();
        }

        public T Peek()
        {
            return Rear.Data;
        }

        public int Size()
        {
            Node<T> p = DLLQueue.Start;
            int c = 0;
            while(p != null)
            {
                c++;
                p = p.Next;
            }
            return c;
        }
    }
}
