﻿using System;
using System.Text.RegularExpressions;

namespace SeriesOfLetters
{
    class Program
    {
        const string pattern = @"(?<=([a-zA-Z]))\1+";

        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string replacedLine = Regex.Replace(line, pattern, string.Empty);

            Console.WriteLine(replacedLine);
            Console.ReadKey();
        }
    }
}
