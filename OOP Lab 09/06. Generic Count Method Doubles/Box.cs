using System;

namespace GenericCountMethodDoubles
{
    public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public override string ToString()
            => $"{Value.GetType().FullName}: {Value}";

        public int CompareTo(Box<T> other) => Value.CompareTo(other.Value);
    }
}
