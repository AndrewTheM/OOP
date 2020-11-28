using System;
using System.Linq;

namespace Palindromes
{
    static class StringExtensions
    {
        public static bool IsPalindrome(this string str)
            => str == new string(str.Reverse().ToArray());
    }

    class Program
    {
        static readonly char[] separators = { ' ', ',', '.', '?', '!' };

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = words.Where(w => w.IsPalindrome())
                                    .OrderBy(w => w)
                                    .ToArray();

            string output = string.Join(", ", palindromes);
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
