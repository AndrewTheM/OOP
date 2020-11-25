using StrategyPattern.Helpers;
using StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstSet = new SortedSet<Person>(new PersonNameComparer());
            var secondSet = new SortedSet<Person>(new PersonAgeComparer());

            int personCount;
            while (!int.TryParse(Console.ReadLine(), out personCount) || personCount < 0)
                Console.WriteLine("Number of people should be a non-negative integer.");

            for (int i = 0; i < personCount; ++i)
            {
                try
                {
                    var inputs = Console.ReadLine().Split(' ');

                    string name = inputs[0];
                    int age = int.Parse(inputs[1]);

                    var person = new Person(name, age);
                    firstSet.Add(person);
                    secondSet.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    --i;
                }
            }

            foreach (var person in firstSet)
                Console.WriteLine(person);

            foreach (var person in secondSet)
                Console.WriteLine(person);

            Console.ReadKey();
        }
    }
}
