using System;
using System.Formats.Asn1;
using System.Security.Cryptography;


class Program
{
     public delegate void Notify(string a);

     public static void Add(string a){
        Console.WriteLine("Hello " + a);
     }
     
    public static void Add1(string a){
        Console.WriteLine("Hello aaaaa " + a);
     }

    static void Main(string[] args)
    {
        Notify n = Add;
        n += Add1;
        n("Aditya");


    }
}  



