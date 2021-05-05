using System.Collections.Generic;

namespace Sorting
{
    // Worst-case performance: О(n^2) 
    // Best-case performance: O(n^2)
    // Average performance: O(n^2)
    public static class SelectionSorter
    {
        public static void SelectionSort<T>(this IList<T> collection, IComparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;
            collection.SelectionSortAscending(comparer);
        }
        
        public static void SelectionSortAscending<T>(this IList<T> collection, IComparer<T> comparer)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                var min = i;
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
            for (int i = 0; i < collection.Count; i++)
            {
                var max = i;
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
    }
}