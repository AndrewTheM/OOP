using System;

class ConditionsExercises
{
    static void Main()
    {
        Problem14();
        //Problem15();
        //Problem16();

        Console.ReadKey();
    }

    static void Problem14()
    {
        double a, b, c, max;

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        if (a > b && a > c)
            max = a;
        else if (b > c)
            max = b;
        else
            max = c;

        Console.WriteLine($"Max: {max}");
    }

    static void Problem15()
    {
        double a, b, c;

        Console.Write("a = ");
        a = double.Parse(Console.ReadLine());

        Console.Write("b = ");
        b = double.Parse(Console.ReadLine());

        Console.Write("c = ");
        c = double.Parse(Console.ReadLine());

        Console.Write("Sign: ");

        bool f1 = (a < 0), f2 = (b < 0), f3 = (c < 0);
        if (f1 && (f2 && !f3 || !f2 && f3) || !f1 && (f2 && f3 || !f2 && !f3))
            Console.WriteLine("Positive");
        else
            Console.WriteLine("Negative");
    }

    static void Problem16()
    {
        Console.Write("Enter digit (1-7): ");
        string digit = Console.ReadLine();

        string result = digit switch
        {
            "1" => "Monday",
            "2" => "Tuesday",
            "3" => "Wednesday",
            "4" => "Thursday",
            "5" => "Friday",
            "6" => "Saturday",
            "7" => "Sunday",
            _ => "not valid",
        };
        Console.WriteLine($"Day of Week: {result}");
    }
}
