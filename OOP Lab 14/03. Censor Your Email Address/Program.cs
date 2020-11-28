using System;
using System.Text.RegularExpressions;

namespace CensorYourEmailAddress
{
    class Program
    {
        // Regex from 13-05 https://regex101.com/r/2w0LWs/1
        const string pattern = @"(?<=\s|[^\w.-]|^)(?<user>(?:[a-zA-Z0-9]+[._-]?[a-zA-Z0-9]+)+)@" +
                               @"(?<host>(?:[a-zA-Z]+[-]?[a-zA-Z]+)+(?:\.(?:[a-zA-Z]+[-]?[a-zA-Z]+)+)+)(?=\s|\b)";

        static void Main(string[] args)
        {
            string email = Console.ReadLine(),
                    text = Console.ReadLine();

            if (Regex.IsMatch(email, pattern))
            {
                //string username = Regex.Match(email, pattern).Groups["user"].Value;

                string username = email.Split('@')[0],
                       mask = new string('*', username.Length),
                       censoredEmail = email.Replace(username, mask),
                       censoredText = text.Replace(email, censoredEmail);

                Console.WriteLine(censoredText);
            }
            else
                Console.WriteLine("Invalid email.");

            Console.ReadKey();
        }
    }
}
