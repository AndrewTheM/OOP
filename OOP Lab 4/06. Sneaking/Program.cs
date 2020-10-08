using System;
using System.Collections.Generic;

namespace Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowCount = int.Parse(Console.ReadLine());

            var roomRows = new List<string>();

            for (int i = 0; i < rowCount; ++i)
                roomRows.Add(Console.ReadLine());

            string directionsLine = Console.ReadLine();

            foreach (var direction in directionsLine)
            {

            }

            Console.ReadKey();
        }
    }
}
