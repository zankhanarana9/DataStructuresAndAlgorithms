using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    internal class QuickUnion
    {
        int[] array;
        public QuickUnion(int n)
        {
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            int pId = Root(p);
            int qId = Root(q);
            array[pId] = qId;
        }

        public bool Connected(int p, int q)
        {
            return Root(p) == Root(q);
        }

        private int Root(int p)
        {
            while (p != array[p])
            {
                p = array[p];
            }
            return p;
        }
    }
}
