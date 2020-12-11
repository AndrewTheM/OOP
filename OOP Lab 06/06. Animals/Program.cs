using Animals.Models;
using Animals.Models.Base;
using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Beast!")
                    break;

                string animalType = line;

                line = Console.ReadLine();
                if (line == "Beast!")
                    break;

                var animalInputs = line.Split(' ');

                try
                {
                    string name = animalInputs[0];

                    if (!int.TryParse(animalInputs[1], out int age))
                        throw new Exception("Invalid input!");

                    string gender = (animalType == nameof(Tomcat) || animalType == nameof(Kitten))
                                    ? null
                                    : animalInputs[2];

                    Animal animal = animalType switch
                    {
                        nameof(Dog) => new Dog(name, age, gender),
                        nameof(Cat) => new Cat(name, age, gender),
                        nameof(Frog) => new Frog(name, age, gender),
                        nameof(Kitten) => new Kitten(name, age),
                        nameof(Tomcat) => new Tomcat(name, age),
                        _ => throw new Exception("Invalid input!")
                    };
                    animals.Add(animal);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Invalid input!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            animals.ForEach(Console.Write);

            Console.ReadKey();
        }
    }
}