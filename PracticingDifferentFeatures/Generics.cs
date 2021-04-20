using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace PracticingDifferentFeatures
{
    public class Generics
    {
        public static List<T> CopyAtMost<T>(List<T> input, int maxElements)
        {
            int actualCount = Math.Min(input.Count, maxElements);

            List<T> ret = new List<T>(actualCount);

            for (int i = 0; i < ret.Count; i++)
            {
                ret.Add(input[i]);
            }

            return ret;
        }

        static void SecondMain()
        {
            List<int> numbers = new List<int>();

            numbers.Add(5);
            numbers.Add(3);
            numbers.Add(1);

            List<int> firstTwo = CopyAtMost<int>(numbers, 2);
            Console.WriteLine(firstTwo.Count);
        }

        static void PrintItems<T>(List<T> items) where T : IFormattable
        {
            CultureInfo culture = new CultureInfo(1);

            foreach (T item in items)
            {
                Console.WriteLine(item.ToString(null, culture));
            }
        }

        static void TwoTypeArgs<TArg, TResult>(TArg input) where TArg : IComparable<TArg>
                                                           where TResult : class, new()
        {
            Console.WriteLine("Do something");
        }

        static void PrintType<T>()
        {
            Console.WriteLine("typeof(T) = {0}", typeof(T));
            Console.WriteLine("typeof(List<T>) = {0}", typeof(List<T>));
        }

        static void PrintValueAsInt32(object o)
        {
            int? nullable = o as int?;
            Console.WriteLine(nullable.HasValue ? nullable.Value.ToString() : "null");
        }

        static void TestPrint()
        {
            // Prints 5
            PrintValueAsInt32(5);
            
            // Prints null
            PrintValueAsInt32("some string");
        }
    }

    class GenericCounter<T>
    {
        private static int value;

        static GenericCounter()
        {
            Console.WriteLine("Initializing counter for {0}", typeof(T));
        }

        public static void Increment()
        {
            value++;
        }

        public static void Display()
        {
            Console.WriteLine("Counter for {0}: {1}", typeof(T), value);
        }
    }

    class GenericCounterDemo
    {
        static void AnotherMain()
        {
            GenericCounter<string>.Increment();
            GenericCounter<string>.Increment();
            GenericCounter<string>.Display();
           
            GenericCounter<int>.Increment();
            GenericCounter<int>.Display();
        }
    }

    /// <summary>
    /// Arity - The generic arity of a declaration is the number of type parameters it ahs. 
    /// You can think of a nongeneric declaration as one with generic arity 0.
    /// </summary>
    /// <typeparam name="G"></typeparam>

    public class CustomList<G> : IEnumerable<G>
    {
        public IEnumerator<G> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

    public struct CustomNullable<T> where T : struct
    {
        private readonly T value;
        private readonly bool hasValue;

        public CustomNullable(T value)
        {
            this.value = value;
            this.hasValue = true;
        }

        public bool HasValue { get { return hasValue; } }

        public T Value
        {
            get
            {
                if (!hasValue)
                {
                    throw new InvalidOperationException();
                }
                return value;
            }            
        }
    } 
}
