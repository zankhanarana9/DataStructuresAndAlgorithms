using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] results = new int[10, 10];
            for(int i = 0; i < results.GetLength(0); i++)
            {
               for(int j = 0; j < results.GetLength(1); j++)
                {
                    results[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    Console.Write("{0,4}" ,results[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
