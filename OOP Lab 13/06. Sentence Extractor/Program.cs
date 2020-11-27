using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SentenceExtractor
{
    class Program
    {
        // https://regex101.com/r/o3JXZ9/1/

        const string pattern = @"\b.+?[?!.]";

        static void Main(string[] args)
        {
            string keyword = Console.ReadLine(),
                   input = Console.ReadLine();

            var sentences = Regex.Matches(input, pattern)
                                .Select(m => m.Value)
                                .ToList();

            var containingSentences = sentences.Where(s => Regex.IsMatch(s, @$"\b{keyword}\b")).ToList();

            containingSentences.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
