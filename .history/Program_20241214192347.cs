﻿using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

class Program
{
  
    static void Main(string[] args)
    {
        // string a = "aditya123@gmail.com";
        // string p = "[a-zA-Z0-9_]+@[a-zA-Z]+.[a-zA-Z]{2,}$";

        // bool isMatch = Regex.IsMatch(a, p);
        // Console.WriteLine(isMatch);

        //         // string input = "abc123def456";
        //         string input = "aditya123aaa@gmail.1.com";
        // string pattern = @"\w+"; // Matches one or more digits

        // MatchCollection matches = Regex.Matches(input, pattern);

        // foreach (Match match in matches)
        // {
        //     Console.WriteLine(match.Value); // Output: 123, 456
        // }
        
        // string a = "+123/1234567";
        // string p = "[+0-9]{3,3}/[+0-9]{7,7}$";

        // bool isMatch = Regex.IsMatch(a, p);
        // Console.WriteLine(isMatch);

        string a = "https//aditya.coma";
        string p = "^https?//[a-zA-Z]+.[a-zA-Z]{2,}$";

        bool isMatch = Regex.IsMatch(a, p);
        Console.WriteLine(isMatch);

    }
}  



