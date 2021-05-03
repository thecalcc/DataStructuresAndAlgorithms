using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MessingAround
{
    class Program
    {

        // Stack overflow
        static void Main(string[] args)
        {
            MyDict<int, string> myDict = new MyDict<int, string>();

            myDict.Add(1, "rand1");
            myDict.Add(2, "rand2");
            myDict.Add(3, "rand3");
            myDict.Add(4, "rand4");
            myDict.Add(5, "rand5");
            myDict.Add(6, "rand6");
            myDict.Add(7, "rand7");
            myDict.Add(8, "rand8");
            myDict.Add(9, "rand9");
            myDict.Add(10, "rand10");
            myDict.Add(11, "rand11");
            myDict.Add(12, "rand12");

            foreach (string vale in myDict)
            {
                Console.WriteLine(myDict.ToString());
            }
        }
    }

    public interface IDict<TKey, TValue> 
    {
        public TKey Get(TKey param);
        public void Add(TKey key, TValue value);
    }

    public class MyDict<GKey, GValue> : IDict<GKey, GValue>, IEnumerable
    {
        private MyDict<GKey, GValue> dictionary = new MyDict<GKey, GValue>();
        public MyDict<GKey,GValue> Dictionary { get; set; }

        public MyDict()
        {
        }

        public GKey Get(GKey key)
        {
            return Dictionary.Get(key);
        }

        public void Add(GKey key, GValue value)
        {
            Dictionary.Add(key, value);
        }

        public IEnumerator GetEnumerator()
        {
            return Dictionary.GetEnumerator();
        }
    }

    public class IIndexer<T>
    {
        private T[] array = new T[100];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public T GetT(int i)
        {
            return array[i];
        }

        public void SetT(T value)
        {
            array.SetValue(value, Convert.ToInt32(array.Last()) + 1);
        }
    }
}
