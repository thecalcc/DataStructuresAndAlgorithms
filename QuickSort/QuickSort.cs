using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    public static class QuickSort
    {
        public static void Sort<T>(T[] array, int low, int high) where T : IComparable
        {
            if (low < high)
            {
                int p = Partition(array, low, high);

                Sort(array, low, p);
                Sort(array, p + 1, high);
            }
        }

        public static int Partition<T>(T[] array, int low, int high) where T : IComparable
        {
            int i = low;
            int j = high;
            T pivot = array[low];

            do
            {
                while (array[i].CompareTo(pivot) < 0) { i++; }
                while (array[j].CompareTo(pivot) > 0) { j--; }
                
                if (i >= j) break;
                
                T temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            } 
            while (i <= j);

            return j;
        } 
    }
}
