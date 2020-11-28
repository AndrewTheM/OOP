using System;
using System.Collections.Generic;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line.ToLower() == "end")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    var inputs = line.Split(' ');
                    string command = inputs[0],
                            name = inputs[1];

                    switch (command)
                    {
                        case "A":
                            {
                                string phone = inputs[2];
                                phonebook[name] = phone;
                                break;
                            }
                        case "S":
                            {
                                try
                                {
                                    Console.WriteLine($"{name} -> {phonebook[name]}");
                                    break;
                                }
                                catch (KeyNotFoundException)
                                {
                                    throw new Exception($"Contact {name} does not exist.");
                                }
                            }
                        default: throw new Exception("Invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
