using KingsGambitExtended.Collections;
using KingsGambitExtended.Models;
using System;
using System.Linq;

namespace KingsGambitExtended
{
    class Program
    {
        static void Main(string[] args)
        {
            string kingName = Console.ReadLine();
            var guardsNames = Console.ReadLine().Split(' ').ToList();
            var footmenNames = Console.ReadLine().Split(' ').ToList();

            var king = new King(kingName);
            var servants = new ServantList();

            guardsNames.ForEach(n => servants.Add(new RoyalGuard(n)));
            footmenNames.ForEach(n => servants.Add(new Footman(n)));
            servants.ForEach(s =>
            {
                king.Attacked += s.React;
                s.Killed += king.ForgetServant;
            });

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    var inputs = line.Split(' ');
                    string command = inputs[0];
                    string target = inputs[1];

                    switch (command)
                    {
                        case "Attack":
                            {
                                if (target != "King")
                                    throw new Exception("You can only attack the king.");

                                king.OnAttack();
                                break;
                            }
                        case "Kill":
                            {
                                var servant = servants.SingleOrDefault(s => s.Name == target);

                                if (servant == null)
                                    throw new Exception($"Failed to find a single servant {target} to kill.");

                                servant.TakeHit();
                                break;
                            }
                        default: throw new Exception("Invalid command.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
