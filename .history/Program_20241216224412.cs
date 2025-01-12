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
      new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start(); new Thread(f).Start();

      // Console.WriteLine(t1.ThreadState);
      // t1.Start();
      // // t2.Start();
      // Console.WriteLine(t1.ThreadState);
      //   // t1.Join(10000);
      //    Console.WriteLine(t1.ThreadState);
      //   Thread.Sleep(10000);
      //   Console.WriteLine("Main thread is done");
      //   Console.WriteLine(t1.ThreadState);
    }

    public static void f(){
     for(int i = 0;i<10;i++){
      Console.WriteLine(i);
      Thread.Sleep(1000);
     }
    }

}  



