using System;
using System.Security.Cryptography;

class A{
    static internal int a;
    public void set(int x){
        a = x;
    }
    public void p(){
        Console.WriteLine(a);
    }
}

class B : A{
    public void set(int x){
        a = x;
    }
    public void p(){
        Console.WriteLine(a);
    }
}

static class Program
{

    static void Main(string[] args)
    {
     A a1 = new A();
    //  Console.WriteLine(a1.a);
     a1.set(11);
     a1.p();

     B a11 = new B();
    //  Console.WriteLine(a11.a);
     a11.set(111);
     a11.p();
      
    }
}  



