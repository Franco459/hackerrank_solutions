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
    // ALTERNATIVE SOLUTION FOR PALINDROME INDEX
    public static int palindromeIndex(string s)
    {
        int length_str = s.Length - 1;
        if (s.Length == 1) return -1;
        else{
            for (int i = 0; i < s.Length; i++){
                if (s[i] != s[length_str - i]){
                    return (isPalindrome(s.Remove(i,1)) ? i : (length_str - i));
                }
                if( i >= length_str - i) break;
            }
        }
        return -1;
    }
    
    public static bool isPalindrome(string myS){
        return myS.SequenceEqual(myS.Reverse());
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = Result.palindromeIndex(s);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}