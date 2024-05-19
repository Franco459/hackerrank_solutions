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
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static string breakingRecords(List<int> scores)
    {
        int min = scores[0], max = scores[0], maxCount = 0, minCount = 0;
        for(int i = 0; i < scores.Count; i++){
            if (scores[i] > max) {
                maxCount++;
                max = scores[i];
            }
            else if (scores[i] < min)   {
                minCount++;
                min = scores[i];
            }  
                   
        }
        return (maxCount + " " + minCount);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        string result = Result.breakingRecords(scores);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}