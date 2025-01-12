using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;

public class Box<T>{
    public T n;

    public Box(T t){
        n = t;
    }
    public void P(T x){
        Console.WriteLine(x);
    }
}
class Program
{
    //Generic methods 
    // public static void Log<T>(T t){
    //     Console.WriteLine(t);
    // }

    // public static T Log1<T>(T t){
    //     return t;
    // }
    static void Main(string[] args)
    {
      //Generic method call  
    //   Console.WriteLine(Log1(10));
    //   Log("Aditya");
    }

}  



