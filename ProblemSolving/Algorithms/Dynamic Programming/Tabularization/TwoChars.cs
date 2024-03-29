﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HackerRank.Dynamic_Programming.Tabularization
{
    class TwoChars
    {
        public static int alternate(string s)
        {
            int NUM_LETTERS = 26; 


            int[,] pairs = new int[NUM_LETTERS, NUM_LETTERS];
            int[,] count = new int[NUM_LETTERS, NUM_LETTERS];

            for (int i = 0; i < s.Length; i++)
            {
                char letter = s[i];
                int letterNum = letter - 'a';

                for (int col = 0; col < NUM_LETTERS; col++)
                {
                    if (pairs[letterNum, col] == letter)
                    {
                        count[letterNum, col] = -1;
                    }
                    if (count[letterNum, col] != -1)
                    {
                        pairs[letterNum, col] = letter;
                        count[letterNum, col]++;
                    }

                }

                for (int row = 0; row < NUM_LETTERS; row++)
                {
                    if (pairs[row, letterNum] == letter)
                    {
                        count[row, letterNum] = -1;
                    }
                    if (count[row, letterNum] != -1)
                    {
                        pairs[row, letterNum] = letter;
                        count[row, letterNum]++;
                    }
                }
            }

            /* Find max in "count" array */
            int max = 0;
            for (int row = 0; row < NUM_LETTERS; row++)
            {
                for (int col = 0; col < NUM_LETTERS; col++)
                {
                    max = Math.Max(max, count[row, col]);
                }
            }
            return max;
        }



        //public static void Main(string[] args)
        //{
        //    alternate("abfab");
        //}
    }
}
