using System.Collections.Generic;

namespace Sorting
{
    public static class SelectionSorter
    {
        public static void Sort<T>(this IList<T> collection, IComparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;
            collection.SelectionSortAscending(comparer);
        }
        
        public static void SelectionSortAscending<T>(this IList<T> collection, IComparer<T> comparer)
        {
            int min;

            for (int i = 0; i < collection.Count; i++)
            {
                min = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (comparer.Compare(collection[j], collection[min]) < 0)
                    {
                        min = j;
                    }
                }

                collection.Swap(min, i);
            }
        }
        public static void SelectionSortDescending<T>(this IList<T> collection, IComparer<T> comparer)
        {
            int max;

            for (int i = 0; i < collection.Count; i++)
            {
                max = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (comparer.Compare(collection[j], collection[max]) > 0)
                    {
                        max = j;
                    }
                }
                collection.Swap(max, i);
            }
        }
        static void Swap<T>(this IList<T> collection, int a, int b)
        {
            T temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }
    }
}