namespace DependencyInversion.Strategies
{
    public interface ICalculationStrategy
    {
        int Execute(int firstOperand, int secondOperand);
    }
}
