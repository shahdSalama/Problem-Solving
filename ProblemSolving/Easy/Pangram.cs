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

class Pangram
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        s = s.ToLower();
        int[] stringAsNumbers = new int[s.Length];

        for (int i = 0; i < s.Length; i++)
        {
            stringAsNumbers[i] = Convert.ToInt32(s[i]);
        }

        string Pangram = "pangram";
        int a = Convert.ToInt32('a');
        for (int i = a; i < a + 25; i++)
        {
            if (stringAsNumbers.Contains(i))
                continue;
            else return "not pangram";

        }
        return Pangram;
    }

}


