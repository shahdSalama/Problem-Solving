using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class PalandromicSubstrings
    {
        
       
            public static int CountSubstrings(string s)
            {
                int count = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int l = i;
                    int r = i;
                    while (l <= r && l >= 0 && r < s.Length)
                    {
                        if (s[l] == s[r])
                            count++;
                        l--; r++;
                    }

                    l = i;
                    r = i + 1;
                    while (l <= r && l >= 0 && r < s.Length)
                    {
                        if (s[l] == s[r])
                            count++;
                        l--; r++;
                    }

                }
                return count;
            }
            public static void Main(string[] args)
            {
            CountSubstrings("kdmwok");
            }
        }
    }

            
       

