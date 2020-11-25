using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListTraversal.Collections
{
    public class LinkedList<T> : IEnumerable<T>
        where T: IComparable<T>
    {
        private LinkedListNode<T> head;
        private LinkedListNode<T> tail;

        public int Count { get; protected set; }

        public void Add(T item)
        {
            var node = new LinkedListNode<T>(item);

            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }

            ++Count;
        }

        public bool Remove(T item)
        {
            var node = head;

            while (node != null)
            {
                if (node.Value.CompareTo(item) == 0)
                {
                    if (node.Next == null)
                        tail = node.Previous;
                    else
                        node.Next.Previous = node.Previous;

                    if (node.Previous == null)
                        head = node.Next;
                    else
                        node.Previous.Next = node.Next;

                    node.Next = null;
                    node.Previous = null;

                    --Count;
                    return true;
                }

                node = node.Next;
            }

            return false;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var node = head;
            while (node != null)
            {
                yield return node.Value;
                node = node.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
            => GetEnumerator();
    }
}
