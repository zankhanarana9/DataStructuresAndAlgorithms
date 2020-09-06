using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class SingleLinkedList<T> where T : IComparable
    {
        public Node<T> Start { get; set; }

        public SingleLinkedList()
        {
            Start = null;
        }

        public void InsertAtBeginning(T data)
        {            
            Node<T> newNode = new Node<T>(data);
            newNode.Next = Start;
            Start = newNode;
        }

        public void InsertAtEnd(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if(Start == null)
            {
                Start = newNode;
                return;
            }

            Node<T> temp = Start;
            while(temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newNode;
        }

        public Node<T> FindNode(T data)
        {
            Node<T> temp = Start;
            while(temp != null)
            {
                if(temp.Data.Equals(data))
                {
                    return temp;
                }
                temp = temp.Next;
            }
            return null;
        }
        public void InsertAtPosition(T data, int x)
        {
            Node<T> temp = Start;
            int count = 1;
            while(count < x -1 && temp != null)
            {
                temp = temp.Next;
                count++;
            }
            if(temp != null)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = temp.Next;
                temp.Next = newNode;
            } 
            else
            {
                Console.WriteLine($"List contains only {count} items");
            }
        }

        public void InsertAfter(T data, T val)
        {
            Node<T> findNode = FindNode(val);
            if(findNode != null)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = findNode.Next;
                findNode.Next = newNode;
            }
            else
            {
                Console.WriteLine($"{val} not found in the list");
            }
        }

        public void InsertBefore(T data, T val)
        {            
            Node<T> temp = Start;
            if (temp.Data.Equals(val))
            {
                InsertAtBeginning(data);
                return;
            }
            while (temp!= null && temp.Next != null)
            {
                if (temp.Next.Data.Equals(val))
                {
                    break;
                }
                temp = temp.Next;
            }
            if (temp.Next != null)
            {
                Node<T> newNode = new Node<T>(data);
                newNode.Next = temp.Next;
                temp.Next = newNode;
            }
            else
            {
                Console.WriteLine($"{val} not found in the list");
            }
        }

        public void DisplayList()
        {
            Node<T> temp = Start;
            while(temp != null)
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
        }     
        
        public void DeleteFirst()
        {
            if(Start != null)
                Start = Start.Next;
        }

        public void DeleteLast()
        {
            if (Start == null) return;
            if(Start.Next == null)
            {
                Start = null;
                return;
            }
            Node<T> temp = Start;            
            while(temp.Next.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = null;
        }    
        
        public void DeleteNode(T data)
        {
            if(Start == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if(Start.Data.Equals(data))
            {
                Start = Start.Next;
                return;
            }

            Node<T> temp = Start;
            while(temp.Next != null)
            {
                if(temp.Next.Data.Equals(data))
                {
                    break;
                }
                temp = temp.Next;
            }

            if(temp.Next != null)
                temp.Next = temp.Next.Next;
            else
            {
                Console.WriteLine($"{data} does not exist in the list");
            }
            
        }
        public void Reverse()
        {
            Node<T> prev, current, next;
            prev = null;
            current = Start;
            while(current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }
            Start = prev;
        }

        public void Merge(SingleLinkedList<T> l1)
        {
            SingleLinkedList<T> list = new SingleLinkedList<T>(); ;
            list.Start = MergeSortedLists(Start, list.Start);
        }
        public Node<T> MergeSortedLists(Node<T> n1, Node<T> n2)
        {

            Node<T> startMerged;

            if (n1.Data.CompareTo(n2.Data) < 0)
            {
                startMerged = new Node<T>(n1.Data);
                n1 = n1.Next;
            }
            else
            {
                startMerged = new Node<T>(n2.Data);
                n2 = n2.Next;
            }
            Node<T> pMerged = startMerged;

            while (n1 != null && n2 != null)
            {
                if(n1.Data.CompareTo(n2.Data) < 0)
                {
                    pMerged.Next = new Node<T>(n1.Data);
                    n1 = n1.Next;
                }
                else
                {
                    pMerged.Next = new Node<T>(n2.Data);
                    n2 = n2.Next;
                }
                pMerged = pMerged.Next;
            }

            while(n1 != null)
            {
                pMerged.Next = new Node<T>(n1.Data);
                n1 = n1.Next;
                pMerged = pMerged.Next;
            }

            while(n2 != null)
            {
                pMerged.Next = new Node<T>(n2.Data);
                n2 = n2.Next;
                pMerged = pMerged.Next;
            }

            return startMerged;
        }
    }
}
