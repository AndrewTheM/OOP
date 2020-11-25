using StrategyPattern.Models;
using System;
using System.Collections.Generic;

namespace StrategyPattern.Helpers
{
    public class PersonAgeComparer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            if (x == null || y == null)
                throw new ArgumentNullException();

            return x.Age.CompareTo(y.Age);
        }
    }
}
