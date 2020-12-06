namespace InfernoInfinity.Contracts.Generic
{
    public interface IRepository<T>
    {
        void Add(T item);

        void Remove(string name);

        T Get(string name);
    }
}
