using System;

namespace FootballTeamGenerator.Models
{
    public class FootballPlayer
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;

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

        public int Endurance
        {
            get => endurance;
            set => endurance = ValidateStat(value, nameof(Endurance));
        }

        public int Sprint
        {
            get => sprint;
            set => sprint = ValidateStat(value, nameof(Sprint));
        }

        public int Dribble
        {
            get => dribble;
            set => dribble = ValidateStat(value, nameof(Dribble));
        }

        public int Passing
        {
            get => passing;
            set => passing = ValidateStat(value, nameof(Passing));
        }

        public int Shooting
        {
            get => shooting;
            set => shooting = ValidateStat(value, nameof(Shooting));
        }

        public FootballPlayer(string name)
        {
            Name = name;
        }

        public FootballPlayer(string name, int endurance, int sprint,
                                int dribble, int passing, int shooting) : this(name)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        private int ValidateStat(int value, string statName)
        {
            if (value < 0 || value > 100)
                throw new ArgumentException($"{statName} should be between 0 and 100.");
            return value;
        }
    }
}
