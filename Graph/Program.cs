using System;
using System.Collections.Generic;

namespace Graph
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph<int> graph = new Graph<int>(true, true);
            Node<int> n1 = graph.AddNode(1);
            Node<int> n2 = graph.AddNode(2);
            Node<int> n3 = graph.AddNode(3);
            Node<int> n4 = graph.AddNode(4);
            Node<int> n5 = graph.AddNode(5);
            Node<int> n6 = graph.AddNode(6);
            Node<int> n7 = graph.AddNode(7);
            Node<int> n8 = graph.AddNode(8);
            Node<int> n9 = graph.AddNode(9);


            graph.AddEdge(n1, n2, 9);
            graph.AddEdge(n8, n5, 3);
            

            //DFS nodes
            List<Node<int>> dfsNodes = graph.DFS();
            dfsNodes.ForEach(x => Console.WriteLine(x));

            //BFS nodes
            List<Node<int>> bfsNodes = graph.BFS();
            bfsNodes.ForEach(x => Console.WriteLine(x));

            //MinimumSpanningTreeKruskal 
            List<Edge<int>> mstKruskal = graph.MinimumSpanningTreeKruskal();
            mstKruskal.ForEach(x => Console.WriteLine(x));

            //MinimumSpanningTreePrim
            List<Edge<int>> mstPrim = graph.MinimumSpanningTreePrim();
            mstPrim.ForEach(x => Console.WriteLine(x));
        }
    }
}
