using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    class RunLenncoding
    {
		static string encoding(string input)
		{
			int len = input.Length;
			int c = 1;
			string res = "";
			for (int i = 0; i < len - 1; i++)
			{
				if (input[i] == input[i + 1])
					c++;
				else
				{
					res += c.ToString() + input[i];
					c = 1;
				}
			}
			res += c.ToString() + input[len - 1];
			return res;


		}

      
    }
}
