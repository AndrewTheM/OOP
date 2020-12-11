using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListIterator.Collections
{
    public class CustomIterator<T> : IEnumerator<T>
        where T : IComparable<T>
    {
        protected readonly CustomList<T> list;
        protected readonly CustomListNode<T> rootNode;
        private CustomListNode<T> current;

        public CustomIterator(CustomList<T> list, CustomListNode<T> rootNode)
        {
            this.list = list;
            this.rootNode = rootNode;
            Reset();
        }

        public T Current => current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (current.NextNode == null)
                return false;

            current = current.NextNode;
            return true;
        }

        public void Reset()
            => current = new CustomListNode<T> { NextNode = rootNode };
    }
}
