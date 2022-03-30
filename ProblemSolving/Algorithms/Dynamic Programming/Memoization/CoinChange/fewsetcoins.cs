using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithms.Dynamic_Programming.Memoization.CoinChange
{
    class fewsetcoins
    {
        public static int CoinChange(int[] coins, int target)
        {
            var fewest_coins = int.MaxValue;
            var visited = new int[coins.Length, target + 1];
            //             coins_num, i  , amount
            var s = new Stack<(int, int, int)>();
            s.Push((0, 0, 0));

            while (s.Count != 0)
            {
                (int currCoinsNum, int currI, int curr_amount) = s.Pop();

                // goal
                if (curr_amount == target)
                {

                    fewest_coins = Math.Min(fewest_coins, currCoinsNum);
                    // no more states to check
                    continue;

                }
                // out of bounds target
                if (curr_amount > target) continue;

                // out of bounds array
                if (currI >= coins.Length) continue;

                // been here with a better state
                if (visited[currI, curr_amount] != 0 && visited[currI, curr_amount] <= currCoinsNum) continue;



                visited[currI, curr_amount] = currCoinsNum;


                // use coin and stay
                if (coins[currI] < target)
                s.Push((currCoinsNum + 1, currI, curr_amount + coins[currI]));
                //use coin and move
                if (coins[currI] < target)
                    s.Push((currCoinsNum + 1, currI + 1, curr_amount + coins[currI]));
                //do not use the coin and move
                s.Push((currCoinsNum, currI + 1, curr_amount));
            }
            return fewest_coins == int.MaxValue ? -1 : fewest_coins;
        }

       
    }
}
