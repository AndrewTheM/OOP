using System;

namespace ThreeupleImplementation
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
            string town = firstInputs[3];
            var firstThreeuple = new CustomThreeuple<string, string, string>(fullName, address, town);

            string name = secondInputs[0];
            int liters = int.Parse(secondInputs[1]);
            bool drunk = (secondInputs[2] == "drunk");
            var secondThreeuple = new CustomThreeuple<string, int, bool>(name, liters, drunk);

            string personName = thirdInputs[0];
            double balance = double.Parse(thirdInputs[1].Replace('.', ','));
            string bankName = thirdInputs[2];
            var thirdThreeuple = new CustomThreeuple<string, double, string>(personName, balance, bankName);

            Console.WriteLine(firstThreeuple);
            Console.WriteLine(secondThreeuple);
            Console.WriteLine(thirdThreeuple);

            Console.ReadKey();
        }

        static string[] ParseInputsFromConsole()
            => Console.ReadLine().Split(' ');
    }
}
