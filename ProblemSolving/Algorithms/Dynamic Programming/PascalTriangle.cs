
using System.Collections.Generic;


namespace HackerRank.Algorithms.Dynamic_Programming
{
    class PascalTriangle
    {


        public IList<int> GetRow(int rowIndex)
        {
            var triangle = Genrate(rowIndex);
            return triangle[rowIndex - 1];
        }

        private List<List<int>> Genrate(int n)
        {
            if (n == 1) return new List<List<int>> { new List<int> { 1 } };
            var nminus1 = Genrate(n - 1);

            List<int> lastRow = GenerateLastRow(nminus1);
            nminus1.Add(lastRow);

            return nminus1;
        }
        private List<int> GenerateLastRow(List<List<int>> nminus1)
        {
            var len = nminus1.Count;
            var nminus1Row = nminus1[len - 1];
            var lastRow = new List<int>();

            for (int i = 0; i < len - 1; i++)
            {

                lastRow.Add(nminus1Row[i] + nminus1Row[i + 1]);

            }
            lastRow.Insert(0, 1);
            lastRow.Add(1);
            return lastRow;

        }

     
    }
}
