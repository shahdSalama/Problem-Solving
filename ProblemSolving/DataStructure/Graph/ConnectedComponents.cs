using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class ConnectedComponents
    {
        public static int connectedComponetsCount(Dictionary<int, HashSet<int>> graph)
        {
            int count = 0;
            var nodes = graph.Keys;
            var visited = new List<int>();

            foreach (var node in nodes)
            {
                if (Explore(graph, node, visited))
                    count++;
            }
            return count;
        }

        private static bool Explore(Dictionary<int, HashSet<int>> graph, int node, List<int> visited)
        {
            if (visited.Contains(node)) return false;
            var s = new Stack<int>();

            s.Push(node);
            visited.Add(node);
            while (s.Count != 0)
            {
                var curr = s.Pop();
                foreach (var neighbour in graph[curr])
                {
                    if (visited.Contains(neighbour)) continue;
                    visited.Add(neighbour);
                    s.Push(neighbour);
                }
            }
            return true;
        }

        //public static void Main(String[] args)
        //{

        //    var x = connectedComponetsCount(new Dictionary<int, HashSet<int>>()
        //    {
        //         {0, new HashSet<int>(){ 8, 1, 5} },
        //         {1, new HashSet<int>(){ 0} },
        //         {5, new HashSet<int>(){ 0, 8} },
        //         {8, new HashSet<int>(){ 0, 5} },
        //         {2, new HashSet<int>(){ 3, 4} },
        //         {3, new HashSet<int>(){ 2, 4} },
        //         {4, new HashSet<int>(){ 3,2} },
        //    });
        //}
    }
}
