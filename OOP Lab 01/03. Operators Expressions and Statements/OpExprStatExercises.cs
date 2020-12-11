using System;

class OpExprStatExercises
{
    static void Main()
    {
        Problem8();
        //Problem9();
        //Problem10();
        //Problem11();
        //Problem12();
        //Problem13();

        Console.ReadKey();
    }

    static void Problem8()
    {
        double a, b, c, average;

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        average = (a + b + c) / 3;
        Console.WriteLine($"Average: {average}");
    }

    static void Problem9()
    {
        double a, b, h, area;

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());

        Console.Write("h = ");
        h = double.Parse(Console.ReadLine());

        area = (a + b) / 2 * h;
        Console.WriteLine($"Area: {area}");
    }

    static void Problem10()
    {
        int n, lastDigit;

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());

        lastDigit = n % 10;
        Console.WriteLine($"Last Digit: {lastDigit}");
    }

    static void Problem11()
    {
        int number, n, digit;

        Console.Write("number = ");
        number = int.Parse(Console.ReadLine());

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());

        digit = number / (int)Math.Pow(10, n - 1) % 10;
        Console.WriteLine($"Nth Digit: {digit}");
    }

    static void Problem12()
    {
        int n;
        bool result;

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());

        result = n % 2 == 1 && n > 20;
        Console.WriteLine($"n is greater than 20 and odd: {result}");
    }

    static void Problem13()
    {
        int n;
        bool result;

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());

        result = n % 9 == 0 || n % 11 == 0 || n % 13 == 0;
        Console.WriteLine($"n is divided by 9, 11 or 13 without remainder: {result}");
    }
}
