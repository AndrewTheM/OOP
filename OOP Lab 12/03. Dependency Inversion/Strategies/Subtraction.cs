namespace DependencyInversion.Strategies
{
    public class Subtraction : ICalculationStrategy
    {
        public int Execute(int firstOperand, int secondOperand)
            => firstOperand - secondOperand;
    }
}
