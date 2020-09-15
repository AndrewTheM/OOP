using System;

namespace DateDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine(), str2 = Console.ReadLine();
            var dateModifier = new DateModifier();
            Console.WriteLine(dateModifier.DaysBetween(str1, str2));
            Console.ReadKey();
        }
    }
}
