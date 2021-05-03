using System;
using System.Collections.Generic;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1, letter2, letter3;

            letter1 = char.Parse(Console.ReadLine());
            letter2 = char.Parse(Console.ReadLine());
            letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0}, {1}, {2}", letter3, letter2, letter1);

            Console.WriteLine("Next values - a number and width");
            int num = int.Parse(Console.ReadLine());

            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i <= width; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine(num);
                }
            }

            // Decimal to binary


            Console.WriteLine("Insert a decimal number");

            int inp = int.Parse(Console.ReadLine());
            string result = "";

            while (inp > 1)
            {
                int reminder = inp % 2;

                result = Convert.ToString(reminder) + result;

                inp /= 2;
            }

            result = Convert.ToString(num) + result;

            Console.WriteLine("{0}", result);




        }
        // How a foreach loop works

        static IEnumerable<int> SimpleIterator()
        {
            yield return 10;
            for (int i = 0; i < 3; i++)
            {
                yield return i;
            }

            yield return 20;
        }


        static void ForeacLoop()
        {
            IEnumerable<int> enumerable = SimpleIterator();
            using (IEnumerator<int> enumerator = enumerable.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    int value = enumerator.Current;
                    Console.WriteLine(value);
                }
            }

        }
    }

    static class StaticClassDemo
    {
        public static void StaticMethod() { } // Valid - static classes can declare static methods
        /// <summary>
        /// public void InstanceMethod() { } // Invalid - static classes can't declare static methods
        /// </summary>

    }
}
