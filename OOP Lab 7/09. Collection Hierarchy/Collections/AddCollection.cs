using CollectionHierarchy.Collections.Interfaces;

namespace CollectionHierarchy.Collections
{
    public class AddCollection : BaseCollection, IAddCollection
    {
        public int Add(string element)
        {
            list.Add(element);
            return list.Count - 1;
        }
    }
}
