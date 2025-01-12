using System;
using System.Formats.Asn1;
using System.Security.Cryptography;

//We can declare delegates outside any class which make them easily accessible;
class Program
{
     public delegate void Notify(string a);

     public delegate void Notify2<T>(T a);

     public static void Add(string a){
        Console.WriteLine("Hello " + a);
     }
     
    public static void Add1(string a){
        Console.WriteLine("Hello aaaaa " + a);
     }

     public static void Add2(int a){
        Console.WriteLine("Hello aaaaa " + a);
     }

     public static T Printt<T>(T x){
         return x;
     }
  
    static void Main(string[] args)
    {
        Notify n = Add;
        n += Add1;
        // n+=Add2; error 
        n("Aditya");


    }
}  



