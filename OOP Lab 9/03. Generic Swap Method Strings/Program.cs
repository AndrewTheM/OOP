using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericSwapMethodStrings
{
    class Program
    {
        public static void Swap<T>(List<T> list, int firstIndex, int secondIndex)
        {
            T firstValue = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = firstValue;
        }

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

            var indexes = Console.ReadLine().Split(' ')
                            .Select(int.Parse).ToList();

            Swap(boxes, indexes[0], indexes[1]);

            foreach (var box in boxes)
                Console.WriteLine(box);

            Console.ReadKey();
        }
    }
}
