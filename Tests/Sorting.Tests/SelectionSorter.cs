using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Sorting.Tests
{
    public class SelectionSorter
    {
        [Fact]
        public void SelectionSortAscending()
        {
            var actual = new List<int>();
            actual.AddRange(new [] {5, 3, 1, 4, 2});
            var expected = new List<int>();
            expected.AddRange(new [] { 1, 2, 3, 4, 5 });
            
            actual.SelectionSortAscending(Comparer<int>.Default);
            
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SelectionSortDescending()
        {
            var actual = new List<int>();
            actual.AddRange(new [] {2, 3, 1, 4, 5});
            var expected = new List<int>();
            expected.AddRange(new [] { 5, 4, 3, 2, 1 });
            
            actual.SelectionSortDescending(Comparer<int>.Default);
            
            Assert.Equal(expected, actual);
        }
    }
}