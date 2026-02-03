using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public override string ToString()
    {
        return $"{Name,-10} Age: {Age}, Marks: {Marks}";
    }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Amit", Age = 20, Marks = 85 },
            new Student { Name = "Bob", Age = 19, Marks = 85 },
            new Student { Name = "Chris", Age = 21, Marks = 90 },
            new Student { Name = "Rahul", Age = 18, Marks = 85 }
        };

        var sortedStudents = SortStudents(students);

        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s);
        }
    }

    static List<Student> SortStudents(List<Student> students)
    {
        if (students == null || students.Count == 0)
            return new List<Student>();

        return students
            .OrderByDescending(s => s.Marks) // 1️⃣ Highest Marks
            .ThenBy(s => s.Age)              // 2️⃣ Youngest Age
            .ToList();
    }
}