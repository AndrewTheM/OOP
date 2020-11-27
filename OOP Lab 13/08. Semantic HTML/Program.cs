using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SemanticHTML
{
    class Program
    {
        // https://regex101.com/r/mazLT4/1

        const string pattern = "<div(.*?)\\s+(?:id|class)\\s*=\\s*([\"\'])(\\w+)\\2" +
                               "\\s*(\\s.*?)?\\s*>(.*?)<\\/div>\\s*<!--\\s*\\3\\s*-->";
        const string replacement = "<$3$1$4>$5</$3>";

        static void Main(string[] args)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline);
            string path, input;

            while (true)
            {
                Console.Write("Source path: ");
                path = Console.ReadLine();

                if (File.Exists(path))
                {
                    input = File.ReadAllText(path);
                    break;
                }

                Console.WriteLine("File does not exist. Press any key to try again, or Esc to exit.");
                var keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.Escape)
                    return;

                Console.Clear();
            }

            string replaced = input;

            while (regex.IsMatch(replaced))
                replaced = regex.Replace(replaced, replacement);

            Console.WriteLine(Environment.NewLine + replaced + Environment.NewLine);

            string dir = Path.GetDirectoryName(path),
                   file = Path.GetFileNameWithoutExtension(path),
                   ext = Path.GetExtension(path);

            File.WriteAllText($"{dir}/{file}_REPLACED{ext}", replaced);
            Console.WriteLine("Done.");

            Console.ReadKey();
        }
    }
}
