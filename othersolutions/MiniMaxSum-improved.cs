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

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        Console.WriteLine(miniSum(arr) + " " + maxSum(arr));
    }
    
    public static long miniSum(List<int> arr){
        int index = arr.IndexOf(arr.Max());
        long sum = 0;
        for(int i = 0; i < arr.Count; i++){
            if (i != index) sum += arr[i];
        }
        return sum;
    }
    
    public static long maxSum(List<int> arr){
        int index = arr.IndexOf(arr.Min());
        long sum = 0;
        for(int i = 0; i < arr.Count; i++){
            if (i != index) sum += arr[i];
        }
        return sum;
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}