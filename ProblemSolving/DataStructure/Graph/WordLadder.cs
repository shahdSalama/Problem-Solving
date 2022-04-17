using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class WordLadder
    {

        public static int LadderLength(string start, string end, IList<string> wordList)
        {
            if (!wordList.Contains(end)) return 0;
            var visited = new HashSet<string>();
            var q = new Queue<(string, int)>();
            var alphabet = "qwertyuiopasdfghjklzxcvbnm";
            q.Enqueue((start, 0));

            while (q.Count != 0)
            {
                (string currword, int currSteps) = q.Dequeue();

                // goal 
                if (end == currword) return currSteps;

                //not in list
                if (!wordList.Contains(currword)) continue;

                //visited = hit
                if (visited.Contains(currword)) continue;

                visited.Add(currword);

                for (int i = 0; i < currword.Length; i++)
                {
                    var charArr = currword.ToCharArray();

                    foreach (var c in alphabet)
                    {
                        charArr[i] = c;
                        q.Enqueue((string.Join("", charArr), currSteps + 1));
                    }
                }
            }
            return 0;
        }
     
    }
}
