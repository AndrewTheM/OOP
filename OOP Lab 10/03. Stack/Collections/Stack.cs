using System;
using System.Collections;
using System.Collections.Generic;

namespace StackImplementation.Collections
{
    public class Stack<T> : IEnumerable<T>
    {
        private LinkedNode<T> head;

        public void Push(T item)
        {
            var node = new LinkedNode<T>(item) { Next = head };
            head = node;
        }

        public T Pop()
        {
            if (head == null)
                throw new InvalidOperationException("No elements.");

            var node = head;
            head = head.Next;
            node.Next = null;
            return node.Value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var item = head;
            while (item != null)
            {
                yield return item.Value;
                item = item.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
