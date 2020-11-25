using Froggy.Collections;
using System;
using System.Linq;
using System.Text;

namespace Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            var numbers = line.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToList();

            var lake = new Lake(numbers);
            var strBuilder = new StringBuilder();

            foreach (var stone in lake)
                strBuilder.Append($"{stone}, ");

            string output = strBuilder.Remove(strBuilder.Length - 2, 2).ToString();
            Console.WriteLine(output);

            Console.ReadKey();
        }
    }
}
