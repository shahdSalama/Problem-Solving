using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class connections
    {



        public int MakeConnected(int n, int[][] connections)
        {
            var dic = ConstructGraph(connections, n);
            var numberOfConnectedComp = GetConnectedCompNumber(dic,  n);
            return (connections.Length >= n - 1) ? numberOfConnectedComp - 1 : -1;

        }

        private int GetConnectedCompNumber(Dictionary<int, List<int>> dic, int n)
        {
            var visited = new HashSet<int>();
            //
            var keys = dic.Keys.ToList();
            int count = 0;
            for (int i = 0; i < n; i++ )
            {
                int node = i;

                if (visited.Contains(node)) continue;
                var s = new Stack<int>();
                s.Push(node);

                while (s.Count != 0)
                {
                    var curr = s.Pop();
                    if (!dic.TryGetValue(i, out var _)) continue;
                    foreach (var ni in dic[curr])
                    {
                        if (visited.Contains(ni)) continue;
                        visited.Add(ni);
                        s.Push(ni);
                    }
                }
                count++;
            }
            return count;
        }

        private new Dictionary<int, List<int>> ConstructGraph(int[][] connections, int n)
        {
            var dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < connections.Length; i++)
            {
                if (dic.TryGetValue(connections[i][0], out List<int> _))
                {

                    dic[connections[i][0]].Add(connections[i][1]);
                }
                else
                    dic.Add(connections[i][0], new List<int> { connections[i][1] });

                if (dic.TryGetValue(connections[i][1], out var value2))
                {

                    dic[connections[i][1]].Add(connections[i][0]);
                }
                else
                    dic.Add(connections[i][1], new List<int> { connections[i][0] });

            }
            for (int i = connections.Length; i < n; i++)
            {

                dic.Add(i, new List<int>());
            }
            return dic;
        }



       
    }
}
