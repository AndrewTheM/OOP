namespace ThreeupleImplementation
{
    public class CustomThreeuple<T1, T2, T3> : CustomTuple<T1, T2>
    {
        public T3 ThirdItem { get; set; }

        public CustomThreeuple(T1 firstItem, T2 secondItem, T3 thirdItem)
            : base(firstItem, secondItem)
        {
            ThirdItem = thirdItem;
        }

        public override string ToString()
            => $"{base.ToString()} -> {ThirdItem}";
    }
}
