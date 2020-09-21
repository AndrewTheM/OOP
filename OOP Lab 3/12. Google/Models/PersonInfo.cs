using System.Collections.Generic;

namespace Google.Models
{
    public class PersonInfo
    {
        public string Name { get; set; }

        public Company Company { get; set; }

        public List<Pokemon> Pokemon { get; set; }

        public List<Person> Parents { get; set; }

        public List<Person> Children { get; set; }

        public Car Car { get; set; }

        public PersonInfo(string name)
        {
            Name = name;
            Pokemon = new List<Pokemon>();
            Parents = new List<Person>();
            Children = new List<Person>();
        }
    }
}
