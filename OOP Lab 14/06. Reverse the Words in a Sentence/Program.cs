using System;
using System.Linq;
using System.Text;

namespace ReverseTheWordsInASentence
{
    class Program
    {
        static readonly char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[',
                                              ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries)
                            .Reverse()
                            .ToArray();

            var betweenWords = line.Split(words, StringSplitOptions.RemoveEmptyEntries);
            var strBuilder = new StringBuilder();

            for (int i = 0; i < words.Length; ++i)
            {
                strBuilder.Append(words[i]);
                if (i < betweenWords.Length)
                    strBuilder.Append(betweenWords[i]);
            }

            string result = strBuilder.ToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
