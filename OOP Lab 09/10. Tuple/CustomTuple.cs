namespace TupleImplementation
{
    public class CustomTuple<T1, T2>
    {
        public T1 FirstItem { get; set; }

        public T2 SecondItem { get; set; }

        public CustomTuple(T1 firstItem, T2 secondItem)
        {
            FirstItem = firstItem;
            SecondItem = secondItem;
        }

        public override string ToString()
            => $"{FirstItem} -> {SecondItem}";
    }
}
