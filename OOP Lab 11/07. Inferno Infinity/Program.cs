using InfernoInfinity.Contracts;
using InfernoInfinity.Models.Enumerations;
using InfernoInfinity.Models.Gems;
using InfernoInfinity.Models.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InfernoInfinity
{
    class Program
    {
        static void Main(string[] args)
        {
            var weapons = new List<IWeapon>();

            while (true)
            {
                try
                {
                    string line = Console.ReadLine();
                    if (line == "END")
                        break;

                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var inputs = line.Split(';');
                    string command = inputs[0];

                    switch (command)
                    {
                        case "Create":
                            {
                                string fullWeaponType = inputs[1],
                                       weaponName = inputs[2];

                                if (weapons.Any(w => w.Name == weaponName))
                                    throw new ArgumentException("A weapon with this name already exists.");

                                var splitWeaponType = fullWeaponType.Split(' ');
                                string weaponRarityName = splitWeaponType[0],
                                       weaponType = splitWeaponType[1];

                                var rarity = Enum.Parse<WeaponRarity>(weaponRarityName);

                                IWeapon weapon = weaponType switch
                                {
                                    nameof(Axe) => new Axe(rarity, weaponName),
                                    nameof(Sword) => new Sword(rarity, weaponName),
                                    nameof(Knife) => new Knife(rarity, weaponName),
                                    _ => throw new ArgumentException("Invalid weapon type.")
                                };

                                weapons.Add(weapon);
                                break;
                            }
                        case "Add":
                            {
                                string weaponName = inputs[1];

                                var weapon = weapons.SingleOrDefault(w => w.Name == weaponName);

                                if (weapon == null)
                                    throw new ArgumentException("Invalid weapon name.");

                                int socketIndex = int.Parse(inputs[2]);
                                string gemFullType = inputs[3];

                                var gemSplitType = gemFullType.Split(' ');
                                string gemClarityName = gemSplitType[0],
                                       gemType = gemSplitType[1];

                                var gemClarity = Enum.Parse<GemClarity>(gemClarityName);

                                IGem gem = gemType switch
                                {
                                    nameof(Ruby) => new Ruby(gemClarity),
                                    nameof(Emerald) => new Emerald(gemClarity),
                                    nameof(Amethyst) => new Amethyst(gemClarity),
                                    _ => throw new ArgumentException("Invalid gem type.")
                                };

                                weapon.InsertGem(gem, socketIndex);
                                break;
                            }
                        case "Remove":
                            {
                                string weaponName = inputs[1];

                                var weapon = weapons.SingleOrDefault(w => w.Name == weaponName);

                                if (weapon == null)
                                    throw new ArgumentException("Invalid weapon name.");

                                int socketIndex = int.Parse(inputs[2]);
                                weapon.RemoveGem(socketIndex);
                                break;
                            }
                        case "Print":
                            {
                                string weaponName = inputs[1];

                                var weapon = weapons.SingleOrDefault(w => w.Name == weaponName);

                                if (weapon == null)
                                    throw new ArgumentException("Invalid weapon name.");

                                Console.WriteLine(weapon);
                                break;
                            }
                        default:
                            throw new InvalidOperationException("Invalid command.");
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
