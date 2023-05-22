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
     * Complete the 'palindromeIndex' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int palindromeIndex(string s)
    {
        int start = 0;
        int end = s.Length -1;
        if (s.Length == 1) return -1;
        else{
            while (start < end && s.ElementAt(start) == s.ElementAt(end)) {
                start++;
                end--;
            }
            if (start >= end) return -1;
            if (isPalindromeLongString(s, start +1, end)) return start;
            if (isPalindromeLongString(s, start, end -1)) return end;
        }
        return -1;
    }
    public static bool isPalindrome(string myS){
        return myS.SequenceEqual(myS.Reverse());
    }
    public static bool isPalindromeLongString(string myS, int firstPos, int secPos){
        while (firstPos < secPos && myS.ElementAt(firstPos) == myS.ElementAt(secPos)) {
                firstPos++;
                secPos--;
        }
        return (firstPos >= secPos) ? true : false;
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
