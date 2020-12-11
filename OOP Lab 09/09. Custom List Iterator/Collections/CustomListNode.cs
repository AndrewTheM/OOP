using System;

namespace CustomListIterator.Collections
{
    public class CustomListNode<T> where T : IComparable<T>
    {
        public T Value { get; set; }

        public CustomListNode<T> NextNode { get; set; }

        public CustomListNode()
        {
        }

        public CustomListNode(T value)
        {
            Value = value;
        }
    }
}
