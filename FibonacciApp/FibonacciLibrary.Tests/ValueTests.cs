using System;
using Xunit;

namespace FibonacciLibrary.Tests {
    public class ValueTests {
        public FibonacciCalculator FibonacciInit() {
            return new FibonacciCalculator();
        }

        [Theory]
        [InlineData(2, 1)]
        [InlineData(7, 13)]
        [InlineData(20, 6765)]
        [InlineData(40, 102334155)]
        //[InlineData(86, 259695496911122585)]
        public void FibonacciSeries_nIsBetween0and89_ReturnsCorrectValue(int n, long expected) {
            
            var sut = new TestInit().FibonacciInit();
            
            var actual = sut.FibonacciSeries(n);
            
            Assert.Equal(expected, actual);
        }


    }
}
