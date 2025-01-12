using System;
using System.Security.Cryptography;


public struct A{
    private int x;
    public A(int x1){
        x = x1;
    }
     
    //Getter and setter
    public int X{
        get {return x;}
        set {x = value;}
    } 
}
static class Program
{
    static void Main(string[] args)
    {
        A a = new A(10);
        Console.WriteLine();

    }
}  



