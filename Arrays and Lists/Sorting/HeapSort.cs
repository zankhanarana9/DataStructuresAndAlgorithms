using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class HeapSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            BuildMaxHeap(array);
            for(int i = array.Length-1; i> 0;i--)
            {
                Swap.swap(array,0,i);
                MaxHeapify(array,i, 0);
            }
        }

        private static void MaxHeapify<T>(T[] array, int heapSize, int i) where T : IComparable
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < heapSize && array[largest].CompareTo(array[left]) < 0 )
            {
                largest = left;
            }
            if (right < heapSize && array[largest].CompareTo(array[right]) < 0)
            {
                largest = right;
            }
            if(largest != i)
            {
                Swap.swap(array, i, largest);
                MaxHeapify(array, heapSize, largest);
            }
        }

        private static void BuildMaxHeap<T>(T[] array) where T : IComparable
        {
            int heapSize = array.Length;
            for (int i = array.Length / 2 -1; i >= 0; i--)
            {
                MaxHeapify(array, heapSize, i);
            }
        }
    }
}
