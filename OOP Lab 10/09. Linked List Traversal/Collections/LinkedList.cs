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

        public T this[int index]
        {
            get => GetNodeAt(index).Value;
            set => GetNodeAt(index).Value = value;
        }

        private LinkedListNode<T> GetNodeAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            int count = 0;
            bool reversed = false;
            LinkedListNode<T> node;

            if (index < this.Count / 2)
            {
                node = head;
            }
            else
            {
                node = tail;
                count = this.Count - 1;
                reversed = true;
            }

            while (node != null)
            {
                if (count == index)
                    return node;

                if (reversed)
                {
                    --count;
                    node = node.Previous;
                }
                else
                {
                    ++count;
                    node = node.Next;
                }
            }

            throw new KeyNotFoundException();
        }

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
