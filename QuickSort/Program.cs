using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 11, 12, 67, -1, -5, 70, 4, 14 };

            QuickSort.Sort(array, 0, array.Length - 1);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
