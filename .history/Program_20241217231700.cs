using System;
using System.Formats.Asn1;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Collections;
using System.Runtime.Intrinsics.X86;
using System.Linq;

    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
    }

    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public string Course { get; set; }
    }
class Program
{
    static void Main(string[] args)
    {
           var numbers = new List<int> { 5,4,3,2,1 };
        //    var evenNumbersQuery = from n in numbers
        //                where n % 2 == 0
        //                select n;


    //   var x = numbers.GroupBy(n=>n%2 == 0).OrderBy(g => g.Key).Select(g => g.Select(g=>g*2).OrderBy(n=>n));
    //   foreach (var group in x){
    //         foreach (var number in group)
    //         {
    //             Console.WriteLine(number); 
    //         }
    //   }

    // List<String> l = new List<string>{"AdityaE","Hello","Prem"};

    // var s = l.Where(l=>l.ToLower().Contains("e"));
    // foreach(var s1 in s){
    //     Console.WriteLine(s1);
    // }


            List<Student> s = new List<Student>
        {
            new Student { StudentId = 1, Name = "Alice" },
            new Student { StudentId = 1, Name = "Aditya" },
            new Student { StudentId = 2, Name = "Bob" },
            new Student { StudentId = 3, Name = "Charlie" }
        };
        
        List<Enrollment> e= new List<Enrollment>
        {
            new Enrollment { EnrollmentId = 101, StudentId = 1, Course = "Math" },
            new Enrollment { EnrollmentId = 102, StudentId = 2, Course = "Science" },
            new Enrollment { EnrollmentId = 103, StudentId = 1, Course = "History" }
        };

        // var x = s.Join(e,
        // a => a.StudentId,
        // b => b.StudentId,
        // (a,b)=>new {
        //     a.Name,
        //     b.EnrollmentId
        // }).OrderBy(b=>b.EnrollmentId);
        
        
        
        // foreach (var item in x)
        // {
        //     Console.WriteLine($"Student: {item.Name}, Course: {item.EnrollmentId}");
        // }


        var x = s.GroupJoin(e,
        a => a.StudentId,
        b => b.StudentId,
        (a,g)=>new {
           a.Name,
           g
        });
 
        foreach (var g in x){
        foreach (var item in g)
        {
            Console.WriteLine($"Student: {item.Name}, Course: {item.EnrollmentId}");
        }
        }
 
    }
}  



