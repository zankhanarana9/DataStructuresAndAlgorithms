using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Queue <T> where T : IComparable
    {

        T[] Array;
        int Front { get; set; }
        int Rear { get; set; }

        public Queue()
        {
            Array = new T[10];
            Front = -1;
            Rear = -1;
        }

        public void Enque(T data)
        {
           if(IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }

           if(Front == -1)
            {
                Front = 0;
            }
            Rear = Rear + 1;
            Array[Rear] = data;
        }

        public T Deque()
        {
            if(IsEmpty())
            {
                throw new System.InvalidCastException("Queue underflow");
            }
            T data = Array[Front];
            Front = Front + 1;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidCastException("Queue underflow");
            }
            T data = Array[Front];
            return data;
        }

        public void Display()
        {
            for(int i = Front; i <=Rear; i++)
            {
                Console.Write($"{Array[i]} ");
            }
        }

        public bool IsEmpty()
        {
            return (Front == -1 || Front == Rear + 1);
        }
        public bool IsFull()
        {
            return Rear == Array.Length - 1;
        }

        public int Size()
        {
            if(IsEmpty())
            {
                return 0;
            }

            return Rear - Front + 1;
        }
    }
}
