using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedLists;

namespace StacksAndQueues
{
    public class LLStack<T> where T: IComparable
    {
        SingleLinkedList<T> Stack;

        public  LLStack()
        {
            Stack = new SingleLinkedList<T>();
        }

        public void Push(T data)
        {
            Stack.InsertAtBeginning(data);
        }

        public T Pop()
        {
            T data = Stack.Start.Data;
            Stack.DeleteFirst();
            return data;
        }

        public T Peek()
        {
            return Stack.Start.Data;
        }

        public void Display()
        {
            Stack.DisplayList();
        }
    }
}
