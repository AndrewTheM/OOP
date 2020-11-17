namespace DependencyInversion.Strategies
{
    public class Multiplication : ICalculationStrategy
    {
        public int Execute(int firstOperand, int secondOperand)
            => firstOperand * secondOperand;
    }
}
