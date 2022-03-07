using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class coinchangeways
    {

        public static int Change(int amount, int[] coins)
        {
            int count = 0;
            //                    total, indx, coins used
            var visited = new HashSet<(int, int)>();
            var s = new Stack<(int, int, List<int>)>();

            s.Push((0, 0, new List<int>()));

            while (s.Count != 0)
            {
                (int currTotal, int currI, List<int> currCoins) = s.Pop();

                if (visited.Contains((currTotal, currI)))
                    continue;

                if (currTotal > amount) continue;

                if (currI == coins.Length) continue;

                visited.Add((currTotal, currI));




                // take and move
                var newCoinList = currCoins.ToList();
                newCoinList.Add(coins[currI]);
                var newtotal = currTotal + coins[currI];
                if (newtotal == amount)
                {
                    count++;
                    continue;
                }
                s.Push((currTotal + coins[currI], currI + 1, newCoinList));
               
                // take and stay
                var newCoinList2 = currCoins.ToList();
                newCoinList2.Add(coins[currI]);
                
                s.Push((currTotal + coins[currI], currI, newCoinList2));
               
                
                // do not take and move              
                s.Push((currTotal, currI + 1, currCoins));

            }
            return count;
        }
      

    }
}
