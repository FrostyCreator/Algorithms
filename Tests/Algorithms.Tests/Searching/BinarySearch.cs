using Xunit;

namespace Searching.Tests
{
    public class BinarySearch
    {
        public BinarySearch()
        {
            arr = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 22};
        }
        
        private int[] arr;

        [Fact]
        public void BinarySearch_ElemThatIsInArr()
        {
            var elem = 2;

            var index = Searching.BinarySearch.Find(arr, elem);

            Assert.Equal(1, index);
        }
        
        [Fact]
        public void BinarySearch_ElemThatIsInArr2()
        {
            var elem = 22;

            var index = Searching.BinarySearch.Find(arr, elem);

            Assert.Equal(9, index);
        }

        [Fact]
        public void BinarySearch_ElemThatIsNotInArr()
        {
            var elem = -10;

            var index = Searching.BinarySearch.Find(arr, elem);

            Assert.Equal(-1, index);
        }
    }
}