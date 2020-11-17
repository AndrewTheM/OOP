using DependencyInversion.Strategies;
using System;

namespace DependencyInversion
{
    public class PrimitiveCalculator
    {
        private ICalculationStrategy strategy;

        public PrimitiveCalculator()
        {
            strategy = new Addition();
        }

        public void ChangeStrategy(char operation)
        {
            strategy = operation switch
            {
                '+' => new Addition(),
                '-' => new Subtraction(),
                '*' => new Multiplication(),
                '/' => new Division(),
                _ => throw new InvalidOperationException()
            };
        }

        public int PerformCalculation(int firstOperand, int secondOperand)
            => strategy.Execute(firstOperand, secondOperand);
    }
}
