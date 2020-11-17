using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new PrimitiveCalculator();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                    break;

                if (string.IsNullOrWhiteSpace(line))
                    continue;

                var inputs = line.Split(' ');

                try
                {
                    if (inputs[0] == "mode")
                    {
                        calculator.ChangeStrategy(inputs[1][0]);
                    }
                    else
                    {
                        int firstOperand = int.Parse(inputs[0]),
                            secondOperand = int.Parse(inputs[1]);

                        int result = calculator.PerformCalculation(firstOperand, secondOperand);
                        Console.WriteLine(result);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}
