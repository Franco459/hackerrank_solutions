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
    public static void sortMethod(int[] a){
        int n = a.Count(), numberOfSwaps = 0;
        for (int i = 0; i < n; i++) {
            
            for (int j = 0; j < n - 1; j++) {
                if (a[j] > a[j + 1]) {
                    a = swap(a, j, j+1);
                    numberOfSwaps++;
                }
            }
            if (numberOfSwaps == 0) {
                break;
            }
        }
            Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.\nFirst Element: {a[0]}\nLast Element: {a[a.Count() - 1]}");
    }
    
    public static int[] swap(int[]a, int posA, int posB){
        int aux = a[posA];
        a[posA] = a[posB];
        a[posB] = aux;
        
        return a;
    }
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int[] b = a.ToArray();
       sortMethod(b);
    }
}