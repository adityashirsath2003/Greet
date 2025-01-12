﻿using System;
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
            // new Student { StudentId = 1, Name = "Aditya" },
            new Student { StudentId = 2, Name = "Bob" },
            new Student { StudentId = 3, Name = "Charlie" },
            new Student { StudentId = 4, Name = "Prem" }
        };
        
        List<Enrollment> e= new List<Enrollment>
        {
            new Enrollment { EnrollmentId = 101, StudentId = 1, Course = "Math" },
            new Enrollment { EnrollmentId = 101, StudentId = 2, Course = "Math" },
            new Enrollment { EnrollmentId = 101, StudentId = 3, Course = "Math" },
            new Enrollment { EnrollmentId = 102, StudentId = 2, Course = "Science" },
            new Enrollment { EnrollmentId = 103, StudentId = 1, Course = "History" },
            new Enrollment { EnrollmentId = 104, StudentId = 3, Course = "Geography" },
            new Enrollment { EnrollmentId = 105, StudentId = 4, Course = "EVS" }
        };

        //Cross join
        // foreach(var s1 in s){
        //     foreach(var e1 in e){
        //         Console.WriteLine($"{s1.StudentId}, {s1.Name}, {e1.EnrollmentId}");
        //     }
        // }
         


         //Inner join
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

        //Left and Right
        // var x = s.GroupJoin(e,
        // a => a.StudentId,
        // b => b.StudentId,
        // (a,g)=>new {
        //    a.Name,
        //    g
        // });
        
        // string x1 = " ";
        // foreach (var g1 in x){
        //     x1 = g1.Name;
        //     if(g1.g.Count() == 0){
        //        Console.WriteLine($"{x1}, Null");
        //     }
        // foreach (var item in g1.g)
        // {
        //     Console.WriteLine($"{x1}, {item.EnrollmentId}");
        // }
        
        // }


        // Student a = new Student { StudentId = 1, Name = "Alice" };
        // Student b = a;
        // Student c = new Student { StudentId = 1, Name = "Alice" };
        // List<Student> c1 = new List<Student> {a,c};
        // List<Student> c2 = new List<Student> {b};

        // // var c3 = c1.Distinct();
        // var c3 = c1.Union(c2);
        // foreach(var x in c3){
        //     Console.WriteLine(x.Name);
        // }
        
    //   var numbers1 = new List<int> { 1,2,5,4,3};
    //   var x = numbers1.GroupJoin(numbers1,
    //     a => a,
    //     b => b,
    //     (a,g)=>new {
    //         a,
    //         g   
    //     });

    //  foreach (var g1 in numbers1){
    //     foreach (var g2 in numbers1)
    //     {
    //         if(g2 - g1 == 1)
    //         Console.WriteLine($"{g1},{g2}");
    //     }
    //     }



    //Chatgpt
    /*
You have two lists: one containing Student objects and another containing Enrollment objects. Each Student has a unique StudentId and a Name, and each Enrollment has a StudentId and a Course. Some students may have multiple enrollments (i.e., they may be enrolled in more than one course).
Task: Write a LINQ query to retrieve the names of students who are enrolled in at least two courses, along with the names of the courses they are enrolled in.
The result should be grouped by each student, showing their name and the list of courses they are enrolled in. If a student is enrolled in multiple courses, only include those students.
The output should be sorted by the student's name in ascending order.

    */
     
     var list = s.GroupJoin(e,
     a => a.StudentId,
     b => b.StudentId,
     (a,g)=>new{
        Name = a.Name,
        Group = g
     }).Where(n => n.Group.Count() >= 2).OrderBy(n => n.Name);


        foreach (var g1 in list){
          Console.WriteLine(g1.Name);
        foreach (var item in g1.Group)
        {
            Console.WriteLine($" {item.Course}");
        }
        }


/*
You have two lists: one containing Student objects and another containing Enrollment objects. Each Student has a StudentId and a Name, and each Enrollment has a StudentId and a Course. Some students may have multiple enrollments (i.e., they may be enrolled in more than one course).
Question:
Write a LINQ query to:
Find the most popular course (the course with the highest number of students enrolled).
For that most popular course, list the names of all students enrolled in it, along with the total number of students.
*/

     //Most Popular Course

 
    }
}  



