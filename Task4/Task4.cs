using System;

class Program
{
    static void Main()
    {
        int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
        int even = 0;
        int odd = 0;

        foreach (int num in data)
        {
            if (num % 2 == 0)
                even++;
            else
                odd++;
        }

        Console.WriteLine("Even = " + even + ", Odd = " + odd);
    }
}
