using Algorithms;
using Xunit;

namespace Sorting.Tests.Algorithms
{
    public class CalculatorTest
    {
        [Fact]
        public void Calculator_1Plus2_ReturnThree()
        {
            var expected = 3;
            
            var actual = Calculator.Calculate("(1 +2)");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Calculator_1Minus2_ReturnMinusOne()
        {
            var expected = -1;
            
            var actual = Calculator.Calculate("(1- 2)");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Calculator_9Divide3_ReturnThree()
        {
            var expected = 3;
            
            var actual = Calculator.Calculate("( 9/3)");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Calculator_2Multiply3_ReturnSix()
        {
            var expected = 6;
            
            var actual = Calculator.Calculate("( 2 *  3 )");
            
            Assert.Equal(expected, actual);
        }
        
        [Fact]
        public void Calculator_OperationWithSqrt()
        {
            var expected = 99;
            
            var actual = Calculator.Calculate("((25 + (11 - 3)) * sqrt(9))");
            
            Assert.Equal(expected, actual);
        }
    }
}