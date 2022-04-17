using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.DataStructure.Graph
{
    class locks
    {
        public int OpenLock(string[] deadends, string target)
        {
            var visited = new HashSet<string>(deadends);
            var q = new Queue<(string code, int steps)>();
            var res = int.MaxValue;
            q.Enqueue(("0000", 0));

            while (q.Count != 0)
            {
                (string currCode, int currSteps) = q.Dequeue();

                // goal
                if (currCode == target)
                {
                    return currSteps;
                }

                if (visited.Contains(currCode)) continue;
                visited.Add(currCode);

                foreach (string n in GetN(currCode))
                {
                    q.Enqueue((n, currSteps + 1));
                }
            }
            return res == int.MaxValue ? -1 : res;
        }

        private List<string> GetN(string currCode)
        {
            var res = new List<string>();
            var charArr = currCode.ToCharArray();
            int n1 = 0; int n2 = 0;
            for (int i = 0; i < charArr.Length; i++)
            {
                char c = charArr[i];
                int digit = Convert.ToInt32(c) - 48;
                n1 = (digit + 1) % 10; n2 = ((digit - 1) + 10) % 10;

                var char2 = charArr.ToList();
                char2[i] = n1.ToString()[0];
                res.Add(string.Join("", char2));
                char2[i] = n2.ToString()[0];
                res.Add(string.Join("", char2));
            }
            return res;
        }

       

    }
}
