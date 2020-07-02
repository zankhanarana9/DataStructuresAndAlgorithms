using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            WeightedQuickUnion weighted = new WeightedQuickUnion(n);
            weighted.Union(0, 1);
            weighted.Union(2, 3);
            weighted.Union(4, 5);
            weighted.Union(5, 0);
            weighted.Union(6, 7);
            weighted.Union(8, 9);
            weighted.Union(0, 8);

            bool found = weighted.Connected(9, 0);
        }
    }
}
