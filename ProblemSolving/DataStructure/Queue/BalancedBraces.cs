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

    static bool IsPairs(char a, char b, Dictionary<char,char> dic) 
    {
        return dic[a] == b;
    }




    static string[] braces(string[] values)
    {
      

        string[] result = new string[values.Length];

        for (int i = 0; i < values.Count(); i++)
        {
            result[i] = isBalanced(values[i]);
        }
        return result;
    }

    public static string isBalanced(string s)
    {
        Dictionary<char, char> pairs = new Dictionary<char, char>();

        string result = "";

        pairs.Add('(', ')');
        pairs.Add('[', ']');
        pairs.Add('{', '}');


        pairs.Add(')', '(');
        pairs.Add(']', '[');
        pairs.Add('}', '{');

        List<char> opened = new List<char>() { '[', '{', '(' };
        List<char> closed = new List<char>() { ']', '}', ')' };

        var stack = new Stack<char>();

        for (int j = 0; j < s.Length; j++)
        {
            if (opened.Contains(s[j]))
            {
                stack.Push(s[j]);
            }

            else if (closed.Contains(s[j]))
            {
                if (stack.Count == 0)
                {
                    result = "NO";
                    break;
                }

                var peak = stack.Peek();

                if (IsPairs(s[j], peak, pairs))
                    stack.Pop();
                else
                {
                    result = "NO";
                    break;
                }
            }
        }
        if (stack.Count == 0 && string.IsNullOrEmpty(result))
            result = "YES";
        else
            result = "NO";
        return result;
    }
    public static void Main(string[] args)
    {
        var brases = new string[6];

        brases[0] = "({})";
        brases[1] = "}][}}(}][))]";
        brases[2] = "[](){ ()}";
        brases[3] = "()";
        brases[4] = "({ } ([][]))[]()";
        brases[5] = "{)[](}]}]}))}(())(";


        var res = braces(brases);





    }
}
