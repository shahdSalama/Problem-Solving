using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class safewithmemo
    {
        public class Solution
        {
            public IList<int> EventualSafeNodes(int[][] graph)
            {

                var eventual = new List<int>();

                var memo = new HashSet<(int, bool)>();

                // add terminal nodes as eventual
                for (int i = 0; i < graph.Length; i++)
                {
                    if (graph[i].Length == 0)
                        memo.Add((i, true));
                }

                // explore each node to see if all its out connections reach to a terminal and memo the result
                for (int i = 0; i < graph.Length; i++)
                {
                    var res = explore(i, memo, graph);
                    memo.Add((i, res));
                }

                foreach (var pair in memo)
                {
                    if (pair.Item2)
                        eventual.Add(pair.Item1);
                }
                return eventual;


            }
            //  visited = 0, 2,1.,3
            //   s  2 
            private bool explore(int node, HashSet<(int, bool)> memo, int[][] graph)
            {
                if (memo.Contains((node, false))) return false;
                if (memo.Contains((node, true))) return true;
                var visited = new HashSet<int>();
                var s = new Stack<int>();

                s.Push(node);

                while (s.Count != 0)
                {
                    var currNode = s.Pop();
                    if (visited.Contains(currNode))
                        return false;
                    visited.Add(currNode);



                    foreach (var connection in graph[node])
                    {
                        if (memo.Contains((connection, true))) continue;
                        if (memo.Contains((connection, false))) return false;
                        s.Push(connection);


                    }


                }

                return true;

            }

        }
    }
}
