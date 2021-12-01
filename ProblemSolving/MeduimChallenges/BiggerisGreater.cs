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

class BiggerIsGreater
{

    /*
     * Complete the 'biggerIsGreater' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING w as parameter.
     */

    public static string biggerIsGreater(string w)
    {
        // wieght array
        int[] array = new int[w.Length];
      

        for (int z = 0; z < w.Length; z++)
        {
            array[z] = Convert.ToInt32(w[z]);
        }


        // find non increasing index
        int i = w.Length - 1;
        while (i > 0 && array[i - 1] >= array[i])
        {
            i--;
        }
        if (i <= 0)
            return "no answer";

        int j = w.Length - 1;

        while (array[j] <= array[i - 1])
        {
            j--;
        }

        swap(array, i - 1, j);

        j = array.Length - 1;
        while (i < j)
        {
            swap(array, i, j);
            i++;
            j--;
        }
        w = string.Join("", array.Select(x => Convert.ToChar(x)));
        return w;
    }

    public static void swap(int[] arr, int firstI, int secondI)
    {
        int temp = arr[firstI];
        arr[firstI] = arr[secondI];
        arr[secondI] = temp;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int T = Convert.ToInt32(Console.ReadLine().Trim());

        for (int TItr = 0; TItr < T; TItr++)
        {
            string w = Console.ReadLine();

            string result = Result.biggerIsGreater(w);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
