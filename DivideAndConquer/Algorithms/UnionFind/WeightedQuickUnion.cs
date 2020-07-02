using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    internal class WeightedQuickUnion
    {
        int[] array;
        int size;
        int[] sz;

        public WeightedQuickUnion(int n)
        {
            size = n;
            sz = new int[n];
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = i;
                sz[i] = 1;
            }
        }

        public void Union(int p, int q)
        {
            int pId = Root(p);
            int qId = Root(q);
            if (pId == qId) return;
            if(sz[pId] < sz[qId])
            {
                array[pId] = qId;
                sz[qId] += sz[pId];
            }
            else
            {
                array[qId] = pId;
                sz[pId] += sz[qId];
            }
            size--;           
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
