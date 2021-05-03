using System;
using System.Collections.Generic;
using System.Text;

namespace BubbleSort
{
    public static class BubbleSort
    {
        public static void Sort<T>(T[] ts) where T : IComparable
        {
            for (int i = 0; i < ts.Length; i++)
            {
                for (int j = 0; j < ts.Length; j++)
                {
                    if (ts[j].CompareTo(ts[j + 1]) > 0)
                    {
                        T temp = ts[i];
                        ts[i] = ts[j];
                        ts[j] = temp;
                    }
                }
            }
        }

        public static T[] BubbleOptimised<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                bool isAnyChange = false;

                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j].CompareTo(array[j + 1]) > 0)
                    {
                        isAnyChange = true;
                        T temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }

                if (!isAnyChange)
                {
                    break;
                }
            }
            return array;
        }
    }
}
