using FoodShortage.Models;
using FoodShortage.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            var buyers = new List<IBuyer>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; ++i)
            {
                var inputs = Console.ReadLine().Split(' ');

                try
                {
                    string name = inputs[0];
                    int age = int.Parse(inputs[1]);

                    if (buyers.OfType<IPerson>().Any(p => p.Name == name))
                        throw new Exception($"There is already a person with name {name}");

                    buyers.Add(inputs.Length switch
                    {
                        3 => new Rebel(name, age, inputs[2]),
                        4 => new Citizen(name, age, inputs[2], inputs[3]),
                        _ => throw new Exception("Invalid input.")
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    --i;
                }
            }

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                var person = buyers.OfType<IPerson>().SingleOrDefault(p => p.Name == line);

                if (person is IBuyer buyer)
                    buyer.BuyFood();
            }

            int sumFood = buyers.Sum(b => b.Food);
            Console.WriteLine(sumFood);

            Console.ReadKey();
        }
    }
}
