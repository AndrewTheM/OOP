using BirthdayCelebrations.Models;
using BirthdayCelebrations.Models.Interfaces;
using System;
using System.Collections.Generic;

namespace BirthdayCelebrations
{
    class Program
    {
        static void Main(string[] args)
        {
            var entities = new List<IEntity>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                var inputs = line.Split(' ');

                try
                {
                    entities.Add(inputs[0] switch
                    {
                        nameof(Robot) => new Robot(inputs[1], inputs[2]),
                        nameof(Citizen) => new Citizen(inputs[1], int.Parse(inputs[2]), inputs[3], inputs[4]),
                        nameof(Pet) => new Pet(inputs[1], inputs[2]),
                        _ => throw new Exception("Invalid command.")
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string year = Console.ReadLine();

            foreach (var entity in entities)
                if (entity is IBirthable birthable && birthable.Birthdate.EndsWith(year))
                    Console.WriteLine(birthable.Birthdate);

            Console.ReadKey();
        }
    }
}
