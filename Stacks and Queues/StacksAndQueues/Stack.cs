using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace StacksAndQueues
{
    public class Stack<T> where T :IComparable
    {
        T[] Array;
        int Top { get; set; }

        public Stack()
        {
            Array = new T[10];
            Top = -1;
        }

        public Stack(int maxSize)
        {
            Array = new T[maxSize];
            Top = -1;
        }

        public bool IsEmpty()
        {
            return Top == -1;
        }

        public int Size()
        {
            return Top + 1;
        }

        public bool IsFull()
        {
            return Top == Array.Length - 1;
        }
        public void Push(T data)
        {
            if(IsFull())
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            Top = Top + 1;
            Array[Top] = data;            
        }

        public T Pop()
        {
            if(IsEmpty())
            {
                throw new System.InvalidCastException("Stack underflow");
            }

            T data = Array[Top];
            Top = Top - 1;
            return data;
        }

        public T Peek()
        {
            if (IsEmpty())
            {
                throw new System.InvalidCastException("Stack underflow");
            }

            T data = Array[Top];            
            return data;
        }

        public void Display()
        {
            for(int i =Top; i>=0; i--)
            {
                Console.WriteLine(Array[i]);
            }

        }
    }
}
