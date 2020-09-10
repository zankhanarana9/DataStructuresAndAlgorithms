using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class DoubleLinkedList<T> where T:IComparable
    {
        public Node<T> Start;
        public DoubleLinkedList()
        {
            Start = null;
        }

        public void DisplayList()
        {
            Node<T> p;
            if(Start == null)
            {
                return;
            }

            p = Start;
            while(p!=null)
            {
                Console.Write($"{p.Data} ");
                p = p.Next;
            }
            Console.WriteLine();
        }

        public void InsertAtBeginning(T data)
        {
            Node<T> temp = new Node<T>(data);
            if(Start== null)
            {
                Start = temp;
                return;
            }

            temp.Next = Start;
            Start.Previous = temp;
            Start = temp;
        }

        public void InsertAtEnd(T data)
        {
            Node<T> p;
            Node<T> temp = new Node<T>(data);
            if(Start== null)
            {                
                Start = temp;
                return;
            }
            p = Start;
            while(p.Next != null)
            {
                p = p.Next;
            }
            p.Next = temp;
            temp.Previous = p;
        }

        public void InsertAfterNode(T data, T val)
        {
            if(Start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }
            Node<T> p = Start;
            while(p != null)
            {
                if(p.Data.Equals(val))
                {
                    break;
                }
                p = p.Next;
            }

            if(p == null)
            {
                Console.WriteLine($"{val} does not exist in the list");
            }
            else
            {
                Node<T> temp = new Node<T>(data);
                temp.Previous = p;
                temp.Next = p.Next;
                if(p.Next != null) //last node
                    p.Next.Previous = temp;
                p.Next = temp;
            }
        }

        public void InsertBefore(T data, T val) 
        {
            if (Start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if(Start.Data.Equals(val))
            {
                InsertAtBeginning(data);
                return;
            }
                
            Node<T> p = Start;
            while (p != null)
            {
                if (p.Data.Equals(val))
                {
                    break;
                }
                p = p.Next;
            }

            if (p == null)
            {
                Console.WriteLine($"{val} does not exist in the list");
            }
            else
            {
                Node<T> temp = new Node<T>(data);
                temp.Next = p;
                temp.Previous = p.Previous;
                p.Previous.Next = temp;
                p.Previous = temp;
            }
        }

        public void DeleteFirstNode()
        {
            if(Start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if(Start.Next == null)
            {
                DeleteOnlyNode();
                return;
            }

            Start = Start.Next;
            Start.Previous = null;
        }

        public void DeleteOnlyNode()
        {
            Start = null;
        }

        public void DeleteNode(T data)
        {
            if (Start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if (Start.Data.Equals(data))
            {
                DeleteFirstNode();
                return;
            }

            Node<T> p = Start;
            while(p.Next != null)
            {
                if(p.Data.Equals(data))
                {
                    break;
                }
                p = p.Next;
            }

            if(p.Next == null)
            {
                p.Previous.Next = p.Next;
                p.Next.Previous = p.Previous;
            }
            else
            {
                if(p.Data.Equals(data))
                {
                    DeleteLastNode();                    
                }
                else
                {
                    Console.WriteLine($"{data} does not exist in the list");
                }
            }
        }

        public void DeleteLastNode()
        {
            if(Start == null)
            {
                Console.WriteLine("List is empty!");
                return;
            }

            if(Start.Next == null)
            {
                DeleteOnlyNode();
                return;
            }
            Node<T> p = Start;
            while(p.Next !=null)
            {
                p = p.Next;
            }
            p.Previous.Next = null;
        }

        public void ReverseList()
        {
            if(Start == null)
            {
                return;
            }
            Node<T> p1 = Start;
            Node<T> p2 = Start.Next;

            p1.Next = null;
            p1.Previous = p2;

            while(p2 != null)
            {
                p2.Previous = p2.Next;
                p2.Next = p1;
                p1 = p2;
                p2 = p2.Previous;
            }

            Start = p2;
        }
    }
}
