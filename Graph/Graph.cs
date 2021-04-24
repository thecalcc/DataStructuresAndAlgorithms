using System;
using System.Collections.Generic;
using System.Text;

namespace Graph
{
    public class Graph<T>
    {
        private bool _isDirected = false;
        private bool _isWeighted = false;
        public List<Node<T>> Nodes { get; set; } = new List<Node<T>>();

        public Graph(bool isDirected, bool isWeighted)
        {
            _isDirected = isDirected;
            _isWeighted = isWeighted;
        }

        public Edge<T> this[int from, int to]
        {
            get
            {
                Node<T> nodeFrom = Nodes[from];
                Node<T> nodeTo = Nodes[to];

                int i = nodeFrom.Neighbours.IndexOf(nodeTo);

                if (i >= 0)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        From = nodeFrom,
                        To = nodeTo,
                        Weight = i < nodeFrom.Weights.Count ? nodeFrom.Weights[i] : 0
                    };
                    return edge;
                }

                return null;
            }
        }

        public Node<T> AddNode(T value)
        {
            Node<T> node = new Node<T>() { Data = value };
            Nodes.Add(node);
            UpdateIndices();
            return node;
        }

        public void RemoveNode(Node<T> nodeToRemove)
        {
            Nodes.Remove(nodeToRemove);
            UpdateIndices();
            foreach (Node<T> node in Nodes)
            {
                RemoveEdge(node, nodeToRemove);
            }
        }

        public void AddEdge(Node<T> from, Node<T> to, int weight = 0)
        {
            from.Neighbours.Add(to);
            if (_isWeighted)
            {
                from.Weights.Add(weight);
            }

            if (!_isDirected)
            {
                to.Neighbours.Add(from);

                if (!_isDirected)
                {
                    to.Neighbours.Add(from);

                    if (_isWeighted)
                    {
                        to.Weights.Add(weight);
                    }
                }
            }
        }

        public void RemoveEdge(Node<T> from, Node<T> to)
        {
            int index = from.Neighbours.FindIndex(x => x == to);
            if (index >= 0)
            {
                from.Neighbours.RemoveAt(index);
            }
        }

        public List<Edge<T>> GetEdges()
        {
            List<Edge<T>> edges = new List<Edge<T>>();

            foreach (Node<T> from in Nodes)
            {
                for (int i = 0; i < from.Neighbours.Count; i++)
                {
                    Edge<T> edge = new Edge<T>()
                    {
                        From = from,
                        To = from.Neighbours[i],
                        Weight = i < from.Weights.Count ? from.Weights[i] : 1
                    };

                    edges.Add(edge);
                }
            }
            return edges;
        }

        private void UpdateIndices()
        {
            int i = 0;
            Nodes.ForEach(x => x.Index = i++);
        }

        public List<Node<T>> DFS()
        {
            bool[] isVisited = new bool[Nodes.Count];
            List<Node<T>> result = new List<Node<T>>();
            DFS(isVisited, Nodes[0], result);
            return result;
        }

        // Depth-first search
        private void DFS(bool[] isVisited, Node<T> node, List<Node<T>> result)
        {
            result.Add(node);
            isVisited[node.Index] = true;

            foreach (Node<T> neighbour in node.Neighbours)
            {
                if (!isVisited[neighbour.Index])
                {
                    DFS(isVisited, neighbour, result);
                }
            }
        }

        public List<Node<T>> BFS()
        {
            return BFS(Nodes[0]);
        }

        // Breadth-first search
        private List<Node<T>> BFS(Node<T> node)
        {
            bool[] isVisited = new bool[Nodes.Count];
            isVisited[node.Index] = true;

            List<Node<T>> result = new List<Node<T>>();
            Queue<Node<T>> queue = new Queue<Node<T>>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                Node<T> next = queue.Dequeue();
                result.Add(next);

                foreach (Node<T> neighbour in next.Neighbours)
                {
                    if (!isVisited[neighbour.Index])
                    {
                        isVisited[neighbour.Index] = true;
                        queue.Enqueue(neighbour);
                    }
                }
            }

            return result;
        }

        public List<Edge<T>> MinimumSpanningTreeKruskal()
        {
            List<Edge<T>> edges = GetEdges();
            edges.Sort((a, b) => a.Weight.CompareTo(b.Weight));
            Queue<Edge<T>> queue = new Queue<Edge<T>>(edges);

            Subset<T>[] subsets = new Subset<T>[Nodes.Count];

            for (int i = 0; i < Nodes.Count; i++)
            {
                subsets[i] = new Subset<T>() { Parent = Nodes[i] };
            }

            List<Edge<T>> result = new List<Edge<T>>();

            while (result.Count < Nodes.Count - 1)
            {
                Edge<T> edge = queue.Dequeue();
                Node<T> from = GetRoot(subsets, edge.From);
                Node<T> to = GetRoot(subsets, edge.To);

                if (from != to)
                {
                    result.Add(edge);
                    Union(subsets, from, to);
                }
            }

            return result;
        }

        private Node<T> GetRoot(Subset<T>[] subsets, Node<T> node)
        {
            if (subsets[node.Index].Parent != node)
            {
                subsets[node.Index].Parent = GetRoot(
                    subsets, subsets[node.Index].Parent);
            }

            return subsets[node.Index].Parent;
        }

        private void Union(Subset<T>[] subsets, Node<T> a, Node<T> b)
        {
            if (subsets[a.Index].Rank > subsets[b.Index].Rank)
            {
                subsets[b.Index].Parent = a;
            }
            else if(subsets[a.Index].Rank < subsets[b.Index].Rank)
            {
                subsets[a.Index].Parent = b;
            }
            else
            {
                subsets[b.Index].Parent = a;
                subsets[a.Index].Rank++;
            }
        }

        //MinimumSpanningTreePrim
        public List<Edge<T>> MinimumSpanningTreePrim()
        {
            int[] previous = new int[Nodes.Count];
            previous[0] = -1;

            int[] minWeight = new int[Nodes.Count];
            Fill(minWeight, int.MaxValue);
            minWeight[0] = 0;

            bool[] isInMST = new bool[Nodes.Count];
            Fill(isInMST, false);

            for (int i = 0; i < Nodes.Count; i++)
            {
                int minWeightIndex = GetMinimumWeightIndex(
                    minWeight, isInMST);
                isInMST[minWeightIndex] = true;

                for (int j = 0; j < Nodes.Count; j++)
                {
                    Edge<T> edge = this[minWeightIndex, j];
                    int weight = edge != null ? edge.Weight : -1;
                    if (edge != null && !isInMST[i] && weight < minWeight[i])
                    {
                        previous[i] = minWeightIndex;
                        minWeight[j] = weight;
                    }
                }
            }

            List<Edge<T>> result = new List<Edge<T>>();

            for (int i = 1; i < Nodes.Count; i++)
            {
                Edge<T> edge = this[previous[i], i];
                result.Add(edge);
            }

            return result;
        }

        private int GetMinimumWeightIndex(int[] weights, bool[] isInMST)
        {
            int minValue = int.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < Nodes.Count; i++)
            {
                if (!isInMST[i] && weights[i] < minValue)
                {
                    minValue = weights[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        private void Fill<Q>(Q[] array, Q value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = value;
            }
        }

        public int[] Color()
        {
            int[] colors = new int[Nodes.Count];
            Fill(colors, -1);
            colors[0] = 0;

            bool[] avaliability = new bool[Nodes.Count];

            for (int i = 1; i < Nodes.Count; i++)
            {
                Fill(avaliability, true);

                int colorIndex = 0;

                foreach (Node<T> neighbour in Nodes[i].Neighbours)
                {
                    colorIndex = colors[neighbour.Index];
                    if (colorIndex >= 0)
                    {
                        avaliability[colorIndex] = false;
                    }
                }

                colorIndex = 0;

                for (int j = 0; j < avaliability.Length; j++)
                {
                    if (avaliability[j])
                    {
                        colorIndex = j;
                        break;
                    }
                }

                colors[i] = colorIndex;
            }

            return colors;
        }
    }
}
