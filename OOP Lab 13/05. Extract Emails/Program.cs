using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExtractEmails
{
    class Program
    {
        // https://regex101.com/r/2w0LWs/1

        const string pattern = @"(?<=\s|[^\w.-]|^)(?<user>(?:[a-zA-Z0-9]+[._-]?[a-zA-Z0-9]+)+)@" +
                               @"(?<host>(?:[a-zA-Z]+[-]?[a-zA-Z]+)+(?:\.(?:[a-zA-Z]+[-]?[a-zA-Z]+)+)+)(?=\s|\b)";

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var emails = Regex.Matches(line, pattern)
                            .Select(m => m.Value)
                            .ToList();

            emails.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
