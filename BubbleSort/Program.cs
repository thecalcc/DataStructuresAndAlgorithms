using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 5, 11, 12, 67, -1, -5, 70, 4, 14 };

            BubbleSort.Sort(array);

            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    }
}
