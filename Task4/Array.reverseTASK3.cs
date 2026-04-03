using System;

class Program
{
    static void Main()
    {
        string[] words = { "apple", "banana", "cherry", "date" };
        string[] builtIn = (string[])words.Clone();
        Array.Reverse(builtIn);
        Console.WriteLine(string.Join(" ", builtIn));
    }
}
