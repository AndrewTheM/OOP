using MilitaryElite.Models;
using MilitaryElite.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    class Program
    {
        static void Main(string[] args)
        {
            var soldiers = new List<ISoldier>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                try
                {
                    var inputs = line.Split(' ');

                    string command = inputs[0],
                            id = inputs[1],
                            firstName = inputs[2],
                            lastName = inputs[3];
                    double salary = double.Parse(inputs[4].Replace('.', ','));

                    ISoldier soldier;

                    switch (command)
                    {
                        case nameof(Private):
                            {
                                soldier = new Private(id, firstName, lastName, salary);
                                break;
                            }
                        case nameof(Spy):
                            {
                                soldier = new Spy(id, firstName, lastName, int.Parse(inputs[5]));
                                break;
                            }
                        case nameof(LeutenantGeneral):
                            {
                                soldier = new LeutenantGeneral(id, firstName, lastName, salary);

                                for (int i = 5; i < inputs.Length; ++i)
                                {
                                    var priv = soldiers.OfType<Private>()
                                                        .SingleOrDefault(pr => pr.Id == inputs[i]);

                                    if (priv != null)
                                        (soldier as LeutenantGeneral).Privates.Add(priv);
                                }
                                break;
                            }
                        case nameof(Engineer):
                            {
                                soldier = new Engineer(id, firstName, lastName, salary, inputs[5]);

                                for (int i = 6; i < inputs.Length - 1; i += 2)
                                {
                                    var repair = new Repair(inputs[i], int.Parse(inputs[i + 1]));
                                    (soldier as Engineer).Repairs.Add(repair);
                                }
                                break;
                            }
                        case nameof(Commando):
                            {
                                soldier = new Commando(id, firstName, lastName, salary, inputs[5]);

                                for (int i = 6; i < inputs.Length - 1; i += 2)
                                {
                                    try
                                    {
                                        var mission = new Mission(inputs[i], inputs[i + 1]);
                                        (soldier as Commando).Missions.Add(mission);
                                    }
                                    catch (ArgumentException)
                                    {
                                    }
                                }
                                break;
                            }
                        default: throw new Exception("Invalid command.");
                    };

                    soldiers.Add(soldier);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (Soldier soldier in soldiers)
                Console.WriteLine(soldier);

            Console.ReadKey();
        }
    }
}
