using System;
using Xunit;

namespace FibonacciLibrary.Tests {
    public class InitiationTests {

        [Theory]
        [InlineData(0, 0)]
        [InlineData(1, 1)]
        public void FibonacciSeries_nIs0or1_ReturnsCorrectValue(int n, long expected) { 
            //Arrange
            var sut = new TestInit().FibonacciInit();

            //Act
            var actual = sut.FibonacciSeries(n);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-1500)]
        public void FibonacciSeries_nIsNegative_ThrowsException(int n) {
            //Arrange
            var sut = new TestInit().FibonacciInit();
            string message = "Invalid input";

            //Act & Assert
            var exception = Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });
            Assert.Contains(message, exception.Message);
        }

        [Theory]
        [InlineData(90)]
        [InlineData(13451)]
        public void FibonacciSeries_nIsEqualToOrHigherThan90_ThrowsException(int n) {
            //Arrange
            var sut = new TestInit().FibonacciInit();
            string message = "Result number too big";

            //Act & Assert
            var exception  = Assert.Throws<ArgumentException>(() => {
                var actual = sut.FibonacciSeries(n);
            });

            Assert.Contains(message, exception.Message);
        }

    }
}
