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
using System.Numerics;

class RecursiveSum
{
    public static int recursiveSuperDigit(BigInteger n)
    {
        if (n < 10) return (int)n;

        char[] stringArr = n.ToString().ToCharArray();
        BigInteger sum = 0;
        foreach (char ch in stringArr)
        {
            sum += (int)char.GetNumericValue(ch);
        }
        return recursiveSuperDigit(sum);
    }


    public static int superDigit(string n, int k)
    {
        string integer = "";

        char[] stringArr = n.ToString().ToCharArray();
        BigInteger sum = 0;
        foreach (char ch in stringArr)
        {
            sum += (int)char.GetNumericValue(ch);
        }

        sum *= k;

        integer = sum.ToString();

        var val = BigInteger.Parse(integer);

        return recursiveSuperDigit(val);
    }




    //public static void Main(string[] args)
    //{


    //    string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

    //    string n = firstMultipleInput[0];

    //    int k = Convert.ToInt32(firstMultipleInput[1]);

    //    int result = superDigit(n, k);



    //}

}








