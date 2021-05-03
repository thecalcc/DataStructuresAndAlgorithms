using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    public static class InsertionSort
    {
        public static void InsertionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                int j = i;

                while (j > 0 && array[j].CompareTo(array[j - 1]) < 0)
                {
                    T temp = array[j];
                    array[j] = array[j - 1];
                    array[j - 1] = temp;

                    j--;
                }
            }
        }
    }
}