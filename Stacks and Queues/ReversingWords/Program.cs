using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReversingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> chars = new Stack<char>();
            foreach(char c in "Let's Reverse")
            {
                chars.Push(c);
            }

            while(chars.Count > 0)
            {
                Console.Write(chars.Pop());
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
