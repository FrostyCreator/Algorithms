using System.Collections.Generic;

namespace Sorting
{
    // Best-case performance - O(n log n)
    // Average performance O(n log n)
    // Worst-case performance - O(n log n)
    public static class MergeSorter
    {
        public static void MergeSort<T>(this IList<T> collection, IComparer<T> comparer = null)
        {
            comparer ??= Comparer<T>.Default;
            collection.MergeSort(comparer, 0, collection.Count - 1);
        }

        private static void MergeSort<T>(this IList<T> collection, IComparer<T> comparer, 
            int lowIndex, int highIndex)
        {
            if (lowIndex < highIndex)
            {
                var middleIndex = (lowIndex + highIndex) / 2;
                collection.MergeSort(comparer, lowIndex, middleIndex);
                collection.MergeSort(comparer, middleIndex + 1, highIndex);
                collection.Merge(comparer, lowIndex, middleIndex, highIndex);
            }
        }

        private static void Merge<T>(this IList<T> collection, IComparer<T> comparer,
            int lowIndex, int middleIndex, int highIndex)
        {
            var left = lowIndex;
            var right = middleIndex + 1;
            var tempArr = new T[highIndex - lowIndex + 1];
            var index = 0;

            while (left <= middleIndex && right <= highIndex)
            {
                if (comparer.Compare(collection[left], collection[right]) < 0)
                {
                    tempArr[index] = collection[left];
                    left++;
                }
                else
                {
                    tempArr[index] = collection[right];
                    right++;
                }
                
                index++;
            }
            for (var i = left; i <= middleIndex; i++)
            {
                tempArr[index] = collection[i];
                index++;
            }

            for (var i = right; i <= highIndex; i++)
            {
                tempArr[index] = collection[i];
                index++;
            }

            for (var i = 0; i < tempArr.Length; i++)
            {
                collection[lowIndex + i] = tempArr[i];
            }
        }
    }
}