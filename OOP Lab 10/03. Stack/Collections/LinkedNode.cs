namespace StackImplementation.Collections
{
    public class LinkedNode<T>
    {
        public T Value { get; set; }

        public LinkedNode<T> Next { get; set; }

        public LinkedNode(T value)
        {
            Value = value;
        }
    }
}
