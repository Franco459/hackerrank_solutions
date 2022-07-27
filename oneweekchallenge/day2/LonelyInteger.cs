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
    public static int lonelyinteger(List<int> a)
    {
        int unique = 0, sizee = a.Count();
        a.Sort();
        bool ultimo = true;
        for (int i = 0; i<sizee-1; i = i +2){
            if (a.ElementAt(i) != a.ElementAt(i+1)){
                unique=a.ElementAt(i);
                ultimo = false;
                break;
            }
        }
        if (ultimo) {unique = a.ElementAt(sizee-1);}
        return unique;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
