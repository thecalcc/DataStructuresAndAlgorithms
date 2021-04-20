using System;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 5, 2, -1, 512, 5, 1, 4, 9, 18, -14, -154 };
            
            SelectionSort.Sort(array);
            Console.WriteLine(string.Join(" | ", array));
        }
    }
}
