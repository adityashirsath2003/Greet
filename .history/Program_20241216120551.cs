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
    public void P(){
        Console.WriteLine(n);
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

    //Generic class call
    Box<int> b = new Box<int>(11);
    Box<string> b1 = new Box<string>("Aditya");
    b.P();
    b1.P();


    }

}  



