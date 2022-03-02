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
                if (visited.Contains(node)) continue;
                
                var s = new Stack<int>();
                s.Push(node);
                
                while (s.Count != 0)
                {
                    var curr = s.Pop();

                    foreach (var nei in graph[curr])
                    {
                        if (visited.Contains(nei)) continue;
                        s.Push(nei);
                        visited.Add(nei);
                    }
                }
                count++;
            }
            return count;
        }



        public static void Main(String[] args)
        {

            var x = connectedComponetsCount(new Dictionary<int, HashSet<int>>()
            {
                 {0, new HashSet<int>(){ 8, 1, 5} },
                 {1, new HashSet<int>(){ 0} },
                 {5, new HashSet<int>(){ 0, 8} },
                 {8, new HashSet<int>(){ 0, 5} },
                 {2, new HashSet<int>(){ 3, 4} },
                 {3, new HashSet<int>(){ 2, 4} },
                 {4, new HashSet<int>(){ 3,2} },
            });
        }
    }
}


