using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.MeduimChallenges
{
    class EffecientCar
    {
        public static int effecientCar(int[] P, int[] S)
        {
            var peopleCount = 0;

            for (int i = 0; i < P.Length; i++)
            {
                peopleCount += P[i];
            }

            Array.Sort(S);

            Array.Reverse(S);

            int carCount = 0;

            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] <= peopleCount)
                {
                    carCount++;
                    peopleCount -= S[i];
                }
                else if (S[i] >= peopleCount)
                {
                    carCount++;
                    break;
                }
            }

            return carCount;

        }
    }
}
