using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace StacksAndQueues
{
    public class LLQueue<T> where T: IComparable
    {
        SingleLinkedList<T> Queue;
        Node<T> Rear;

        public LLQueue()
        {
            Queue = new SingleLinkedList<T>();
            Rear = Queue.Start;
        }
        public int Size()
        {
            int s = 0;
            Node<T> p = Queue.Start;
            while (p != null)
            {
                s++;
                p = p.Next;
            }
            return s;
        }
        private void UpdateRear()
        {
            Node<T> p = Queue.Start;
            while(p.Next != null)
            {
                p = p.Next;
            }
            Rear = p;
        }
        public void Enque(T data)
        {            
            Queue.InsertAtEnd(data);
            UpdateRear();
        }

        public void Deque()
        {
            Queue.DeleteFirst();
        }

        public T Peek()
        {
            return Queue.Start.Data;
        }
        public void Display()
        {
            Queue.DisplayList();
        }
    }
}
