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



class Solution
{
    public static void reverseList (int n, List<int> arr){
        string solution = "";
        for (int i = arr.Count - 1; i >= 0 ; i--){
            if (i != 0) solution += (arr[i] + " ");
            else solution += arr[i];
        }
        Console.WriteLine(solution);
    }
    
    
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();
        
        Solution.reverseList(n, arr);
    }
}