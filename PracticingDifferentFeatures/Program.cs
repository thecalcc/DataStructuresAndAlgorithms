using System;

namespace PracticingDifferentFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            MultidimentionalArrays diff = new MultidimentionalArrays();

            int[,] res = new int[10, 10];

            diff.MultiplicationTable(res);
        }
    }
}
