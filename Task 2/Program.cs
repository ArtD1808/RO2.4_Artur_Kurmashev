using System;

static int ReadInt(string prompt)
{
    Console.Write(prompt);
    while (true)
    {
        string? s = Console.ReadLine();
        if (int.TryParse(s, out int value)) return value;
        Console.Write("Enter an integer: ");
    }
}

static double ReadDouble(string prompt)
{
    Console.Write(prompt);
    while (true)
    {
        string? s = Console.ReadLine();
        if (double.TryParse(s, out double value)) return value;
        Console.Write("Enter a number: ");
    }
}

Console.WriteLine("Exercise 1:");
{
    int a = ReadInt("Enter first number: ");
    int b = ReadInt("Enter second number: ");

    if (a == b) Console.WriteLine("The numbers are equal");
    else if (a > b) Console.WriteLine("The first number is greater than the second");
    else Console.WriteLine("The first number is less than the second");
}

Console.WriteLine();
Console.WriteLine("Exercise 2:");
{
    int n = ReadInt("Enter a number: ");

    if (n > 5 && n < 10)
        Console.WriteLine("The number is greater than 5 and less than 10");
    else
        Console.WriteLine("Unknown number");
}

Console.WriteLine();
Console.WriteLine("Exercise 3:");
{
    int n = ReadInt("Enter a number: ");

    if (n == 5 || n == 10)
        Console.WriteLine("The number is either 5 or 10");
    else
        Console.WriteLine("Unknown number");
}

Console.WriteLine();
Console.WriteLine("Exercise 4:");
{
    double deposit = ReadDouble("Enter deposit amount: ");

    double rate;

    if (deposit < 100) rate = 0.05;
    else if (deposit <= 200) rate = 0.07;
    else rate = 0.10;

    double result = deposit + deposit * rate;

    Console.WriteLine(result);
}

Console.WriteLine();
Console.WriteLine("Exercise 5:");
{
    double deposit = ReadDouble("Enter deposit amount: ");

    double rate;

    if (deposit < 100) rate = 0.05;
    else if (deposit <= 200) rate = 0.07;
    else rate = 0.10;

    double result = deposit + deposit * rate + 15;

    Console.WriteLine(result);
}

Console.WriteLine();
Console.WriteLine("Exercise 6:");
{
    Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
    int op = ReadInt("Operation: ");

    switch (op)
    {
        case 1:
            Console.WriteLine("Addition");
            break;
        case 2:
            Console.WriteLine("Subtraction");
            break;
        case 3:
            Console.WriteLine("Multiplication");
            break;
        default:
            Console.WriteLine("Operation is undefined");
            break;
    }
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Exercise 7:");
{
    Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
    int op = ReadInt("Operation: ");
    double x = ReadDouble("Enter first number: ");
    double y = ReadDouble("Enter second number: ");

    switch (op)
    {
        case 1:
            Console.WriteLine(x + y);
            break;
        case 2:
            Console.WriteLine(x - y);
            break;
        case 3:
            Console.WriteLine(x * y);
            break;
        default:
            Console.WriteLine("Operation is undefined");
            break;
    }
}
