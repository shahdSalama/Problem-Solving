using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class ClimbingtheLeaderboard
    {
        public static List<int> GetRanks(List<int> ranked)
        {
            int[] result = new int[ranked.Count];
            result[0] = 1;
            for (int i = 1; i < ranked.Count; i++)
            {
                if (ranked[i] == ranked[i - 1])
                    result[i] = result[i - 1];
                else result[i] = result[i - 1] + 1;

            }
            return result.ToList();

        }
        public static List<int> climbingLeaderboard(List<int> board, List<int> player)
        {
            var gamesCount = player.Count;
            var result = new int[gamesCount];

            var ranks = GetRanks(board);

            for (int i = 0; i < gamesCount; i++)
            {
                var gameScore = player[i];
                if (gameScore > board[0]) result[i] = 1;
                else if (gameScore < board[board.Count - 1])
                {
                    result[i] = GetRanks(board)[board.Count - 1] + 1;
                }

                else
                {
                    int indexInBoard = BinarySearch(board, gameScore);

                    result[i] = ranks[indexInBoard];
                }
            }
            return result.ToList();
        }
        public static int BinarySearch(List<int> list, int key)
        {
            int hi = list.Count - 1;
            int lo = 0;

            while (lo <= hi)
            {
                int mid = lo + (hi - lo) / 2;
                //// 7, 6, 4    <= insert 6
                if (list[mid] == key) return mid;
                //    v
                // 7, 6, 4    <= insert 5
                // 7, 6, 5, 4
                else if (list[mid] > key && key >= list[mid + 1]) return mid + 1;

                //       v
                // 7, 6, 2, 1  <= inset 3
                // 7, 6, 3, 2, 1
                else if (list[mid] < key && key < list[mid - 1])
                    return mid;

                //      v
                //7, 6, 4 , 3, 2  <= insert 1
                else if (list[mid] > key)
                    lo = mid + 1;

                else if (list[mid] < key)
                    hi = mid - 1;

            }
            return -1;
        }
    }
}
