using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace ValidUsernames
{
    class Program
    {
        // https://regex101.com/r/0iWbEr/1

        const string pattern = @"(?<!\w)(?:[a-zA-Z]\w{2,24})(?=[\s\/\\()]|$)";

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var usernames = Regex.Matches(line, pattern)
                                .Select(m => m.Value)
                                .ToList();

            var longestPair = Enumerable.Range(0, usernames.Count - 1)
                                .Select(i => new
                                {
                                    number = i,
                                    firstUser = usernames[i],
                                    secondUser = usernames[i + 1]
                                })
                                .OrderByDescending(u => (u.firstUser + u.secondUser).Length)
                                .ThenBy(u => u.number)
                                .FirstOrDefault();

            Console.WriteLine(longestPair.firstUser);
            Console.WriteLine(longestPair.secondUser);

            Console.ReadKey();
        }
    }
}
