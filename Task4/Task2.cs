using System;

class Program
{
    static void Main()
    {
        int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
        Array.Sort(temps);
        Console.WriteLine("Min = " + temps[0] + ", Max = " + temps[temps.Length - 1]);
    }
}
