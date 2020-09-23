using Google.Models;
using System;
using System.Collections.Generic;

namespace Google
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleInfo = new List<PersonInfo>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                string[] inputs = line.Replace('.', ',').Split(' ');

                string name = inputs[0],
                        command = inputs[1];

                PersonInfo info = null;

                foreach (var item in peopleInfo)
                    if (item.Name == name)
                    {
                        info = item;
                        break;
                    }

                if (info == null)
                {
                    info = new PersonInfo(name);
                    peopleInfo.Add(info);
                }

                switch (command)
                {
                    case "company":
                        {
                            string companyName = inputs[2],
                                    companyDepartment = inputs[3];
                            double companySalary = double.Parse(inputs[4]);

                            info.Company = new Company(companyName, companyDepartment, companySalary);
                            break;
                        }
                    case "car":
                        {
                            string carModel = inputs[2];
                            int carSpeed = int.Parse(inputs[3]);

                            info.Car = new Car(carModel, carSpeed);
                            break;
                        }
                    case "pokemon":
                        {
                            string pokemonName = inputs[2],
                                    pokemonType = inputs[3];

                            info.Pokemon.Add(new Pokemon(pokemonName, pokemonType));
                            break;
                        }
                    case "parents":
                        {
                            string parentName = inputs[2];
                            DateTime parentBirthday = DateTime.Parse(inputs[3]);

                            info.Parents.Add(new Person(parentName, parentBirthday));
                            break;
                        }
                    case "children":
                        {
                            string childName = inputs[2];
                            DateTime childBirthday = DateTime.Parse(inputs[3]);

                            info.Children.Add(new Person(childName, childBirthday));
                            break;
                        }
                }
            }

            string personName = Console.ReadLine();
            Console.WriteLine();

            foreach (var personInfo in peopleInfo)
                if (personInfo.Name == personName)
                {
                    PrintInfo(personInfo);
                    break;
                }

            Console.ReadKey();
        }

        static void PrintInfo(PersonInfo info)
        {
            Console.WriteLine(info.Name);

            Console.WriteLine("Company:");
            if (info.Company != null)
                Console.WriteLine(info.Company);

            Console.WriteLine("Car:");
            if (info.Car != null)
                Console.WriteLine(info.Car);

            Console.WriteLine("Pokemon:");
            foreach (var pokemon in info.Pokemon)
                Console.WriteLine(pokemon);

            Console.WriteLine("Parents:");
            foreach (var parent in info.Parents)
                Console.WriteLine(parent);

            Console.WriteLine("Children:");
            foreach (var child in info.Children)
                Console.WriteLine(child);
        }
    }
}
