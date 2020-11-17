namespace DependencyInversion.Strategies
{
    public class Addition : ICalculationStrategy
    {
        public int Execute(int firstOperand, int secondOperand)
            => firstOperand + secondOperand;
    }
}
