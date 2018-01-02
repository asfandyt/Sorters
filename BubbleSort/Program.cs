using System;
using Sort.Algorithms;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[]{ 3, 7, 2, 5, 1, 6, 4};

            var bubbleSort = new BubbleSort();
            bubbleSort.List = list;

            Console.WriteLine("Unsorted List: \n" );
            
            bubbleSort.PrintTheList();

            Console.WriteLine("Descending Sort: \n");

            bubbleSort.SortIntDesc();
            bubbleSort.PrintTheList();

            Console.ReadLine();
        }
    }
}
