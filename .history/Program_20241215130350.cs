using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

class Program
{
  
    static void Main(string[] args)
    {
       Dictionary<int,int> d = new Dictionary<int,int>();

       d.Add(1,2);
       d.Add(2,3);

       foreach(int x in d.Keys){
        Console.WriteLine(d[x]);
       } 
    }
}  



