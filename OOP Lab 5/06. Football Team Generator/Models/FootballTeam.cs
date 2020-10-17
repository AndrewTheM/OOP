using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator.Models
{
    public class FootballTeam
    {
        private readonly List<FootballPlayer> players;
        private string name;

        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }

        public int Rating
        {
            get
            {
                if (players.Count == 0)
                    return 0;

                int sumAverage = 0;

                foreach (var player in players)
                {
                    sumAverage += (int)Math.Round((player.Endurance + player.Sprint +
                                    player.Dribble + player.Passing + player.Shooting) / 5.0);
                }

                return sumAverage / players.Count;
            }
        }

        public FootballTeam(string name)
        {
            Name = name;
            players = new List<FootballPlayer>();
        }

        public void AddPlayer(FootballPlayer player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            var player = players.SingleOrDefault(p => p.Name == playerName);

            if (player == null)
                throw new ArgumentException($"Player {playerName} is not in {Name} team.");

            players.Remove(player);
        }

        public override string ToString()
            => $"{Name} - {Rating}";
    }
}
