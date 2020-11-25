using EqualityLogic.Models;
using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedSet = new SortedSet<Person>();
            var hashSet = new HashSet<Person>();

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
                    sortedSet.Add(person);
                    hashSet.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    --i;
                }
            }
            
            Console.WriteLine(sortedSet.Count);
            Console.WriteLine(hashSet.Count);

            Console.ReadKey();
        }
    }
}
