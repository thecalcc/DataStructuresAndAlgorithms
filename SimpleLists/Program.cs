using System;
using System.Collections;
using System.Collections.Generic;

namespace SimpleLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList data structure example
            ArrayList arrayList = new ArrayList();
            arrayList.Add(5);
            arrayList.AddRange(new int[] { 1, 2, 3, 4 });
            arrayList.AddRange(new object[] { "Kini", "Vini" });
            arrayList.Insert(5, 7.8);
            bool containsKini = arrayList.Contains("Kini");
            int count = arrayList.Count;
            int capacity = arrayList.Capacity;

            // Generic list 
            List<double> numbers = new List<double>();

            numbers.Add(1.2);
            numbers.Sort();
            numbers.Reverse();

            // Sorted list

            SortedList<int, string> keyValuePairs = new SortedList<int, string>();

            keyValuePairs.Add(1, "Peter1");
            keyValuePairs.Add(2, "Peter2");
            keyValuePairs.Add(3, "Peter3");

            // Linked list

            LinkedList<String> linkedList = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            linkedList.AddLast("Zoya");
            linkedList.AddLast("Shilpa");
            linkedList.AddLast("Rohit");
        }
    }
}
