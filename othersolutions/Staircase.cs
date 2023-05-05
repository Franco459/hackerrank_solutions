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
    public static void staircase(int n)
    {

        // start solution
        string stair = "";
        int spacesAmount = (n-1);
        for(int i = 0; i < n; i++){
            for(int j = 0; j < spacesAmount; j++){
                stair += " ";
            }
            for(int k = n; k > spacesAmount; k--){
                stair += "#";
            }
            spacesAmount--;
            if(spacesAmount >= 0) stair += "\n";            
        }
        Console.WriteLine(stair);
        // end solution
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}