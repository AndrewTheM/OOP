namespace InfernoInfinity.Contracts.Generic
{
    public interface IReflectiveFactory<T>
    {
        T Create(string type, params object[] parameters);
    }
}
