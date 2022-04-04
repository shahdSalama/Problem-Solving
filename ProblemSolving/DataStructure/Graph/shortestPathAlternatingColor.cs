using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class shortestPathAlternatingColor
    {
        public int[] ShortestAlternatingPaths(int n, int[][] redEdges, int[][] blueEdges)
        {

            var redDic = ConstructDictionary(redEdges);
            var blueDic = ConstructDictionary(blueEdges);
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                res[i] = ShortestAlternatingPathsForANode(i, redDic, blueDic);
            }
            return res;
        }

        private Dictionary<int, List<int>> ConstructDictionary(int[][] edges)
        {
            var edgesDic = new Dictionary<int, List<int>>();

            for (int i = 0; i < edges.Length; i++)
            {
                if (edgesDic.TryGetValue(edges[i][0], out var val))
                    val.Add(edges[i][1]);


                else
                    edgesDic.Add(edges[i][0], new List<int> { edges[i][1] });
            }
            return edgesDic;

        }

        private int ShortestAlternatingPathsForANode(int target, Dictionary<int, List<int>> red, Dictionary<int, List<int>> blue)
        {
            // we want to find the shortest path (bfs) from node 0 to target node with aternating edges color.
            // we keep track of las used edge color to get to the current node in order to be able to get to the next nodes
            var visited = new HashSet<(int, int)>();
            // color 1 = red , 2, blue , 0 both
            var q = new Queue<(int node, int coloer, int steps)>();
            q.Enqueue((0, 0, 0));

            while (q.Count != 0)
            {
                (int currNode, int currColor, int currSteps) = q.Dequeue();

                if (currNode == target) return currSteps;
                if (visited.Contains((currNode, currColor))) continue;

                // check curr color and see the opesite color can take us where

                if (currColor == 0) // first node
                {

                    // see if i have any blue edged
                    if (blue.TryGetValue(currNode, out var blueEdgesNodes))
                    {
                        foreach (var blueEdgeNode in blueEdgesNodes)
                        {
                            q.Enqueue((blueEdgeNode, 2, currSteps + 1));
                        }
                    }

                    if (red.TryGetValue(currNode, out var redEdgesNodes))
                    {
                        foreach (var redEdgeNode in redEdgesNodes)
                        {
                            q.Enqueue((redEdgeNode, 1, currSteps + 1));
                        }
                    }
                }

                if (currColor == 1) // red
                {
                    // next edge should be blue
                    if (blue.TryGetValue(currNode, out var blueEdgesNodes1))
                    {
                        foreach (var blueEdgeNode1 in blueEdgesNodes1)
                        {
                            q.Enqueue((blueEdgeNode1, 2, currSteps + 1));
                        }
                    }
                }

                if (currColor == 2) // blue
                                    // next edge should be red
                {
                    if (red.TryGetValue(currNode, out var redEdgesNodes1))
                    {
                        foreach (var redEdgeNode1 in redEdgesNodes1)
                        {
                            q.Enqueue((redEdgeNode1, 1, currSteps + 1));
                        }
                    }

                }

            }
            return -1;

        }



    }
}
