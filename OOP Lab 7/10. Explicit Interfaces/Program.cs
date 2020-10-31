using ExplicitInterfaces.Models;
using System;
using System.Collections.Generic;

namespace ExplicitInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var citizens = new List<Citizen>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                var inputs = line.Split(' ');

                try
                {
                    var citizen = new Citizen(inputs[0], inputs[1], int.Parse(inputs[2]));
                    citizens.Add(citizen);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var citizen in citizens)
            {
                Console.WriteLine((citizen as IPerson).GetName());
                Console.WriteLine((citizen as IResident).GetName());
            }

            Console.ReadKey();
        }
    }
}
