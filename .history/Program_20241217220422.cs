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
           var numbers = new List<int> { 1, 2, 3, 4, 5 };
           var evenNumbersQuery = from n in numbers
                       where n % 2 == 0
                       select n;

            foreach (var number in evenNumbersQuery)
            {
                Console.WriteLine(number); // Outputs: 2, 4
            }
 
    }
}  



