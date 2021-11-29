using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    public class SparseArray
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            Dictionary<string, int> stringsFrequency = new Dictionary<string,
             int>();
            for (int i = 0; i < strings.Count; i++)
            {
                int value;
                if (stringsFrequency.TryGetValue(strings[i], out value))
                {
                    stringsFrequency[strings[i]] += 1;
                }
                else
                {
                    stringsFrequency.Add(strings[i], 1);
                }
            }
            int[] queryFrequency = new int[queries.Count];
            for (int i = 0; i < queries.Count; i++)
            {
                int value;
                if (stringsFrequency.TryGetValue(queries[i], out value))
                {
                    queryFrequency[i] = value;
                }
                else
                {
                    queryFrequency[i] = 0;
                }
            }
            return queryFrequency.ToList();
        }
    }
}
