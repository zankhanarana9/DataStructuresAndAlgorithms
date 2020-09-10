using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class CircleQueue<T> where T : IComparable
    {
        T[] Array { get; set; }
        int Front { get; set; }
        int Rear { get; set; }

        public CircleQueue()
        {
            Array = new T[10];
            Front = -1;
            Rear = -1;
        }

        public bool IsEmpty()
        {
            return Front == -1;
        }

        public bool IsFull()
        {
            return (Front == Rear + 1) || (Front == 0 && Rear == Array.Length - 1);
        }

        public void Enque(T data)
        {

            if (IsFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            if (Front == -1)
            {
                Front = 0;
            }

            if (Rear == Array.Length - 1)
                Rear = 0;
            else
                Rear = Rear + 1;
            Array[Rear] = data;

        }

        public T Deque()
        {
            if (IsEmpty())
            {
                throw new System.InvalidCastException("Queue underflow");
            }
            T data = Array[Front];
            //Only 1 element in the queue
            if (Front == Rear)
            {
                Front = -1;
                Rear = -1;
            }
            
           if(Front == Array.Length -1)
            {
                Front = 0;
            } else
            {
                Front = Front + 1;
            }
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidCastException("Queue underflow");
            }
            return Array[Front];
        }

        public void Display()
        {
            if (IsEmpty()) return;

            if(Front <= Rear)
            {
                for(int i =Front; i<= Rear; i++)
                {
                    Console.Write($"{Array[i]} ");
                }
            }
            else
            {
                for(int i = Front; i < Array.Length; i++)
                {
                    Console.Write($"{Array[i]} ");
                }
                for(int i =0; i <=Rear; i++)
                {
                    Console.Write($"{Array[i]} ");
                }
            }
            Console.WriteLine();
        }

        public int Size()
        {
            if(IsEmpty())
            {
                return 0;
            }

            if(IsFull())
            {
                return Array.Length - 1;
            }

            if (Front <= Rear)
            {
                return Rear - Front + 1;                
            }
            else
            {
                int size = Array.Length - Front;
                size += Rear;
                return size;                
            }
        }
    }
}
