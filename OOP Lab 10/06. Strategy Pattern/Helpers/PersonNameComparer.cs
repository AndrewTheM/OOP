using StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace StrategyPattern.Helpers
{
    public class PersonNameComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            if (x.Name.Length == y.Name.Length)
                return x.Name.ToLower()[0].CompareTo(y.Name.ToLower()[0]);
            else
                return x.Name.Length.CompareTo(y.Name.Length);
        }
    }
}
