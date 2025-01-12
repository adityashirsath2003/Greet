﻿using System;
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
     
        t1.Join(5000);
        // Console.WriteLine("Thread t1 has finished.");
        t2.Join(5000);
        // Console.WriteLine("Thread t2 has finished.");
        // Console.WriteLine("All threads have completed.");

        Console.WriteLine("Main thread is done");
    }

    public static void f(){
     for(int i = 0;i<10;i++){
      Console.WriteLine(i);
      Thread.Sleep(1000);
     }
    }

}  



