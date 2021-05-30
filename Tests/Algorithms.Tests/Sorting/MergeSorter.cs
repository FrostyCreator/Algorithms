using System.Collections.Generic;
using Xunit;

namespace Sorting.Tests
{
    public class MergeSorter
    {
        [Fact]
        public void MergeSort()
        {
            var actual = new List<int>();
            actual.AddRange(new [] {5, 3, 1, 4, 2});
            var expected = new List<int>();
            expected.AddRange(new [] { 1, 2, 3, 4, 5 });
            
            actual.MergeSort();
            
            Assert.Equal(expected, actual);
        }
        
    }
}