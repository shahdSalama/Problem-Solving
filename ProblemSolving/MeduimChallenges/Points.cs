//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HackerRank.MeduimChallenges
//{
//    class Points
//    {

//        public int MinCostConnectPoints(int[][] points)
//        {
//            Dictionary<int, HashSet<(int, int)>> adjList = new Dictionary<int, HashSet<(int, int)>>();
//            for (int i = 0; i < points.Length; i++)
//            {
//                int x1 = points[i][0]; int y1 = points[i][1];

//                for (int j = i; j < points.Length; j++)
//                {
//                    int x2 = points[j][0]; int y2 = points[j][1];
//                    // calculated distance
//                    var d = Math.Abs(x1 - x2) + Math.Abs(y1 - y2);
//                    if (adjList.TryGetValue(i, out var edges))
//                        edges.Add((d, j));
//                    else adjList.Add(i, new HashSet<(int, int)> { (d, j) });

//                    if (adjList.TryGetValue(j, out var egdesJ))
//                        egdesJ.Add((d, i));
//                    else adjList.Add(j, new HashSet<(int, int)> { (d, i) });

//                }

//            }
//            PriorityQueue<(int, int), int> q = new PriorityQueue<(int, int), int>();
//            q.Enqueue((0, 0));
//            var visited = new HashSet<int>();
//            int dist = 0;
//            while (visited.Count != points.Length)
//            {
//                (int d, int currNode) = q.Dequeue();
//                if (visited.Contains(currNode)) continue;
//                visited.Add(currNode);
//                dist += d;

//                for (int i = 0; i < points.Length; i++)
//                {
//                    if (i == currNode) continue;
//                    if (visited.Contains(i)) continue;
//                    // get distance between i and currNode
//                    var currNodeEdges = adjList[currNode];
//                    var iEdgeDistance = currNodeEdges.FirstOrDefault(x => x.Item2 == i).Item1;
//                    q.Enqueue((iEdgeDistance, i), iEdgeDistance);

//                }


//            }
//            return dist;

//        }

//       
//    }

//}
