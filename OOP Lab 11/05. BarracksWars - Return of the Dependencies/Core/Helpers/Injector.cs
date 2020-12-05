using BarracksWars.Core.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace BarracksWars.Core.Helpers
{
    public enum Lifetime
    {
        Transient,
        Singleton
    }

    public class Injector
    {
        private readonly Dictionary<Type, (Type Type, Lifetime Lifetime)> injectionMap;
        private readonly Dictionary<Type, object> singletons;

        private static Injector instance;

        public static Injector Instance
        {
            get
            {
                instance ??= new Injector();
                return instance;
            }
        }

        private Injector()
        {
            injectionMap = new();
            singletons = new();
        }

        private void AddDependency<T, TInstance>(Lifetime lifetime)
            where T : class
            where TInstance : class, T, new()
        {
            injectionMap.Add(typeof(T), (typeof(TInstance), lifetime));
        }

        public void AddSingleton<T, TInstance>()
            where T : class
            where TInstance : class, T, new()
        {
            AddDependency<T, TInstance>(Lifetime.Singleton);
            singletons[typeof(TInstance)] = new TInstance();
        }

        public void AddTransient<T, TInstance>()
            where T : class
            where TInstance : class, T, new()
        {
            AddDependency<T, TInstance>(Lifetime.Transient);
        }

        public void PerformInjection(object obj)
        {
            var fieldsToInject = obj.GetType()
                                    .GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                    .Where(f => injectionMap.ContainsKey(f.FieldType)
                                                && Attribute.IsDefined(f, typeof(InjectAttribute)))
                                    .ToList();

            foreach (var field in fieldsToInject)
            {
                var injectionInfo = injectionMap[field.FieldType];

                object instanceBeingInjected = injectionInfo.Lifetime switch
                {
                    Lifetime.Transient => Activator.CreateInstance(injectionInfo.Type),
                    Lifetime.Singleton => singletons[injectionInfo.Type],
                    _ => null
                };

                field.SetValue(obj, instanceBeingInjected);
            }
        }
    }
}
