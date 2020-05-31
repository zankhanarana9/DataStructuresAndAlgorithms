using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CircularLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList<string> Categories = new CircularLinkedList<string>();
            Categories.AddLast("Sport");
            Categories.AddLast("Culture");
            Categories.AddLast("History");
            Categories.AddLast("Geography");
            Categories.AddLast("People");
            Categories.AddLast("Technology");
            Categories.AddLast("Nature");
            Categories.AddLast("Science");

            Random random = new Random();
            int totalTime = 0;
            int remainingTime = 0;
            foreach(string category in Categories)
            {
                if(remainingTime <= 0 )
                {
                    Console.WriteLine("Press [Enter] to startor any other key to exit.");
                    switch(Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            totalTime = random.Next(1000, 5000);
                            remainingTime = totalTime;
                            break;

                        default: return;
                    }
                }

                int categoryTime = (-450 * remainingTime) / (totalTime - 50) + 500 + (22500 / (totalTime - 50));
                remainingTime -= categoryTime;
                Thread.Sleep(categoryTime);

                Console.ForegroundColor = remainingTime <= 0 ? ConsoleColor.Red : ConsoleColor.Gray;
                Console.WriteLine(category);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.Read();
        }
    }
}
