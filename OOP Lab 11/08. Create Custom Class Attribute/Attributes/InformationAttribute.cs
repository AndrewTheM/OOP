using System;

namespace InfernoInfinity.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class InformationAttribute : Attribute
    {
        public string Author { get; set; }

        public int Revision { get; set; }

        public string Description { get; set; }

        public string[] Reviewers { get; set; }
    }
}
