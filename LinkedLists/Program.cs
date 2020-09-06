using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            list =  CreateLinkedList();
            while (true)
            {
                Console.WriteLine("Enter your choice");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Console.WriteLine("Display the list");
                        list.DisplayList();
                        break;
                    case 2:
                        Console.WriteLine("Insert the value from front");
                        int num = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtBeginning(num);
                        break;
                    case 3:
                        Console.WriteLine("Insert the value from front");
                        num = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtEnd(num);
                        break;
                    case 4: Console.WriteLine("Insert after:");
                        int x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Value");
                        num = Convert.ToInt32(Console.ReadLine());
                        list.InsertAfter(num, x);
                        break;
                    case 5:
                        Console.WriteLine("Insert before:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Value");
                        num = Convert.ToInt32(Console.ReadLine());
                        list.InsertBefore(num, x);
                        break;
                    case 6:
                        Console.WriteLine("Insert at:");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Value");
                        num = Convert.ToInt32(Console.ReadLine());
                        list.InsertAtPosition(num, x);
                        break;
                    case 7: Console.WriteLine("Delete last Node:");
                        list.DeleteLast();
                        break;

                    case 8: Console.WriteLine("Delete first node");
                        list.DeleteFirst();
                        break;

                    case 9: Console.WriteLine("Delete Node");
                        Console.WriteLine("Enter Value");
                        num = Convert.ToInt32(Console.ReadLine());
                        list.DeleteNode(num);
                        break;

                    case 10: Console.WriteLine("Reverse List");
                        list.Reverse();
                        break;

                    default: break;
                }
            }            
        }  
        
        private static SingleLinkedList<int> CreateLinkedList()
        {
            SingleLinkedList<int> list = new SingleLinkedList<int>();
            int n = 10;
            for (int i = 1; i <= n; i++)
            {
                list.InsertAtEnd(i);
            }
            return list;
        }
    }
}
