using System;
using System.Security.Cryptography;

interface IAnimal{
    void s();
    void s1(){
        Console.WriteLine("Animal is created.");
    }
}

interface IAnimal1{
    void ss();
    void ss1(){
        Console.WriteLine("Animal1 is created.");
    }
}



class Animal
{
    // internal Animal(string name)
    // {
    //     Console.WriteLine($"Animal: {name}");
    // }
    public int a = 100;
    public int b = 200;

    public  virtual void s(){
        Console.WriteLine("Animal is created.");
    }
}

class Dog : IAnimal,IAnimal1
{
    public void s(){
        Console.WriteLine("Dog is created.");
    }

    public void ss(){
        Console.WriteLine("Dog1 is created.");
    }
    public int a = 1000;
}




static class Program
{

    static void Main(string[] args)
    {
    //   Dog d = new Dog();
    //   Console.WriteLine(d.a);
    //   Console.WriteLine(d.b);
    // //   Console.WriteLine(d.c);

    //   Animal d1 = new Animal();
    //   Console.WriteLine(d1.a);
    //   Console.WriteLine(d1.b);
    // //   Console.WriteLine(d1.c);

    IAnimal d = new Dog();
    // Console.WriteLine(d.a);
    // Console.WriteLine(d.b);
    d.s();
    d.s1();

    }
}  



