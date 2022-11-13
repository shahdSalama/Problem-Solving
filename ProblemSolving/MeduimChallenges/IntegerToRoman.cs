using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.MeduimChallenges
{
    class IntegerToRoman
    {

        public static string IntToRoman(int num)
        {
            var dic = new Dictionary<string, int>();
            dic.Add("I", 1);
            dic.Add("IV", 4);
            dic.Add("V", 5);
            dic.Add("IX", 9);
            dic.Add("X", 10);
            dic.Add("XL", 40);
            dic.Add("L", 50);
            dic.Add("XC", 90);
            dic.Add("C", 100);
            dic.Add("D", 500);
            dic.Add("CD", 400);
            dic.Add("CM", 900);
            dic.Add("M", 1000);

            var dicList = dic.ToList();
            var roman = "";
            dicList.Reverse();

            int n = num;
            while (n != 0)
            {
                // try to mod the n from the list
                for (int i = 0; i < dicList.Count; i++)
                {
                    if (dicList[i].Value > n) continue;
                    // lets see how many times we can use the letter
                    else
                    {
                        int freq = n / dicList[i].Value;
                       

                        for (int j = 0; j < freq; j++)
                        {
                            roman += dicList[i].Key;
                        }
                        int numberToBeSubtracted = freq * dicList[i].Value;
                        n -= numberToBeSubtracted;

                    }
                }
            }
            return roman;
        }

       
    }
}
