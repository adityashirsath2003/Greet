using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

class Program
{
  
    static void Main(string[] args)
    {
        string a = "aditya@gmail1.com";
        string p = "[a-zA-Z0-9_]+@[a-zA-Z]+.[a-zA-Z]{2,}$";

        bool isMatch = Regex.IsMatch(a, p);
        Console.WriteLine(isMatch);

    }
}  



