using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PracticingDifferentFeatures
{
    class MultidimentionalArrays
    {
        int[] numbers = new int[6];

        public void FillArray(int a = 5, int b = 6, int c = 7, int d = 8, int e = 9, int f = 10, int g = 11)
        {
            numbers[0] = a;
            numbers[1] = b;
            numbers[2] = c;
            numbers[3] = d;
            numbers[4] = e;
            numbers[5] = f;
            numbers[6] = g;
        }

        int[] numberTwo = new int[5] { 1, 2, 3, 4, 5 };

        public void GetMid(int[] array)
        {
            int mid = array[array.Length - 1] / 2;
        }

        string[] months = new string[12];

        public void FillMonths(int[] array)
        {
            // Start from 1 since we care about the months, which are 12, and the indexed items are from 0 to 11
            // then we populate them with index [i - 1]
            for (int i = 1; i <= 12; i++)
            {
                // Get the first day of month number "i"
                DateTime firstDay = new DateTime(DateTime.Now.Year, i, 1);
                string name = firstDay.Day.ToString("MMMM", 
                    CultureInfo.CreateSpecificCulture("en"));
                
                // Populate 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11th index
                months[i - 1] = name;
            }

            foreach (string month in months)
            {
                Console.WriteLine($"-> {month}");
            }
        }

        int[,] results = new int[10, 10];

        // GetLength method -> the length of a set array dimention
        public void MultiplicationTable(int[,] array)
        {
            for (int i = 0; i < results.GetLength(0); i++)
            {
                for (int j = 0; j < results.GetLength(1); j++)
                {
                    results[i, j] = (i + 1) * (j + 1);
                    Console.Write("{0, 4}", results[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
