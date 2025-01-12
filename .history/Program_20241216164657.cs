using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.Intrinsics.X86;

class Program
{

    static void Main(string[] args)
    {
      Thread t1 = new Thread(f);
      Thread t2 = new Thread(f);

      t1.Start();
      t2.Start();
     

    }

    public static void f(){
      Console.WriteLine("Hello bro");
      Thread.Sleep(1000);
    }

}  



