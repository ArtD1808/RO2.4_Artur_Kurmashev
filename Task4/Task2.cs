using System;

class Program
{
    static void Main()
    {
        int[] temps = { 12, -3, 45, 0, 28, -10, 33 };

        Array.Sort(temps);
        Console.WriteLine("Using Array.Sort():");
        Console.WriteLine("Min = " + temps[0] + ", Max = " + temps[temps.Length - 1]);

        int min = temps[0];
        int max = temps[0];
        foreach (int temp in temps)
        {
            min = Math.Min(min, temp);
            max = Math.Max(max, temp);
        }
        Console.WriteLine("Using Math.Min/Math.Max:");
        Console.WriteLine("Min = " + min + ", Max = " + max);
    }
}
