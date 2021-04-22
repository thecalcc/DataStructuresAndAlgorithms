using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleLists
{
    public class CircularLinkedList<T> : LinkedList<T>
    {
        public new IEnumerator<T> GetEnumerator()
        {
            return new CircularLinkedListEnumerator<T>(this);
        }
    }
}