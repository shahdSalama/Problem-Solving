using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Easy
{
    class Cropping
    {
        public static string cropping(string message, int k)
        {
            if (message.Length <= k) return message.TrimEnd();

            var listOfWords = message.Split(' ');
            string result = "";

            if (listOfWords[0].Length <= k)
            {
                result = listOfWords[0];
                k = k - listOfWords[0].Length;
            }

            for (int i = 1; i < listOfWords.Length; i++)
            {
                if (listOfWords[i].Length + 1 <= k)
                {
                    result += " " + listOfWords[i];
                    k -= listOfWords[i].Length;
                }
            }
            return result;
        }
    }
}
