using JediGalaxy.Models;
using System;

namespace JediGalaxy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = ParseIntegerPairFromConsole();
            var jediCoords = ParseIntegerPairFromConsole();
            var forceCoords = ParseIntegerPairFromConsole();

            Console.WriteLine();

            Galaxy galaxy = new Galaxy(dimensions.first, dimensions.second);
            galaxy.PlaceJedi(jediCoords.first, jediCoords.second);
            galaxy.PlaceForce(forceCoords.first, forceCoords.second);

            int starsTotal = galaxy.CollectStars();
            Console.WriteLine(starsTotal);

            Console.ReadKey();
        }

        static (int first, int second) ParseIntegerPairFromConsole()
        {
            var inputs = Console.ReadLine().Split(' ');
            return (int.Parse(inputs[0]), int.Parse(inputs[1]));
        }
    }
}
