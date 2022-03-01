using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.DataStructure.Graph
{
    class MinCoinChangeCount
    {
        public static int bestsumCount(int targetSum, int[] nums)
        {
            // node, distance
            var q = new Queue<(int, int)>();
            var visited = new HashSet<int>();

            // solve shortest distance from target sum to 0

            q.Enqueue((targetSum, 0));
            visited.Add(targetSum);

            while (q.Count != 0)
            {
                var curr = q.Dequeue();
                var currNum = curr.Item1;
                var curDistance = curr.Item2;
                if (currNum == 0) return curDistance;
                foreach (var nie in GetNie(currNum, nums))
                {
                    if (visited.Contains(nie)) continue;

                    visited.Add(nie);
                    q.Enqueue((nie, curDistance + 1));

                }

            }
            return -1;
        }

        public static List<int> GetNie(int currNum, int[] nums)
        {
            var niegh = new List<int>();
            foreach (var num in nums)
            {
                int remainder = currNum - num;
                if (remainder >= 0)
                    niegh.Add(remainder);
            }
            return niegh;
        }


        // bfs // shortest path
        public int CoinChange(int[] coins, int targetSum)
        {
            //                  num , distance
            var q = new Queue<(int, int)>();
            q.Enqueue((targetSum, 0));

            while (q.Count != 0)
            {
                var curr = q.Dequeue();
                var currNode = curr.Item1;
                var currD = curr.Item2;
                if (currNode == 0) return currD;
                foreach (var nei in GetNei(currNode, coins))
                {
                    q.Enqueue((nei, currD + 1));
                }

            }

            return -1;

        }
        public List<int> GetNei(int currNode, int [] coins)
        {
            var res = new List<int>();

            foreach (var num in coins)
            {

                int remainder = currNode - num;

                if (remainder >= 0) res.Add(remainder);

            }
            return res;
        }



        //public static void Main(String[] args)
        //{
        //    //  var res5 = HowSum(3, new int[] { 2, 0, 5 });
        //    //  var res2 = CoinChange(new int[] { 2, 3}, 7,  new Dictionary<int, List<int>>());
        //    //  var res23 = CoinChange(new int[] { 5,3,4,7 }, 7, new Dictionary<int, List<int>>());
        //    var bestsumm = bestsumCount(4, new int[] { 1, 2 });
        //    //  var memo = new Dictionary<int, List<int>>();
        //    var r99es55 = bestsumCount(100, new int[] { 1, 10, 25 });
        //    // time n*m
        //    // space : target = n

        //}

    }
}
