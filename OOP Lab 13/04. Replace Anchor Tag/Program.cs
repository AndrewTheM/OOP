﻿using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ReplaceAnchorTag
{
    class Program
    {
        // https://regex101.com/r/HRIg13/1

        // General version (v1)
        //const string pattern = @"<a(.*?)>(.*?)<\/a>";
        //const string replacement = "[URL$1]$2[/URL]";

        // Task version (v2)
        const string pattern = "<a\\s+href=([\"\'])(.*?)\\1>(.*?)<\\/a>";
        const string replacement = "[URL href=$2>$3[/URL]";

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

            string replaced = regex.Replace(input, replacement);
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
