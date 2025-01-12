using System;
using System.Security.Cryptography;

class Animal
{
    public Animal(string name)
    {
        Console.WriteLine($"Animal: {name}");
    }
}

class Dog : Animal
{
    public Dog(string name) : base(name) 
    {
        Console.WriteLine("Dog is created.");
    }
}

static class Program
{

    static void Main(string[] args)
    {
      Dog d = new Dog("Dokhya");
    }
}  



