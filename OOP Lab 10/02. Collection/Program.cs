using CollectionImplementation.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] items;

            while (true)
            {
                var inputs = Console.ReadLine().Split(' ');
                if (inputs[0] == "Create")
                {
                    items = inputs.Skip(1).ToArray();
                    break;
                }
                else
                    Console.WriteLine("You must first provide a Create command with the list of items.");
            }

            var list = new List<string>(items);
            var iterator = new ListyIterator<string>(list);

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                    break;

                if (string.IsNullOrWhiteSpace(command))
                    continue;

                try
                {
                    switch (command)
                    {
                        case "Create":
                            throw new InvalidOperationException("There can only be one Create command.");
                        case "Move":
                            {
                                Console.WriteLine(iterator.Move());
                                break;
                            }
                        case "Print":
                            {
                                iterator.Print();
                                break;
                            }
                        case "HasNext":
                            {
                                Console.WriteLine(iterator.HasNext());
                                break;
                            }
                        case "Reset":
                            {
                                iterator.Reset();
                                break;
                            }
                        case "PrintAll":
                            {
                                var strBuilder = new StringBuilder();

                                foreach (var item in iterator)
                                    strBuilder.Append($"{item} ");

                                Console.WriteLine(strBuilder.ToString().TrimEnd());
                                break;
                            }
                        default:
                            throw new InvalidOperationException("Invalid command.");
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
