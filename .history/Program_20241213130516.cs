using System;
using System.Security.Cryptography;


public struct A{
    private int x;
    public A(int x){
        x = x;
    }
}
static class Program
{
    static void Main(string[] args)
    {
        A a = new A();
        Console.WriteLine(A.x);

    }
}  



