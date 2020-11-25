using System;
using System.Collections.Generic;

namespace IteratorImplementation.Collections
{
    public class ListyIterator<T>
    {
        private readonly IList<T> list;
        private int currentIndex;

        public ListyIterator(IList<T> list)
        {
            this.list = list;
        }

        public bool Move()
        {
            if (!HasNext())
                return false;

            ++currentIndex;
            return true;
        }

        public bool HasNext()
            => currentIndex < list.Count - 1;

        public void Print()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("Invalid Operation!");
            Console.WriteLine(list[currentIndex]);
        }

        public void Reset()
        {
            currentIndex = 0;
        }
    }
}
