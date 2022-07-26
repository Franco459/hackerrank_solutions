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
{//comienzo solucion
    public static void plusMinus(List<int> arr, int n)
    {
        double posNum = 0, zerNum = 0, negNum = 0;
        foreach (int numb in arr){
            if (numb==0){
                zerNum++;
            } else if (numb > 0){
                posNum++;
            } else {
                negNum++;
            }
        }
        Console.WriteLine("{0:N6}",posNum /= n);
        Console.WriteLine("{0:N6}",negNum /= n);
        Console.WriteLine("{0:N6}",zerNum /= n);
    }
    //fin de solucion
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr, n);
    }
}
