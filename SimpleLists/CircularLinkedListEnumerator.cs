using System.Collections;
using System.Collections.Generic;

namespace SimpleLists
{
    public class CircularLinkedListEnumerator<T> : IEnumerator<T>
    {
        private LinkedListNode<T> current;
        public T Current => current.Value;
        object IEnumerator.Current => Current;

        public CircularLinkedListEnumerator(LinkedList<T> list)
        {
            current = list.First;
        }

        public bool MoveNext()
        {
            if (current == null)
            {
                return false;
            }

            current = current.Next ?? current.List.First;
            return true;
        }

        public void Reset()
        {
            current = current.List.First;
        }

        public void Dispose() { }
    }
}