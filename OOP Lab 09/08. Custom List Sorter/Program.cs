using CustomListSorter.Collections;
using CustomListSorter.Helpers;
using System;

namespace CustomListSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            var customList = new CustomList<string>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    var inputs = line.Split(' ');
                    string commandResult = null;

                    switch (inputs[0])
                    {
                        case "Add":
                            {
                                customList.Add(inputs[1]);
                                break;
                            }
                        case "Remove":
                            {
                                commandResult = customList.Remove(int.Parse(inputs[1]));
                                break;
                            }
                        case "Contains":
                            {
                                commandResult = customList.Contains(inputs[1]).ToString();
                                break;
                            }
                        case "Swap":
                            {
                                int firstIndex = int.Parse(inputs[1]);
                                int secondIndex = int.Parse(inputs[2]);

                                customList.Swap(firstIndex, secondIndex);
                                break;
                            }
                        case "Greater":
                            {
                                commandResult = customList.CountGreaterThan(inputs[1]).ToString();
                                break;
                            }
                        case "Max":
                            {
                                commandResult = customList.Max();
                                break;
                            }
                        case "Min":
                            {
                                commandResult = customList.Min();
                                break;
                            }
                        case "Print":
                            {
                                for (int i = 0; i < customList.Count; ++i)
                                    Console.WriteLine(customList[i]);
                                break;
                            }
                        case "Sort":
                            {
                                Sorter.Sort(customList);
                                break;
                            }
                        default: throw new Exception("Invalid command.");
                    }

                    if (commandResult != null)
                        Console.WriteLine(commandResult);
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
