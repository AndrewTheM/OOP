using InfernoInfinity.Attributes;
using InfernoInfinity.Contracts;
using InfernoInfinity.Helpers;
using InfernoInfinity.Models.Enumerations;
using System;
using System.Collections.Generic;

namespace InfernoInfinity.Models.Weapons
{
    [Information(Author = "Pesho",
                 Revision = 3,
                 Description = "Used for C# OOP Advanced Course - Enumerations and Attributes.",
                 Reviewers = new[] { "Pesho", "Svetlio" })]
    public abstract class Weapon : IWeapon
    {
        private const int MinDamagePerStrength = 2;
        private const int MaxDamagePerStrength = 3;
        private const int MinDamagePerAgility = 1;
        private const int MaxDamagePerAgility = 4;
        private const int MinDamagePerVitality = 0;
        private const int MaxDamagePerVitality = 0;

        private string name;
        private int minDamage;
        private int maxDamage;
        private int totalStrength;
        private int totalAgility;
        private int totalVitality;
        private readonly IGem[] gemSockets;

        public WeaponRarity Rarity { get; }

        public string Name
        {
            get => name;
            set => name = PropertyCheck.StringNotEmpty(value);
        }

        public int MinDamage
        {
            get => minDamage * (int)Rarity
                   + Strength * MinDamagePerStrength
                   + Agility * MinDamagePerAgility
                   + Vitality * MinDamagePerVitality;
            private set => minDamage = PropertyCheck.NumberNotNegative(value);
        }

        public int MaxDamage
        {
            get => maxDamage * (int)Rarity
                   + Strength * MaxDamagePerStrength
                   + Agility * MaxDamagePerAgility
                   + Vitality * MaxDamagePerVitality;
            private set => maxDamage = PropertyCheck.NumberNotNegative(value);
        }

        public int Strength
        {
            get => totalStrength;
            private set => totalStrength = PropertyCheck.NumberNotNegative(value);
        }

        public int Agility
        {
            get => totalAgility;
            private set => totalAgility = PropertyCheck.NumberNotNegative(value);
        }

        public int Vitality
        {
            get => totalVitality;
            private set => totalVitality = PropertyCheck.NumberNotNegative(value);
        }

        public ICollection<IGem> GemSockets => Array.AsReadOnly(gemSockets);

        protected Weapon(WeaponRarity rarity, string name, int minDamage, int maxDamage, int socketCount)
        {
            Rarity = rarity;
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            gemSockets = new IGem[socketCount];
        }

        public void InsertGem(IGem gem, int socketIndex)
        {
            try
            {
                gemSockets[socketIndex] = gem
                    ?? throw new ArgumentNullException(nameof(gem));

                Strength += gem.Strength;
                Agility += gem.Agility;
                Vitality += gem.Vitality;
            }
            catch (IndexOutOfRangeException)
            {
                throw new ArgumentException("Invalid socket index.");
            }
        }

        public void RemoveGem(int socketIndex)
        {
            try
            {
                var gem = gemSockets[socketIndex]
                    ?? throw new ArgumentException("The socket is empty.");

                gemSockets[socketIndex] = null;

                Strength -= gem.Strength;
                Agility -= gem.Agility;
                Vitality -= gem.Vitality;
            }
            catch (IndexOutOfRangeException)
            {
                throw new ArgumentException("Invalid socket index.");
            }
        }

        public override string ToString()
            => $"{Name}: {MinDamage}-{MaxDamage} Damage, +{Strength} Strength, +{Agility} Agility, +{Vitality} Vitality";
    }
}
