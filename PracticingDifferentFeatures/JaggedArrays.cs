using System;
using System.Collections.Generic;
using System.Text;

namespace PracticingDifferentFeatures
{
    /// <summary>
    /// Can be described as an array of arrays. A single dimention one.
    /// </summary>
    public class JaggedArrays
    {
        static int[][] numbers = new int[4][];

        public static void FillNumbersJaggedArray()
        {
            numbers[0] = new int[] { 9, 5, 1 };
            numbers[1] = new int[] { 0, -3, 12, 51, -3 };
            numbers[3] = new int[] { 54, 1, 2 };
        }

        int[][] numsDifferentFill =
        {
            new int[] {9, 5, -1 },
            new int[] {0, -3, 51, 12},
            new int[] {51, 154, 123,},
            null
        };
    }
}
