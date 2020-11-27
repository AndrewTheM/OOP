using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        // https://regex101.com/r/C1VETI/1

        // Odd group numbers are phone number parts
        // Even group numbers are separators, all equal
        const string pattern = @"(?<=^| )(\+359)(-| )(\d)(\2)(\d{3})(\2)(\d{4})\b";

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

            var phoneNumbers = lines.Where(l => Regex.IsMatch(l, pattern)).ToList();

            phoneNumbers.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
