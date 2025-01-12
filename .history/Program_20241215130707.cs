using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;

class Program
{
  
    static void Main(string[] args)
    {
       Dictionary<int,int> d = new Dictionary<int,int>();

       d.Add(1,2);
       d.Add(2,3);
       d.Add(2,5);
       foreach(int x in d.Keys){
        Console.WriteLine(d[x]);
       } 

      Hashtable d1 = new Hashtable();

       d1.Add(1,2);
       d1.Add(2,3);
       d1.Add(2,5);
       foreach(int x in d1.Keys){
        Console.WriteLine(d1[x]);
       } 
    }
}  



