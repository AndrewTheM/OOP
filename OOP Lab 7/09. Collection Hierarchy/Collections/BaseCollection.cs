using System.Collections.Generic;

namespace CollectionHierarchy.Collections
{
    public abstract class BaseCollection
    {
        protected readonly List<string> list;

        protected BaseCollection()
        {
            list = new List<string>();
        }
    }
}
