using System.Collections.Generic;

namespace Sorting
{
    public static class Utils
    {
        public static void Swap<T>(this IList<T> collection, int a, int b)
        {
            T temp = collection[a];
            collection[a] = collection[b];
            collection[b] = temp;
        }
    }
}