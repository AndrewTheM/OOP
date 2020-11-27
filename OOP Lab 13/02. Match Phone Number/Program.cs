using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MatchPhoneNumber
{
    class Program
    {
        // Odd group numbers are phone number parts
        // Even group numbers are separators, all equal
        const string pattern = @"(?<=^| )(\+359)(-| )(\d)(\2)(\d{3})(\2)(\d{4})\b";

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
