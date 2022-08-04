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
    public static string timeConversion(string s)
    {
        bool hour = true, format = true;
        string hourint = "";
        string formatst = "";
        string finalhour = " "; 
        for (int i=0;i<s.Length;i++){
            if (hour==true && s[i] != ':'){
                hourint += s[i];
            }
            else if (s[i] == ':'){
                hour = false;
            }
            if (format == true && ! int.TryParse(s[i].ToString(), out _) && s[i] != ':'){
                formatst += s[i];
            }
        }
        if (formatst == "PM" && Convert.ToInt32(hourint) < 12){
           finalhour = Convert.ToString( Convert.ToInt32(hourint) + 12 );
        }
        else if (formatst == "AM" && Convert.ToInt32(hourint) == 12){
            finalhour = "00";
        }
        else{
            finalhour = hourint;
        }
        for (int i =2; i < s.Length-2;i++){
            finalhour+= s[i];
        }
        return finalhour;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}