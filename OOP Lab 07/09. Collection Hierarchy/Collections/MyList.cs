using CollectionHierarchy.Collections.Interfaces;

namespace CollectionHierarchy.Collections
{
    public class MyList : BaseCollection, IMyList
    {
        public int Used => list.Count;

        public int Add(string element)
        {
            int index = 0;
            list.Insert(index, element);
            return index;
        }

        public string Remove()
        {
            int index = 0;
            string item = list[index];
            list.RemoveAt(index);
            return item;
        }
    }
}
