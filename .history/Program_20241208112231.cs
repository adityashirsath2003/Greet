using System;
using System.Security.Cryptography;

class A{
    internal int a;
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
    
      
    }
}  



