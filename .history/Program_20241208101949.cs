﻿using System;

class Human{
   public int age;
    public static int p;
    
    static void ff(){
        Console.WriteLine("Hello");
    }
}
class Program
{
    static void f(){
        Human.p += 1;
    }
    static void Main(string[] args)
    {
      Human h1 = new Human { age = 25 };
      Human h2 = new Human { age = 25 };
    }
}  



