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

class Result
{
    public static void extraLongFactorials(int n)
    {
        var j = BigInteger.One;
        for (int i = 1; i <= n; i++){
            j = j * i;
        }
        Console.WriteLine(j);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine().Trim());

        Result.extraLongFactorials(n);
    }
}