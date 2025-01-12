using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
           var numbers = new List<int> { 5,4,3,2,1 };
        //    var evenNumbersQuery = from n in numbers
        //                where n % 2 == 0
        //                select n;


        var x = numbers.GroupBy(n=>n%2 == 0).OrderBy(g => g.Key).ThenBy(g => g);
      foreach (var group in x){
            foreach (var number in group)
            {
                Console.WriteLine(number); 
            }
      }
 
    }
}  



