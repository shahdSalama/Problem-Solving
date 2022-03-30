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



       
    }
}


