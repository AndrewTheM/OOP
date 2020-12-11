using CollectionHierarchy.Collections.Interfaces;

namespace CollectionHierarchy.Collections
{
    public class AddRemoveCollection : BaseCollection, IAddRemoveCollection
    {
        public int Add(string element)
        {
            int index = 0;
            list.Insert(index, element);
            return index;
        }

        public string Remove()
        {
            int index = list.Count - 1;
            string item = list[index];
            list.RemoveAt(index);
            return item;
        }
    }
}
