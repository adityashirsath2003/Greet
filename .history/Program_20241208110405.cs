﻿using System;
using System.Security.Cryptography;

class Human{
   public int age;
    public static int p;
    
    public static void ff(Human h){
        Console.WriteLine("Hello " + h.age);
    }
}

class A{
    protected int a;

}

class B : A{
    public void x(){
        a = 100;
        Console.WriteLine(a);
    }
}

class C : B{
    public void x(){
        a = 1000;
        Console.WriteLine(a);
    }
}
static class Program
{
    // static int i = 0;
    // static int k = 0;
    // static void f(){
    //     Human.p += 1;
    // }
    static void Main(string[] args)
    {
    //   Human h1 = new Human { age = 25 };
    //   Human h2 = new Human { age = 26 };
    //   Human.ff(h1);
    //   i = 11;
     
    //   Console.WriteLine(i);

      B b = new B();
      b.x();

      C b1 = new C();
      b1.x();
    //   A aa = new A();
    //   Console.WriteLine(aa.a);
      
    }
}  



