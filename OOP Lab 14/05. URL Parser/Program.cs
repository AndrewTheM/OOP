using System;
using System.Text.RegularExpressions;

namespace URLParser
{
    class Program
    {
        // https://regex101.com/r/jHd1hU/1

        const string pattern = @"\b(?:(?<protocol>[a-z]+):\/\/|(?=w{3}\.))" +
                               @"(?<server>[^\/\s?]{4,})\/?(?<resource>[^\s?]+)?.*\b";

        static void Main(string[] args)
        {
            string url = Console.ReadLine();
            var urlGroups = Regex.Match(url, pattern).Groups;

            Console.WriteLine($"[protocol] = \"{urlGroups["protocol"]}\"");
            Console.WriteLine($"[server] = \"{urlGroups["server"]}\"");
            Console.WriteLine($"[resource] = \"{urlGroups["resource"]}\"");
            Console.ReadKey();
        }
    }
}
