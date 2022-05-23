using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class connectedComp
    {
        static int numConnected(int[][] edges)
        {
            var graph = new Dictionary<int, HashSet<int>>();
            foreach (var edge in edges)
            {
                if (!graph.Keys.Contains(edge[0]))
                    graph.Add(edge[0], new HashSet<int>());
                graph[edge[0]].Add(edge[1]);
            }
            var visited = new HashSet<int>();
            int count = 0;
            foreach (var node in graph.Keys)
            {
                count += explore(node, graph, visited);
            }
            return count;
        }

        private static int explore(int node, Dictionary<int, HashSet<int>> graph, HashSet<int> visited)
        {
            if (visited.Contains(node)) return 0;
            var s = new Stack<int>();
            s.Push(node);
            while (s.Count != 0)
            {
                int currNode = s.Pop();
                if (visited.Contains(currNode)) continue;
                visited.Add(currNode);
                if (!graph.Keys.Contains(currNode)) continue;
                foreach (var nei in graph[currNode])
                {
                    s.Push(nei);
                }
            }
            return 1;
        }
       
    }
}
