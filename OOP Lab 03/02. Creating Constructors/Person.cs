﻿namespace PersonConstructorsApp
{
    public class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person() : this(1)
        {
        }

        public Person(int age) : this("No name", age)
        {
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
