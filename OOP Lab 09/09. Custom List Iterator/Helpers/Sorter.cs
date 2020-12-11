using CustomListIterator.Collections;
using System;

namespace CustomListIterator.Helpers
{
    public static class Sorter
    {
        public static void Sort<T>(CustomList<T> list) where T : IComparable<T>
            => Sort(list, 0, list.Count - 1);

        // Алгоритм сортування QuickSort
        private static void Sort<T>(CustomList<T> list, int firstIndex, int lastIndex)
            where T : IComparable<T>
        {
            if (firstIndex >= lastIndex)
                return;

            int left = firstIndex, right = lastIndex;

            while (left <= right)
            {
                var lastValue = list[lastIndex];

                while (list[left].CompareTo(lastValue) < 0)
                    ++left;

                while (list[right].CompareTo(lastValue) > 0)
                    --right;

                if (left <= right)
                    list.Swap(left++, right--);
            }

            Sort(list, firstIndex, right);
            Sort(list, right + 1, lastIndex);
        }
    }
}
