using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
        List<int> unique = new List<int>();

        foreach (int num in raw)
        {
            if (!unique.Contains(num))
                unique.Add(num);
        }

        Console.WriteLine(string.Join(" ", unique));
    }
}
