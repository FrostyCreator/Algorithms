using System.Collections.Generic;

namespace Searching
{
    public static class BinarySearch
    {
        public static int Find<T>(T[] arr, T key)
        {
            return Find(arr, key, Comparer<T>.Default);
        } 
        
        public static int Find<T>(T[] arr, T key, Comparer<T> comparer)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (comparer.Compare(key, arr[mid]) < 0)
                {
                    high = mid - 1;
                } 
                else if (comparer.Compare(key, arr[mid]) > 0)
                {
                    low = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}