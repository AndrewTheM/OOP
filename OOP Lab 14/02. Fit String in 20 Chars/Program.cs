using System;

namespace FitStringIn20Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string result = line;

            if (result.Length < 20)
                result = result.PadRight(20, '*');
            else if (result.Length > 20)
                result = result[..20];

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
