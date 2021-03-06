using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Node<T>
    {
        public int Index { get; set; }
        public T Data { get; set; }
        public List<Node<T>> Neighbours { get; set; } = new List<Node<T>>();
        public List<int> Weights { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"Node with index {Index}: {Data}, neighbours: {Neighbours.Count}";
        }
    }
}
