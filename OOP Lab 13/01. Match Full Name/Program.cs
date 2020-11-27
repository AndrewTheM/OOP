using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        const string pattern = @"\b([A-Z]{1}[a-z]+)[ ]([A-Z]{1}[a-z]+)\b";

        static void Main(string[] args)
        {
            var values = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "end")
                    break;

                if (Regex.IsMatch(line, pattern))
                    values.Add(line);
            }

            values.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
