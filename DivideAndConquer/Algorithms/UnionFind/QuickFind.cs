using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnionFind
{
    internal class QuickFind
    {
        int[] array;
        public QuickFind(int n)
        {
            array = new int[n];
            for(int i =0; i < n; i++)
            {
                array[i] = i;
            }
        }

        public void Union(int p, int q)
        {
            int pId = array[p];
            int qId = array[q]; 
            if(array[p] == array[q])
            {
                Console.WriteLine("Already connected");
                return;
            }

            for(int i =0;i < array.Length; i++)
            {
                if(array[i] == pId)
                {
                    array[i] = qId;
                }
            }
        }

        public bool Connected(int p, int q)
        {
            return array[p] == array[q];
        }
    }
}
