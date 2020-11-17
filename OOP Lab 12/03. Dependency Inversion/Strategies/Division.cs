namespace DependencyInversion.Strategies
{
    public class Division : ICalculationStrategy
    {
        public int Execute(int firstOperand, int secondOperand)
            => firstOperand / secondOperand;
    }
}
