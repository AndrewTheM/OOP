using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericCountMethodDoubles
{
    class Program
    {
        public static int CountGreater<T>(List<T> list, T element) where T : IComparable<T>
        {
            return list.Count(el => el.CompareTo(element) > 0);
        }

        static void Main(string[] args)
        {
            var boxes = new List<Box<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; ++i)
            {
                string line = Console.ReadLine().Replace('.', ',');
                var box = new Box<double>(double.Parse(line));
                boxes.Add(box);
            }

            string value = Console.ReadLine().Replace('.', ',');
            var valueBox = new Box<double>(double.Parse(value));

            int count = CountGreater(boxes, valueBox);
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
