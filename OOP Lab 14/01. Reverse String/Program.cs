using System;
using System.Linq;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string reversed = new string(line.Reverse().ToArray());
            Console.WriteLine(reversed);

            Console.ReadKey();
        }
    }
}
