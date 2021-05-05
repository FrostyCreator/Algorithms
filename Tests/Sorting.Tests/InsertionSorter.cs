using System.Collections.Generic;
using Xunit;

namespace Sorting.Tests
{
    public class InsertionSorter
    {
        [Fact]
        public void InsertionSort()
        {
            var actual = new List<int>();
            actual.AddRange(new [] {5, 3, 1, 4, 2});
            var expected = new List<int>();
            expected.AddRange(new [] { 1, 2, 3, 4, 5 });
            
            actual.InsertionSort();
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void InsertionSortAscending()
        {
            var actual = new List<int>();
            actual.AddRange(new [] {5, 3, 1, 4, 2});
            var expected = new List<int>();
            expected.AddRange(new [] { 1, 2, 3, 4, 5 });
            
            actual.InsertionSortAscending(Comparer<int>.Default);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertionSortDescending()
        {
            var actual = new List<int>();
            actual.AddRange(new [] {2, 3, 1, 4, 5});
            var expected = new List<int>();
            expected.AddRange(new [] { 5, 4, 3, 2, 1 });
            
            actual.InsertionSortDescending(Comparer<int>.Default);
            
            Assert.Equal(expected, actual);
        }
    }
}