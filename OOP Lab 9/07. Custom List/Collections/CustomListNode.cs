using System;

namespace CustomListCollection.Collections
{
    public class CustomListNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public CustomListNode<T> NextNode { get; set; }

        public CustomListNode(T value)
        {
            Value = value;
        }
    }
}
