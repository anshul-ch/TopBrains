using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

public record Student(string Name, int Score);
class Program
{
    static void Main()
    {
        // Read number of students
        int count = int.Parse(Console.ReadLine());
        string[] students = new string[count];
        for (int i = 0; i < count; i++)
        {
            students[i] = Console.ReadLine();
        }

        // Get minimum score
        int minScore = int.Parse(Console.ReadLine());

        string json = BuildStudentsJson(students, minScore);
        Console.WriteLine(json);
    }

    static string BuildStudentsJson(string[] items, int minScore)
    {
        if (items == null || items.Length == 0)
            return "[]";

        List<Student> students = new();

        foreach (string item in items)
        {
            string[] parts = item.Split(':');

            if (parts.Length != 2)
                continue;

            int score = int.Parse(parts[1]);

            if (score >= minScore)
                students.Add(new Student(parts[0], score));
        }

        var sorted = students
            .OrderByDescending(s => s.Score)
            .ThenBy(s => s.Name)
            .ToList();

        return JsonSerializer.Serialize(sorted);
    }
}