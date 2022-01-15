using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'bomberMan' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING_ARRAY grid
     */

    public static List<string> bomberMan(int n, List<string> grid)
    {
        if (n == 0 || n == 1) return grid;

        if (n % 2 == 0) return getZeroGrid(grid);

        var invertedOnce = getInvertedGrid(grid);

        if (n % 4 == 3) return invertedOnce;

        return getInvertedGrid(invertedOnce);
    }

    public static List<string> getZeroGrid(List<string> grid)
    {
        int rowCount = grid.Count;
        int colCount = grid[0].Length;

        for (int i = 0; i < rowCount; i++)
        {
            grid[i] = new string('O', colCount);
        }
        return grid;
    }

    public static List<string> getInvertedGrid(List<string> grid)
    {
        var newgrid = new List<string>();
        int rowCount = grid.Count;
        int colCount = grid[0].Length;
        for (int i = 0; i < rowCount; i++)
        {
            var sb = new StringBuilder();
            for (int j = 0; j < colCount; j++)
            {
                if (hasNoBombAround(grid, i, j))
                    sb.Append('O');
                else
                    sb.Append('.');
            }
            newgrid.Add(sb.ToString());
        }
        return newgrid;
    }

    public static bool hasNoBombAround(List<string> grid, int row, int col)
    {
        return !isBomb(grid, row, col) &&
        !isBomb(grid, row + 1, col) &&
        !isBomb(grid, row - 1, col) &&
        !isBomb(grid, row, col + 1) &&
        !isBomb(grid, row, col - 1);
    }

    public static bool isBomb(List<string> grid, int row, int col)
    {
        return isAvailable(grid, row, col) && grid[row][col] == 'O';
    }

    public static bool isAvailable(List<string> grid, int row, int col)
    {
        return row >= 0 && col >= 0 &&
        row < grid.Count && col < grid[0].Length;

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int r = Convert.ToInt32(firstMultipleInput[0]);

        int c = Convert.ToInt32(firstMultipleInput[1]);

        int n = Convert.ToInt32(firstMultipleInput[2]);

        List<string> grid = new List<string>();

        for (int i = 0; i < r; i++)
        {
            string gridItem = Console.ReadLine();
            grid.Add(gridItem);
        }

        List<string> result = Result.bomberMan(n, grid);

        textWriter.WriteLine(String.Join("\n", result));

        textWriter.Flush();
        textWriter.Close();
    }
}
