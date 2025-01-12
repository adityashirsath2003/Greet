using System;
using System.Security.Cryptography;

class Animal
{
    // internal Animal(string name)
    // {
    //     Console.WriteLine($"Animal: {name}");
    // }
    public int a = 100;
    public int b = 200;
}

class Dog : Animal
{
    // internal Dog(string name) : base(name) 
    // {
    //     Console.WriteLine("Dog is created.");
    // }
    public int c = 1000;
}

static class Program
{

    static void Main(string[] args)
    {
      Dog d = new Dog();
      Console.WriteLine(d.a);
      Console.WriteLine(d.b);
      Console.WriteLine(d.c);
    }
}  



