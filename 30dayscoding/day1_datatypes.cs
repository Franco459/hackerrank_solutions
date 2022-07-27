using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    static void Main(String[] args) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        int first = Convert.ToInt32(Console.ReadLine());
        double second = Convert.ToDouble(Console.ReadLine());
        string third = Console.ReadLine().ToString();
        Console.WriteLine(first + i);
        Console.WriteLine("{0:F1}",second + d);
        Console.WriteLine(s + third);
    }
}