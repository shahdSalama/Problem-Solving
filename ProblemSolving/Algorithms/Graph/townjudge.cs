using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Graph
{
    class townjudge
    {
        public class Solution
        {
            public int FindJudge(int n, int[][] trusts)
            {
                // build a dictionary for each node how many people trust them
                // return the node that have n-1 keys and make sure that 
                // this node does not trust any one

                // // node .... who trusts it
                var dic1 = new Dictionary<int, HashSet<int>>();
                //     node.... who it trust
                var dic2 = new Dictionary<int, HashSet<int>>();

                foreach (var trust in trusts)
                {

                    if (dic2.TryGetValue(trust[0], out var val))
                        dic2[trust[0]].Add(trust[1]);
                    else
                        dic2.Add(trust[0], new HashSet<int> { trust[1] });


                    if (dic1.TryGetValue(trust[1], out var val1))
                        dic1[trust[1]].Add(trust[0]);
                    else
                        dic1.Add(trust[1], new HashSet<int> { trust[0] });
                }

                var node = dic1.Where(x => x.Value.Count == n - 1).SingleOrDefault().Key;
                if (node !=0 && dic2[node].Count == 0) return node;
                else return -1;

            }
        }
    }
}
