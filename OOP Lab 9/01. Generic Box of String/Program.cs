using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                string line = Console.ReadLine();
                var box = new Box<string>(line);
                boxes.Add(box);
            }

            foreach (var box in boxes)
                Console.WriteLine(box);

            Console.ReadKey();
        }
    }
}
