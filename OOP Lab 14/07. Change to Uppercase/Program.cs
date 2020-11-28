using System;
using System.Text.RegularExpressions;

namespace ChangeToUppercase
{
    class Program
    {
        const string pattern = @"<upcase>(.*?)</upcase>";

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var matches = Regex.Matches(line, pattern);

            foreach (Match match in matches)
                line = line.Replace(match.Value, match.Groups[1].Value.ToUpper());

            Console.WriteLine(line);
            Console.ReadKey();
        }
    }
}
