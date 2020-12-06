using InfernoInfinity.Contracts.Generic;
using System;
using System.Linq;
using System.Reflection;

namespace InfernoInfinity.Factories
{
    public abstract class ReflectiveFactory<T> : IReflectiveFactory<T>
    {
        protected readonly string targetNamespace;

        protected ReflectiveFactory(string targetNamespace)
        {
            this.targetNamespace = targetNamespace;
        }

        public virtual T Create(string type, params object[] parameters)
        {
            try
            {
                var targetType = Assembly.GetExecutingAssembly()
                                 .GetTypes()
                                 .Where(t => t.Namespace == targetNamespace
                                             && t.Name.ToLower() == type.ToLower())
                                 .Single();

                var instance = Activator.CreateInstance(targetType, parameters);
                return (T)instance;
            }
            catch
            {
                throw new ArgumentException("The provided type does not exist.");
            }
        }
    }
}
