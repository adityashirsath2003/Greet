using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your name:");  
        string name = Console.ReadLine();
        Console.WriteLine("Enter your age:");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Hello, {name}! You are {age} years old.");
    }
}    