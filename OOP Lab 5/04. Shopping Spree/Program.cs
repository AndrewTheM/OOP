using ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var products = new List<Product>();

            try
            {
                var peopleEntries = Console.ReadLine().Split(';');
                foreach (var entry in peopleEntries)
                {
                    if (string.IsNullOrWhiteSpace(entry))
                        break;

                    var inputs = entry.Split('=');
                    string name = inputs[0];
                    double money = double.Parse(inputs[1].Replace('.', ','));

                    people.Add(new Person(name, money));
                }

                var productEntries = Console.ReadLine().Split(';');
                foreach (var entry in productEntries)
                {
                    if (string.IsNullOrWhiteSpace(entry))
                        break;

                    var inputs = entry.Split('=');
                    string name = inputs[0];
                    double cost = double.Parse(inputs[1].Replace('.', ','));

                    products.Add(new Product(name, cost));
                }

                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                        break;

                    var inputs = line.Split(' ');

                    string personName = inputs[0],
                            productName = inputs[1];

                    var person = people.Find(p => p.Name == personName);
                    var product = products.Find(pr => pr.Name == productName);

                    if (person == null || product == null)
                        throw new Exception("Name was not found.");

                    person.BuyProduct(product);
                    Console.WriteLine($"{personName} bought {productName}\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }

            PrintPeople(people);

            Console.ReadKey();
        }

        static void PrintPeople(List<Person> people)
        {
            foreach (var person in people)
            {
                Console.Write($"{person.Name} - ");

                var products = person.GetProducts().ToList();
                
                if (products.Count == 0)
                {
                    Console.Write("Nothing bought");
                }
                else
                {
                    for (int i = 0; i < products.Count; ++i)
                    {
                        Console.Write($"{products[i].Name}");

                        if (i != products.Count - 1)
                            Console.Write(", ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
