using System;
using System.Collections.Generic;


namespace HackerRank.DataStructure.Graph
{
    class LargestConnectedComponentInGraph
    {
        public static int LargestConnectedComponent(Dictionary<int, HashSet<int>> graph)
        {
            var nodes = graph.Keys;

            int result = 0;
            var visited = new HashSet<int>();
            foreach (var node in nodes)
            {
                if (visited.Contains(node)) continue;
                int nodesInThisComponent = GetNodeCount(graph, node, visited);
                if (nodesInThisComponent > result) result = nodesInThisComponent;
            }
            return result;
        }


        public static int GetNodeCount(Dictionary<int, HashSet<int>> graph, int node, HashSet<int> visited)
        {
            var s = new Stack<int>();
            s.Push(node);
            visited.Add(node);
            int count = 1;

            while (s.Count != 0)
            {
                var current = s.Pop();
                foreach (var neighbour in graph[current])
                {
                    if (visited.Contains(neighbour)) continue;
                    visited.Add(neighbour);
                    s.Push(neighbour);
                    count++;

                }
            }
            return count;
        }

        //public static void Main(String[] args)
        //{

        //	var x = LargestConnectedComponent(new Dictionary<int, HashSet<int>>()
        //	{
        //		 {0, new HashSet<int>(){ 8, 1, 5} },
        //		 {1, new HashSet<int>(){ 0} },
        //		 {5, new HashSet<int>(){ 0, 8} },
        //		 {8, new HashSet<int>(){ 0, 5} },
        //		 {2, new HashSet<int>(){ 3, 4} },
        //		 {3, new HashSet<int>(){ 2, 4} },
        //		 {4, new HashSet<int>(){ 3,2} },
        //	});
        //}
    }
}
