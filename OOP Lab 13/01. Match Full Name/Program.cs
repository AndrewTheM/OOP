using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        // https://regex101.com/r/b732io/1

        const string pattern = @"\b([A-Z]{1}[a-z]+)[ ]([A-Z]{1}[a-z]+)\b";

        static void Main(string[] args)
        {
            var lines = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "end")
                    break;

                lines.Add(line);
            }

            var fullNames = lines.Where(l => Regex.IsMatch(l, pattern)).ToList();

            fullNames.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
