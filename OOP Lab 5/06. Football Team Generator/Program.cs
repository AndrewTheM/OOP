using FootballTeamGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new List<FootballTeam>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "END")
                    break;

                try
                {
                    if (string.IsNullOrWhiteSpace(line))
                        throw new Exception("Command cannot be empty.");

                    var inputs = line.Split(';');
                    string commandName = inputs[0],
                            teamName = inputs[1];

                    var existingTeam = teams.SingleOrDefault(t => t.Name == teamName);
                    bool doesNotExist = (existingTeam == null);

                    switch (commandName)
                    {
                        case "Team":
                            {
                                if (!doesNotExist)
                                    throw new Exception($"Team {teamName} already exists.");

                                var team = new FootballTeam(teamName);
                                teams.Add(team);
                                doesNotExist = false;
                                break;
                            }
                        case "Add":
                            {
                                if (!doesNotExist)
                                {
                                    string playerName = inputs[2];
                                    int endurance = int.Parse(inputs[3]),
                                        sprint = int.Parse(inputs[4]),
                                        dribble = int.Parse(inputs[5]),
                                        passing = int.Parse(inputs[6]),
                                        shooting = int.Parse(inputs[7]);

                                    var player = new FootballPlayer(playerName, endurance, sprint,
                                                                        dribble, passing, shooting);
                                    existingTeam.AddPlayer(player);
                                }
                                break;
                            }
                        case "Remove":
                            {
                                if (!doesNotExist)
                                {
                                    string playerName = inputs[2];
                                    existingTeam.RemovePlayer(playerName);
                                }
                                break;
                            }
                        case "Rating":
                            {
                                if (!doesNotExist)
                                    Console.WriteLine(existingTeam);
                                break;
                            }
                        default: throw new Exception("Unknown command.");
                    }

                    if (doesNotExist)
                        throw new Exception($"Team {teamName} does not exist.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
