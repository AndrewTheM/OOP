using System;

namespace TupleImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInputs = ParseInputsFromConsole();
            var secondInputs = ParseInputsFromConsole();
            var thirdInputs = ParseInputsFromConsole();

            string fullName = $"{firstInputs[0]} {firstInputs[1]}";
            string address = firstInputs[2];
            var firstTuple = new CustomTuple<string, string>(fullName, address);

            string name = secondInputs[0];
            int liters = int.Parse(secondInputs[1]);
            var secondTuple = new CustomTuple<string, int>(name, liters);

            int integerNumber = int.Parse(thirdInputs[0]);
            double doubleNumber = double.Parse(thirdInputs[1].Replace('.', ','));
            var thirdTuple = new CustomTuple<int, double>(integerNumber, doubleNumber);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);

            Console.ReadKey();
        }

        static string[] ParseInputsFromConsole()
            => Console.ReadLine().Split(' ');
    }
}
