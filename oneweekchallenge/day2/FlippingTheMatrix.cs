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
    public static int flippingMatrix(List<List<int>> matrix, int n){
        int sum = 0;
        for (int i = 0; i<n; i++){
            for (int j = 0; j<n; j++){
                int item0 = matrix [i][j];
                int item1 = matrix [2*n-1-i][j];
                int item2 = matrix [i][2*n-1-j];
                int item3 = matrix [2*n-1-i][2*n-1-j];
                //Console.WriteLine(item0 + " : " + item1 + " : " +  item2 + " : " + item3);
                sum += maximOf(item0, item1, item2, item3);
                //Shorter option below
                //sum += Math.Max(Math.Max(item0,item1), Math.Max(item2,item3));
            }
        }
        return sum;
    }
    public static int maximOf (int i0, int i1, int i2, int i3){
        int max = Math.Max(Math.Max(i0,i1), Math.Max(i2,i3));
        return max;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int q = Convert.ToInt32(Console.ReadLine().Trim());
        int n;
        for (int qItr = 0; qItr < q; qItr++)
        {
            n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < 2 * n; i++)
            {
                matrix.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(matrixTemp => Convert.ToInt32(matrixTemp)).ToList());
            }

            int result = Result.flippingMatrix(matrix, n);

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}