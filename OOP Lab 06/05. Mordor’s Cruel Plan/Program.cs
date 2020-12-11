using MordorsCruelPlan.Factories;
using MordorsCruelPlan.Models.Food;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MordorsCruelPlan
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodFactory = new FoodFactory();
            var moodFactory = new MoodFactory();
            var foodList = new List<Food>();

            var foodNames = Console.ReadLine().Split(' ');

            foreach (var foodName in foodNames)
            {
                string normalizedName = NormalizeName(foodName);
                var food = foodFactory.ProduceFood(normalizedName);
                foodList.Add(food);
            }

            int totalHappiness = foodList.Sum(f => f.HappinessPoints);
            var mood = moodFactory.ProduceMood(totalHappiness);

            Console.WriteLine(totalHappiness);
            Console.WriteLine(mood.Name);

            Console.ReadKey();
        }

        static string NormalizeName(string name)
        {
            if (AreEqualLower(name, nameof(Cram)))
                return nameof(Cram);
            if (AreEqualLower(name, nameof(Lembas)))
                return nameof(Lembas);
            if (AreEqualLower(name, nameof(Apple)))
                return nameof(Apple);
            if (AreEqualLower(name, nameof(Melon)))
                return nameof(Melon);
            if (AreEqualLower(name, nameof(HoneyCake)))
                return nameof(HoneyCake);
            if (AreEqualLower(name, nameof(Mushrooms)))
                return nameof(Mushrooms);
            return nameof(UnknownFood);
        }

        static bool AreEqualLower(string firstStr, string secondStr)
            => firstStr.ToLower() == secondStr.ToLower();
    }
}
