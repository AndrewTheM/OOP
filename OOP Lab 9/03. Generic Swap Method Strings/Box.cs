namespace GenericSwapMethodStrings
{
    public class Box<T>
    {
        public T Value { get; set; }

        public Box(T value)
        {
            Value = value;
        }

        public override string ToString()
            => $"{Value.GetType().FullName}: {Value}";
    }
}
