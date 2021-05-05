using System.Collections.Generic;

namespace Sorting
{
    // Worst-case performance: О(n^2) 
    // Best-case performance: O(n)
    // Average performance: O(n^2)
    public static class InsertionSorter
    {
        public static void InsertionSort<T>(this IList<T> collection, IComparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;
            collection.SelectionSortAscending(comparer);
        }
        
        public static void InsertionSortAscending<T>(this IList<T> collection, IComparer<T> comparer)
        {
            for (int i = 1; i < collection.Count; i++)
            {
                var j = i;
                while (j > 0 && comparer.Compare(collection[j], collection[j - 1]) < 0)
                {
                    collection.Swap(j, j - 1);
                    j--;
                }
            }
        }
        
        public static void InsertionSortDescending<T>(this IList<T> collection, IComparer<T> comparer)
        {
            for (int i = 1; i < collection.Count; i++)
            {
                var j = i;
                while (j > 0 && comparer.Compare(collection[j], collection[j - 1]) > 0)
                {
                    collection.Swap(j, j - 1);
                    j--;
                }
            }
        }
    }
}