using CatLady.Models;
using System;
using System.Collections.Generic;

namespace CatLady
{
    class Program
    {
        static void Main(string[] args)
        {
            var cats = new List<Cat>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                string[] inputs = line.Split(' ');

                string breed = inputs[0],
                        name = inputs[1];

                Cat cat = null;

                foreach (var item in cats)
                    if (item.Name == name)
                    {
                        cat = item;
                        break;
                    }

                if (cat == null)
                {
                    cat = breed switch
                    {
                        nameof(Siamese) => new Siamese(name, int.Parse(inputs[2])),
                        nameof(Cymric) => new Cymric(name, double.Parse(inputs[2])),
                        nameof(StreetExtraordinaire) => new StreetExtraordinaire(name, int.Parse(inputs[2])),
                        _ => null
                    };
                    cats.Add(cat);
                }
                else
                {
                    switch (breed)
                    {
                        case nameof(Siamese):
                            {
                                (cat as Siamese).EarSize = int.Parse(inputs[2]);
                                break;
                            }
                        case nameof(Cymric):
                            {
                                (cat as Cymric).FurLength = double.Parse(inputs[2]);
                                break;
                            }
                        case nameof(StreetExtraordinaire):
                            {
                                (cat as StreetExtraordinaire).Decibels = int.Parse(inputs[2]);
                                break;
                            }
                    }
                }
            }

            string catName = Console.ReadLine();
            Console.WriteLine();

            foreach (var cat in cats)
                if (cat.Name == catName)
                {
                    Console.WriteLine(cat);
                    break;
                }

            Console.ReadKey();
        }
    }
}
