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

class ClosestNumber
{

    /*
     * Complete the 'closestNumbers' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static List<int> closestNumbers(List<int> arr)
    {
        var res = new List<int>();

        arr.Sort();

        var dic = new Dictionary<int, (int, int)>();

        for (int i = 0; i < arr.Count - 1; i++)
        {

            int newDiff = arr[i + 1] - arr[i];
            dic.Add(newDiff, (arr[i], arr[i + 1]));
        }

        var leastDiff = dic.Keys.ToList().Min();

        var listofTuple = dic.Where(x => x.Key == leastDiff).Select(x => x.Value).ToList();
        foreach (var x in listofTuple)
        {
            res.Add(x.Item1);
            res.Add(x.Item2);
        }
        return res;
    }



    //public static void Main(string[] args)
    //{
    //    // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

    //    int n = Convert.ToInt32(Console.ReadLine().Trim());

    //    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    //    List<int> result = closestNumbers(arr);

    //    //  textWriter.WriteLine(String.Join(" ", result));

    //    //     textWriter.Flush();
    //    //   textWriter.Close();
    //}
}