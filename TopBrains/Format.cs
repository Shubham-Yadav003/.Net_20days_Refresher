using System;
using System.Collections.Generic;
using System.Text.Json;
namespace TopBrains
{

public class Format
{
    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Student(string name, int score)
        {
            Name = name;
            Score = score;
        }
    }

    public string FormatStudents(string[] items, int minScore)
    {
        List<Student> students = new List<Student>();

        foreach (string item in items)
        {
            string[] data = item.Split(':');

            string name = data[0];
            int score = int.Parse(data[1]);

            if (score >= minScore)
                students.Add(new Student(name, score));
        }

        students.Sort((a, b) =>
        {
            int result = b.Score.CompareTo(a.Score);

            if (result == 0)
                result = a.Name.CompareTo(b.Name);

            return result;
        });

        return JsonSerializer.Serialize(students);
    }
}

public class FormatTest
{
    public static void Run()
    {
        string[] items =
        {
            "John:80",
            "Alice:90",
            "Bob:80",
            "David:70"
        };

        int minScore = 80;

        Format format = new Format();

        string result = format.FormatStudents(items, minScore);

        Console.WriteLine(result);
    }
}
}