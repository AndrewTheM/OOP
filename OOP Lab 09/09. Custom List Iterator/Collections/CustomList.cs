using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListIterator.Collections
{
    public class CustomList<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        private CustomListNode<T> rootNode;

        public int Count { get; private set; }

        public T this[int index]
        {
            get => GetNodeAt(index).Value;
            set => GetNodeAt(index).Value = value;
        }

        private CustomListNode<T> GetNodeAt(int index)
        {
            if (index < 0 || index >= Count)
                throw new IndexOutOfRangeException();

            int count = 0;
            var current = rootNode;

            while (count < index)
            {
                current = current.NextNode;
                ++count;
            }

            return current;
        }

        private CustomListNode<T> Last()
        {
            var current = rootNode;

            if (current != null)
                while (current.NextNode != null)
                    current = current.NextNode;

            return current;
        }

        public void Add(T element)
        {
            var node = new CustomListNode<T>(element);
            var last = Last();

            if (last == null)
                rootNode = node;
            else
                last.NextNode = node;

            ++Count;
        }

        public T Remove(int index)
        {
            CustomListNode<T> node;

            if (index == 0)
            {
                node = rootNode;
                var next = node.NextNode;

                node.NextNode = null;
                rootNode = next;
            }
            else
            {
                var previous = GetNodeAt(index - 1);
                node = previous.NextNode;

                previous.NextNode = node.NextNode;
            }

            --Count;
            return node.Value;
        }

        public bool Contains(T element)
        {
            var current = rootNode;

            while (current != null)
            {
                if (current.Value.CompareTo(element) == 0)
                    return true;
                current = current.NextNode;
            }

            return false;
        }

        public void Swap(int firstIndex, int secondIndex)
        {
            var firstNode = GetNodeAt(firstIndex);
            var secondNode = GetNodeAt(secondIndex);

            var firstValue = firstNode.Value;
            firstNode.Value = secondNode.Value;
            secondNode.Value = firstValue;
        }

        public int CountGreaterThan(T element)
        {
            int count = 0;
            var current = rootNode;

            while (current != null)
            {
                if (current.Value.CompareTo(element) > 0)
                    ++count;
                current = current.NextNode;
            }

            return count;
        }

        private T Extreme(Func<T, T, bool> compareFunc)
        {
            if (Count == 0)
                throw new InvalidOperationException();

            var current = rootNode;
            var extremeValue = rootNode.Value;

            while (current.NextNode != null)
            {
                current = current.NextNode;
                if (compareFunc(current.Value, extremeValue))
                    extremeValue = current.Value;
            }

            return extremeValue;
        }

        public T Max()
            => Extreme((current, max) => current.CompareTo(max) > 0);

        public T Min()
            => Extreme((current, min) => current.CompareTo(min) < 0);

        public IEnumerator<T> GetEnumerator()
            => new CustomIterator<T>(this, rootNode);

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
