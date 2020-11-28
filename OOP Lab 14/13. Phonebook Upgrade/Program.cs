using System;
using System.Collections.Generic;

namespace PhonebookUpgrade
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new SortedDictionary<string, string>();

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
                    string command = inputs[0];

                    switch (command)
                    {
                        case "A":
                            {
                                string name = inputs[1],
                                        phone = inputs[2];

                                phonebook[name] = phone;
                                break;
                            }
                        case "S":
                            {
                                string name = inputs[1];

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
                        case "PrintAll":
                            {
                                foreach (var pair in phonebook)
                                    Console.WriteLine($"{pair.Key} -> {pair.Value}");
                                break;
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
