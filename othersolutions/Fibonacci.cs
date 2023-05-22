using System;
using System.Collections.Generic;
using System.IO;

class Solution {
    
    public static int Fibonacci(int n) {
        int first = 0;
        int second = 1;
        int result = 0;
        if (n == 1 || n == 0) return (n == 1) ? 1 : 0;
        for (int i = 1; i < n; i++){
            result = first + second;
            first = second;
            second = result; 
        }
        return result;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Fibonacci(n));
    }
}