using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class HasPathUndirected
    {
        public static Dictionary<int, HashSet<int>> GetAdjecencyList(int[][] edges)
        {
            var adjecencyList = new Dictionary<int, HashSet<int>>();

            for (int i = 0; i < edges.Length; i++)
            {
                if (!adjecencyList.TryGetValue(edges[i][0], out HashSet<int> _))
                {
                    adjecencyList.Add(edges[i][0], new HashSet<int> { edges[i][1] });
                }
                else
                {
                    adjecencyList[edges[i][0]].Add(edges[i][1]);
                }
                if (!adjecencyList.TryGetValue(edges[i][1], out HashSet<int> _))
                {
                    adjecencyList.Add(edges[i][1], new HashSet<int> { edges[i][0] });
                }
                else
                {
                    adjecencyList[edges[i][1]].Add(edges[i][0]);
                }
            }
            return adjecencyList;
        }


        public static bool ValidPath(int n, int[][] edges, int source, int destination)
        {
            var adjList = GetAdjecencyList(edges);

            return hasPath(adjList, source, destination, new List<int>());

        }

        public static bool hasPath(Dictionary<int, HashSet<int>> graph, int source, int destination, List<int> visited)
        {

            var s = new Stack<int>();
            s.Push(source);
            visited.Add(source);
            while (s.Count != 0)
            {
                var curr = s.Pop();

                foreach (var neighbour in graph[curr])
                {
                    if (!visited.Contains(neighbour))
                    {
                        if (neighbour == destination) return true;
                        visited.Add(neighbour);
                        s.Push(neighbour);
                    }
                }
            }
            return false;
        }
        //public static void Main(String[] args)
        //{
        //    int[][] jaggedArray2 = new int[][] {
        //                             new int[] { 0, 1},
        //                             new int[] { 1, 2},
        //                             new int[] { 2, 0 }
        //             };
        //    ValidPath(3, jaggedArray2, 0, 2);
        //}
    }
}
