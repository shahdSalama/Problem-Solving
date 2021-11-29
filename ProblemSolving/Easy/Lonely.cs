﻿using System.CodeDom.Compiler;
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
     * Complete the 'lonelyinteger' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int lonelyinteger(List<int> arr)
    {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < arr.Count; i++)
        {
            int value;
            if (dic.TryGetValue(arr[i], out value))
            {
                dic[arr[i]]++;
            }
            else
            {
                dic.Add(arr[i], 1);
            }
        }
        return dic.FirstOrDefault(x => x.Value == 1).Key;


}

    class Solution
    {
        //public static void Main(string[] args)
        //{
        //    TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        //    int n = Convert.ToInt32(Console.ReadLine().Trim());

        //    List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        //    int result = Result.lonelyinteger(a);

        //    textWriter.WriteLine(result);

        //    textWriter.Flush();
        //    textWriter.Close();
        //}
    }
}
