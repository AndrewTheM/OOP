using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace HarvestingFields
{
    class Program
    {
        const BindingFlags nonPublicFlags = BindingFlags.NonPublic | BindingFlags.Instance;

        static void Main(string[] args)
        {
            var commands = new List<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "HARVEST")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                switch (line)
                {
                    case "private":
                    case "public":
                    case "protected":
                    case "all":
                        {
                            commands.Add(line);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid modifier.");
                            break;
                        }
                }
            }

            var type = typeof(HarvestingFields);

            foreach (var command in commands)
            {
                Console.WriteLine();

                var fields = command switch
                {
                    "private" => type.GetFields(nonPublicFlags)
                                    .Where(f => f.IsPrivate),
                    "protected" => type.GetFields(nonPublicFlags)
                                    .Where(f => f.IsFamily),
                    "public" => type.GetFields(),
                    "all" => type.GetFields(BindingFlags.Public | nonPublicFlags),
                    _ => null
                };

                foreach (var field in fields)
                {
                    string modifier = command;

                    if (command == "all")
                    {
                        if (field.IsPrivate)
                            modifier = "private";
                        else if (field.IsFamily)
                            modifier = "protected";
                        else if (field.IsPublic)
                            modifier = "public";
                        else
                            modifier = "<unknown>";
                    }

                    Console.WriteLine($"{modifier} {field.FieldType.Name} {field.Name}");
                }
            }

            Console.ReadKey();
        }
    }
}
