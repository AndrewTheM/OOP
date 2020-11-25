using ComparingObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var inputs = line.Split(' ');

                try
                {
                    string name = inputs[0];
                    int age = int.Parse(inputs[1]);
                    string town = inputs[2];

                    var person = new Person(name, age, town);
                    people.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            int number = 0;
            while (!int.TryParse(Console.ReadLine(), out number) ||
                    number < 1 || number > people.Count)
            {
                Console.WriteLine("Person number should be a positive integer.");
            }

            var chosenPerson = people[number - 1];
            var peopleEqualToChosen = people.GroupBy(p => p.CompareTo(chosenPerson) == 0)
                                            .ToDictionary(g => g.Key, g => g.Count());
            
            if (peopleEqualToChosen[true] == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{peopleEqualToChosen[true]} " +
                                  $"{peopleEqualToChosen[false]} " +
                                  $"{peopleEqualToChosen.Sum(g => g.Value)}");
            }

            Console.ReadKey();
        }
    }
}
