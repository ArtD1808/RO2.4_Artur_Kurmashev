using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    private static int _idCounter = 1;
    private double _gpa;

    public string Name { get; set; }
    public int StudentId { get; }
    public string Faculty { get; set; }

    public double GPA
    {
        get => _gpa;
        set
        {
            if (value >= 0.0 && value <= 4.0)
            {
                _gpa = value;
            }
        }
    }

    public Student(string name, double gpa, string faculty)
    {
        StudentId = _idCounter++;
        Name = name;
        GPA = gpa;
        Faculty = faculty;
    }

    public override string ToString()
    {
        return $"ID: {StudentId} | Name: {Name} | Faculty: {Faculty} | GPA: {GPA:F2}";
    }
}

public class Registry
{
    private readonly Student[] _students = new Student[100];
    private int _count = 0;

    public bool Add(Student student)
    {
        if (_count >= 100) return false;
        _students[_count++] = student;
        return true;
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].StudentId == id) return _students[i];
        }
        return null;
    }

    public List<Student> FindByName(string name)
    {
        List<Student> results = new List<Student>();
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                results.Add(_students[i]);
            }
        }
        return results;
    }

    public List<Student> GetTopStudents(int n)
    {
        return _students
            .Take(_count)
            .OrderByDescending(s => s.GPA)
            .Take(n)
            .ToList();
    }

    public void PrintAll()
    {
        if (_count == 0)
        {
            Console.WriteLine("Registry is empty.");
            return;
        }
        for (int i = 0; i < _count; i++)
        {
            Console.WriteLine(_students[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Registry registry = new Registry();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n--- Student Registry Menu ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Find by ID");
            Console.WriteLine("3. Find by Name");
            Console.WriteLine("4. Top N Students");
            Console.WriteLine("5. Print All");
            Console.WriteLine("6. Exit");
            Console.Write("Select option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter GPA (0.0 - 4.0): ");
                    if (double.TryParse(Console.ReadLine(), out double gpa) && gpa >= 0 && gpa <= 4)
                    {
                        Console.Write("Enter Faculty: ");
                        string faculty = Console.ReadLine();
                        if (registry.Add(new Student(name, gpa, faculty)))
                            Console.WriteLine("Student added successfully.");
                        else
                            Console.WriteLine("Error: Registry full.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid GPA. Student not created.");
                    }
                    break;

                case "2":
                    Console.Write("Enter ID: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        var s = registry.FindById(id);
                        Console.WriteLine(s != null ? s.ToString() : "Student not found.");
                    }
                    break;

                case "3":
                    Console.Write("Enter Name: ");
                    string searchName = Console.ReadLine();
                    var results = registry.FindByName(searchName);
                    if (results.Count > 0)
                        results.ForEach(s => Console.WriteLine(s));
                    else
                        Console.WriteLine("No students found.");
                    break;

                case "4":
                    Console.Write("Enter N: ");
                    if (int.TryParse(Console.ReadLine(), out int n))
                    {
                        var top = registry.GetTopStudents(n);
                        top.ForEach(s => Console.WriteLine(s));
                    }
                    break;

                case "5":
                    registry.PrintAll();
                    break;

                case "6":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid selection.");
                    break;
            }
        }
    }
}
