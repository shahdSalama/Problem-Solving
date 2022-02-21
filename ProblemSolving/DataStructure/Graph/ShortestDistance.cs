using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank.DataStructure.Graph
{
    class ShortestDistance
    {
        public int shortestDistanceSolution(int[][] edges, int source, int target)
        {
            var graph = ConstructGraph(edges);
            var visited = new HashSet<int>();
            var q = new Queue<(int node, int dest)>();
            q.Enqueue((source, 0));
            while (q.Count != 0)
            {
                var (node, dest) = q.Dequeue();
                if (node == target) return dest;
                
                visited.Add(node);

                foreach (var nei in graph[node])
                {
                    if (visited.Contains(nei)) continue;
                    else
                    {
                        q.Enqueue((nei, dest + 1));
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// neat !!
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        public Dictionary<int, HashSet<int>> ConstructGraph(int[][] edges)
        {
            var graph = new Dictionary<int, HashSet<int>>();
            for (int i = 0; i < edges.Length; i++)
            {
                var a = edges[i][0];
                var b = edges[i][1];
              
                if (!graph.Keys.Contains(a)) graph.Add(a, new HashSet<int>());
                if (!graph.Keys.Contains(b)) graph.Add(b, new HashSet<int>());

                graph[a].Add(b);
                graph[b].Add(a);

            }
            return graph;
        }
    }
}
