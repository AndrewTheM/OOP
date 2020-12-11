using System;
using System.Collections.Generic;

namespace OpinionPoll
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                Person person = ParsePersonFromConsole();
                people.Add(person);
            }

            Console.WriteLine();

            for (int i = 0; i < people.Count - 1; ++i)
                for (int j = i + 1; j < people.Count; ++j)
                    if (string.Compare(people[i].Name, people[j].Name) > 0)
                        (people[i], people[j]) = (people[j], people[i]);

            foreach (var person in people)
                if (person.Age > 30)
                    Console.WriteLine($"{person.Name} - {person.Age}");

            Console.ReadKey();
        }

        static Person ParsePersonFromConsole()
        {
            string[] inputs = Console.ReadLine().Split(' ');

            string name = inputs[0];
            int age = int.Parse(inputs[1]);

            return new Person(name, age);
        }
    }
}
