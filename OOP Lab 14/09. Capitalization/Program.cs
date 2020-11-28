using System;
using System.Linq;
using System.Text;

namespace Capitalization
{
    class Program
    {
        static readonly char[] separators = { ' ', '.', ',', '?', '!', ';' };

        static void Main(string[] args)
        {
            string line = Console.ReadLine();

            var words = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            var betweenWords = line.Split(words, StringSplitOptions.RemoveEmptyEntries);
            var capitalizedWords = words.Select(w => char.ToUpper(w[0]) + w[1..]).ToArray();
            var strBuilder = new StringBuilder();

            for (int i = 0; i < capitalizedWords.Length; ++i)
            {
                strBuilder.Append(capitalizedWords[i]);
                if (i < betweenWords.Length)
                    strBuilder.Append(betweenWords[i]);
            }

            string result = strBuilder.ToString();
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
