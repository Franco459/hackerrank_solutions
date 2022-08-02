using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void oddandeven(string s){
        string oddLetters = "";
        string evenLetters = "";
        for (int i = 0; i < s.Length ; i++){
            if ( i == 0) evenLetters += s[0];
            else if ( i % 2 == 0) evenLetters += s[i];
            else oddLetters += s[i];
        }
        Console.WriteLine(evenLetters + " "+ oddLetters);
    }
    static void Main(String[] args) {
        int repeat = Convert.ToInt32(Console.ReadLine().Trim());        
        for (int i = 0; i<repeat;i++){
            string word = Convert.ToString(Console.ReadLine().Trim());
            Solution.oddandeven(word);
        }
    }
}