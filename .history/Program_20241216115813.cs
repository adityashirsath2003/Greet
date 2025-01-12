using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;

public class T{
    public int name = 10;
}
class Program
{
    public static void Log<T>(T t){
        Console.WriteLine(t);
    }

    public static T Log1<T>(T t){
        return t;
    }
    static void Main(string[] args)
    {
      Console.WriteLine(Log1(10));
      Log("Aditya");
    }

}  



