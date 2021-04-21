using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool changed = false;

                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[i]) > 0)
                    {
                        changed = true;

                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                if (!changed)
                {
                    break;
                }
            }
        }
    }
}
