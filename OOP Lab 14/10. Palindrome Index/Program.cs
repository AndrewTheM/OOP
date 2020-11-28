using System;
using System.Linq;

namespace PalindromeIndex
{
    static class StringExtensions
    {
        public static bool IsPalindrome(this string str)
            => str == new string(str.Reverse().ToArray());
    }

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int index = -1;

            if (!input.IsPalindrome())
            {
                for (int i = 0; i < input.Length; ++i)
                    if ((input[..i] + input[(i + 1)..]).IsPalindrome())
                    {
                        index = i;
                        break;
                    }

                if (index == -1)
                {
                    Console.WriteLine("Cannot make a palindrome out of given string.");
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine(index);
            Console.ReadKey();
        }
    }
}
