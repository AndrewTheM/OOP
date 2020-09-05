using System;

class LoopExercises
{
    static void Main()
    {
        Problem17();

        Console.ReadKey();
    }

    static void Problem17()
    {
        int n, fact = 1;

        Console.Write("n = ");
        n = int.Parse(Console.ReadLine());

        for (int i = 2; i <= n; ++i)
            fact *= i;

        Console.WriteLine($"Factorial: {fact}");
    }
}
