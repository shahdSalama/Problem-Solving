using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class EvaluateDivision
    {
        public class Solution
        {
            public double[] CalcEquation(IList<IList<string>> equations, double[] values, IList<IList<string>> queries)
            {

                var res = new double[queries.Count];
                var chars = new HashSet<string>();
                var graph = new Dictionary<string, List<(string, double)>>();
                for (int i = 0; i < equations.Count; i++)
                {
                    if (graph.Keys.Contains(equations[i][0]))
                        graph[equations[i][0]].Add((equations[i][1], values[i]));
                    else graph.Add(equations[i][0], new List<(string, double)> { (equations[i][1], values[i]) });

                    if (graph.Keys.Contains(equations[i][1]))
                        graph[equations[i][1]].Add((equations[i][0], 1 / values[i]));
                    else graph.Add(equations[i][1], new List<(string, double)> { (equations[i][0], 1 / values[i]) });
                    chars.Add(equations[i][0]);
                    chars.Add(equations[i][1]);

                }


                for (int i = 0; i < queries.Count; i++)
                {
                    if (!chars.Contains(queries[i][0]) || !chars.Contains(queries[i][1])) res[i] = -1.0;
                    else res[i] = explore(queries[i], graph);
                }
                return res;
            }

            private double explore(IList<string> query, Dictionary<string, List<(string, double)>> graph)
            {
                var source = query[0];
                var target = query[1];
                var visited = new HashSet<string>();
                var s = new Stack<(string, double)>();
                s.Push((source, 1));
                while (s.Count != 0)
                {
                    (string currNode, double currValue) = s.Pop();
                    if (currNode == target) return currValue;
                    if (visited.Contains(currNode)) continue;
                    visited.Add(currNode);

                    if (!graph.Keys.Contains(currNode)) continue;
                    foreach (var nei in graph[currNode])
                    {
                        (string neiNode, double neiValue) = nei;
                        s.Push((neiNode, currValue * neiValue));
                    }
                
                }
                return -1.0;
            }
        }
    }
}

