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

class BalancedBraces
{


    // Complete the braces function below.
    static string[] braces(string[] values)
    {

        string[] result = new string[values.Length];

        for (int i = 0; i < values.Count(); i++)
        {
            var stack = new Stack<char>();

            for (int j = 0; j < values[i].Length; j++)
            {
                if (values[i][j] == '[' || values[i][j] == '{' || values[i][j] == '(')
                {
                    stack.Push(values[i][j]);
                }


                else if (values[i][j] == ']' || values[i][j] == '}' || values[i][j] == ')')
                {
                    if (stack.Count == 0)
                    {
                        result[i] = "NO";
                        break;
                    }

                    var peak = stack.Peek();

                    if (values[i][j] == ']' && peak == '[')
                        stack.Pop();
                    else if (values[i][j] == '}' && peak == '{')
                        stack.Pop();
                    else if (values[i][j] == ')' && peak == '(')
                        stack.Pop();


                    else
                    {
                        result[i] = "NO";
                        break;
                    }
                }

            }
            if (stack.Count == 0 && string.IsNullOrEmpty(result[i]))
                result[i] = "YES";
            else { result[i] = "NO"; }

        }
        return result;
    }
    public static void Main(string[] args)
    {
        var brases = new string[4];
        brases[0] = "}{{}{";
        brases[1] = "({})(){{";
        brases[2] = "({})()";
        brases[3] = "{{{{{]({})()";
        var res = braces(brases);


    }
}
