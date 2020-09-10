using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    int choice, x;
        //    //LLStack<int> stack = new LLStack<int>();
        //    //LLQueue<int> queue = new LLQueue<int>();
        //    CircleQueue<int> queue = new CircleQueue<int>();
        //    while(true)
        //    {
        //        Console.WriteLine("1. push element to the stack");
        //        Console.WriteLine("2. pop an element");
        //        Console.WriteLine("3. display the top element");
        //        Console.WriteLine("4. display all the stack elements");
        //        Console.WriteLine("5. Display size");
        //        Console.WriteLine("6. Quit");
        //        Console.WriteLine("Enter your choice");

        //        choice = Convert.ToInt32(Console.ReadLine());
        //        if(choice == 6)
        //        {
        //            break;
        //        }
        //        switch(choice)
        //        {
        //            case 1:
        //                Console.WriteLine("Enter an element:");
        //                x = Convert.ToInt32(Console.ReadLine());
        //                //stack.Push(x);
        //                queue.Enque(x);
        //                break;

        //            case 2:// stack.Pop();
        //                queue.Deque();
        //                break;

        //            case 3: Console.WriteLine($"Top element {queue.Peek()} ");
        //                break;

        //            case 4: queue.Display();
        //                break;

        //            case 5: Console.WriteLine($"size: {queue.Size()}");
        //                break;               

        //            default: break;
        //        }
        //    }
        //}


        public static void Main(string[] args)
        {
            int choice, x;
            Deque<int> queue = new Deque<int>();
            while (true)
            {
                Console.WriteLine("1. Enque and element from front");
                Console.WriteLine("2. Deque an element from front");
                Console.WriteLine("3. Display the first element");
                Console.WriteLine("4. display all the elements");
                Console.WriteLine("5. Display size");
                Console.WriteLine("6. Enque and element from back");
                Console.WriteLine("2. Deque an element from back");
                Console.WriteLine("8. Quit");
                Console.WriteLine("Enter your choice");

                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 8)
                {
                    break;
                }
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter an element:");
                        x = Convert.ToInt32(Console.ReadLine());
                        //stack.Push(x);
                        queue.InsertAtFront(x);
                        break;

                    case 2:// stack.Pop();
                        queue.DeleteFromFront();
                        break;

                    case 3:
                        Console.WriteLine($"Top element {queue.Peek()} ");
                        break;

                    case 4:
                        queue.Display();
                        break;

                    case 5:
                        Console.WriteLine($"size: {queue.Size()}");
                        break;

                    case 6:
                        Console.WriteLine("Enter an element:");
                        x = Convert.ToInt32(Console.ReadLine());                        
                        queue.InsertAtEnd(x);
                        break;

                    case 7:// stack.Pop();
                        queue.DeleteFromEnd();
                        break;

                    default: break;
                }
            }
        }
    }
}
