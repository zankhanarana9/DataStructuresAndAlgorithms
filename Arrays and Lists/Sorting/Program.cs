using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteHeader("Heap Sort", false);
            HeapSortTest();

            WriteHeader("Merge Sort", false);
            MergeSortTest();

            WriteHeader("SELECTION SORT", false);
            SelectionTest();

            WriteHeader("INSERTION SORT");
            InsertionTest();

            WriteHeader("BUBBLE SORT");
            BubbleTest();

            WriteHeader("OPTIMIZED BUBBLE SORT");
            OptimizedBubbleTest();

            WriteHeader("QUICKSORT");
            QuicksortTest();
           
            Console.ReadKey();

        }

        static void HeapSortTest()
        {
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            HeapSort.Sort(arr);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            HeapSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));

        }
        static void MergeSortTest()
        {
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            MergeSort.Sort(arr, 0, arr.Length - 1);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            MergeSort.Sort(stringValues,0,stringValues.Length-1);
            Console.WriteLine(string.Join(" | ", stringValues));

        }

        static void QuicksortTest()
        {   
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            QuickSort.Sort(arr);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            QuickSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        static void OptimizedBubbleTest()
        {
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            BubbleSort.OptimizedSort(arr);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            BubbleSort.OptimizedSort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        static void SelectionTest()
        {
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            SelectionSort.Sort(arr);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            SelectionSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        static void InsertionTest()
        {
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            InsertionSort.RecuriveSort(arr,arr.Length);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            InsertionSort.RecuriveSort(stringValues, stringValues.Length);
            Console.WriteLine(string.Join(" | ", stringValues));
        }

        static void BubbleTest()
        {
            int[] arr = { -11, 12, -42, 0, 1, 90, 68, 6, -9 };
            BubbleSort.Sort(arr);
            Console.WriteLine(string.Join(" | ", arr));

            string[] stringValues = { "Mary", "Marcin", "Ann", "James", "George", "Nicole" };
            BubbleSort.Sort(stringValues);
            Console.WriteLine(string.Join(" | ", stringValues));
        }
        static void WriteHeader(string header, bool addLine = true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine((addLine ? Environment.NewLine : string.Empty) + header);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
