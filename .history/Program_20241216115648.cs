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
    public void Log<T>(T t){
        Console.WriteLine(t);
    }

    public T Log<T>(T t){
        return t;
    }
    static void Main(string[] args)
    {

    }

}  



