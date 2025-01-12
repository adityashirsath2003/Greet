using System;
using System.Security.Cryptography;


public struct A{
    public int x;
    public A(int x1){
        x = x1;
    }
}
static class Program
{
    static void Main(string[] args)
    {
        A a = new A(10);
        Console.WriteLine(A.x);

    }
}  



