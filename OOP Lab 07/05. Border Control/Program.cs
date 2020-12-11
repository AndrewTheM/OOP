using BorderControl.Models;
using System;
using System.Collections.Generic;

namespace BorderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            var newcomers = new List<IIdentifiable>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                var inputs = line.Split(' ');

                try
                {
                    newcomers.Add(inputs.Length switch
                    {
                        2 => new Robot(inputs[0], inputs[1]),
                        3 => new Citizen(inputs[0], int.Parse(inputs[1]), inputs[2]),
                        _ => throw new Exception("Invalid input.")
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string lastDigits = Console.ReadLine();

            foreach (var newcomer in newcomers)
                if (newcomer.Id.EndsWith(lastDigits))
                    Console.WriteLine(newcomer.Id);

            Console.ReadKey();
        }
    }
}
