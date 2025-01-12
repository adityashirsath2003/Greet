using System;
using System.Security.Cryptography;

class Human{
   public int age;
    public static int p;
    
    public static void ff(Human h){
        Console.WriteLine("Hello " + h.age);
    }
}
static class Program
{
    static int i = 0;
    int k = 0;
    static void f(){
        Human.p += 1;
    }
    static void Main(string[] args)
    {
      Human h1 = new Human { age = 25 };
      Human h2 = new Human { age = 26 };
      Human.ff(h1);
      i = 11;
     
      Console.WriteLine(i);
    }
}  



