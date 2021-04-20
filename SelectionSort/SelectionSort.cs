using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            // First loop
            for (int i = 0; i < array.Length - 1; i++)
            {
                // Get the min index which is i.
                int minIndex = i;
                
                // Get the first element and set it as the min value.
                T min = array[i];

                // Loop through the rest of the elements starting from one index after the minimum one.
                for (int j = i + 1; j < array.Length; j++)
                {
                    // If the next item has a lower value the minimum index is set to j.
                    // Also the min value is set to the element with the min index from the array.
                    if (array[j].CompareTo(min) < 0)
                    {
                        minIndex = j;
                        min = array[j];
                    }
                }

                // A temp variable holds the previous minimum value with 
                // index of i - the last known min index in the scope of the outer loop.
                T temp = array[i];

                // The two values are swapped.
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
}
