using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodStrings
{
    class Program
    {
        public static int CountGreater<T>(List<T> list, T element) where T : IComparable<T>
        {
            return list.Count(el => el.CompareTo(element) > 0);
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

            var valueBox = new Box<string>(Console.ReadLine());

            int count = CountGreater(boxes, valueBox);
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
