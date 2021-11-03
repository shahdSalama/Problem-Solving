using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HackerRank
{


    public class MagicSquare
    {

        /*
         * Complete the 'formingMagicSquare' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY s as parameter.
         */

        public static int FormingMagicSquare(List<List<int>> s)
        {
            List<List<int>> one = new List<List<int>> { new List<int> { 8, 3, 4 }, new List<int> { 1, 5, 9 }, new List<int> { 6, 7, 2 } };

            List<List<int>> two
                = SwitchColumns(one);

            List<List<int>> three = SwitchRows(one);

            List<List<int>> four = SwitchRows(two);

            List<List<int>> five = MirrorOnLeftDiagonal(one);

            List<List<int>> six = SwitchColumns(five);

            List<List<int>> seven = SwitchRows(five);

            List<List<int>> eight = SwitchRows(six);

            Dictionary<int, List<List<int>>> predefined = new Dictionary<int, List<List<int>>>();

            predefined.Add(1, one);
            predefined.Add(2, two);
            predefined.Add(3, three);
            predefined.Add(4, four);
            predefined.Add(5, five);
            predefined.Add(6, six);
            predefined.Add(7, seven);
            predefined.Add(8, eight);

            var subtractingResult = SubtractingInputFromallTheMatrixes(s, predefined);
            return subtractingResult.OrderBy(num => num).FirstOrDefault();
        }

        private static List<int>  SubtractingInputFromallTheMatrixes(List<List<int>> s, Dictionary<int, List<List<int>>> predefined)
        {
            List<int> subtractingResult = new List<int>();

            foreach (var magicSquare in predefined)
            {
                List<List<int>> result = Subtract(s, magicSquare.Value);
                int summation = sumMatrix(result);
                subtractingResult.Add(summation);
            }
            return subtractingResult;
        }


        private static int sumMatrix(List<List<int>> s)
        {
            int result =  0;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result += s[i][j];
                }
            }
            return result; 
        }

        private static List<List<int>> Subtract(List<List<int>> s, List<List<int>> value)
        {
            List<List<int>> result = new List<List<int>>();
           
            for (int i = 0; i < 3; i++)
            {
                result.Add(new List<int> {0,0,0 });
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i][j] = Math.Abs(s[i][j] - value[i][j]);
                }
            }
            return result;
        }

        private static List<List<int>> MirrorOnLeftDiagonal(List<List<int>> one)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                result.Add(one[i].ToList());
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    result[i][j] = one[j][i];
                }
            }
            return result;
        }

        private static List<List<int>> SwitchRows(List<List<int>> one)
        {
            List<List<int>> result = new List<List<int>>();

            for (int i = 0; i < 3; i++)
            {
                result.Add(one[i].ToList());
            }

            for (int i = 0; i < 3; i++)
            {
                result[i][0] = one[i][2];

                result[i][2] = one[i][0];
            }

            return result;
        }


        private static List<List<int>> SwitchColumns(List<List<int>> one)
        {
            List<List<int>> result = new List<List<int>>();

            result.Add(one[2]);
            result.Add(one[1]);
            result.Add(one[0]);

            return result;
        }
    }

}
