using System;

namespace PersonInheritance.Models
{
    public class Child : Person
    {
        public override int Age
        {
            get => base.Age;
            protected set
            {
                if (value > 15)
                    throw new ArgumentException("Child's age must not be more than 15!");
                base.Age = value;
            }
        }

        public Child(string name, int age) : base(name, age)
        {
        }
    }
}
