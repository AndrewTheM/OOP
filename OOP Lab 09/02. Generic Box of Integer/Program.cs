using System;
using System.Collections.Generic;

namespace GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                string line = Console.ReadLine();
                var box = new Box<int>(int.Parse(line));
                boxes.Add(box);
            }

            foreach (var box in boxes)
                Console.WriteLine(box);

            Console.ReadKey();
        }
    }
}
