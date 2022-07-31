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
    public static char changeLetter(int k, char c){
        // busca la letra y la cambia por lo que se pida
        int i = 0;
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        for (i = 0; i < alphabet.LongCount(); i++){
            if (alphabet[i] == c) break;
        }
        int plus = 0;
        plus =i+k;
        if (plus < alphabet.LongCount()) return alphabet[plus];
        else {
            //en caso de tener que dar la vuelta al alfabeto se hace con esto
            plus = plus - 26;
            return alphabet[plus];
        }
    }

    public static string caesarCipher(string s, int k)
    {
        string finalString = "";
        //por si K es mayor al numero de letras en el alfabeto
        if (k> 26) k = k % 26;
        //recorrido de string para cambiar
        for (int i = 0; i < s.LongCount(); i++){
            if (char.IsLetter(s[i])){
                //averiguar si es mayuscula o minuscula, cambiarla y concatenarla
                if (char.IsLower(s[i])){
                    finalString += changeLetter(k, s[i]);
                }
                else{
                    finalString += char.ToUpper(changeLetter(k, char.ToLower(s[i]))); 
                }
            }
            else {
                //se concatena si no es letra
                finalString += s[i];
            }
        }
        return finalString;
    }

}
class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
