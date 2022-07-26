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
{ //comienzo solucion
    public static void miniMaxSum(List<int> arr)
    {
        long max =0, resmax = 0, min = arr[0], rmin = 0;
        foreach(long numberar in arr){
            if ( numberar > max){
                max = numberar;
            }
            if (numberar < min){
                min = numberar;
            }
        }
        foreach(long numberar in arr){
            resmax+=numberar;
            rmin+=numberar;
        }
        resmax -= min;
        rmin -= max;
        Console.WriteLine(Convert.ToString(rmin) + ' ' + Convert.ToString(resmax));
    }
    //fin de solucion
}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}