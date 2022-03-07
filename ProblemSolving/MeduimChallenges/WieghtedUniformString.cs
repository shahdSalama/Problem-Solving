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

class Result34567
{

    /*
     * Complete the 'weightedUniformStrings' function below.
     *
     * The function is expected to return a STRING_ARRAY.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER_ARRAY queries
     */

    public static List<string> weightedUniformStrings(string s, List<int> queries)
    {
        var res = new List<string>();
        var hash = BuildDictionary(s);
        foreach (var q in queries)
        {
            if (hash.Contains(q))
                res.Add("Yes");
            else
                res.Add("No");
        }
        return res;
    }


    public static HashSet<int> BuildDictionary(string s)
    {
        var hash = new HashSet<int>();
        int start = 0;

        int wieght = 0;
        wieght = (s[start] - 'a' + 1);
        hash.Add(wieght);
        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                wieght = wieght + s[i] - 'a' + 1;
            }
            else
            {
                wieght = s[i] - 'a' + 1;
            }
            hash.Add(wieght);
        }
        return hash;
    }

}