using System;

namespace EventImplementation.Models.Communication
{
    public class NameChangedEventArgs : EventArgs
    {
        public string Name { get; private set; }

        public NameChangedEventArgs(string name)
            => Name = name;
    }
}
