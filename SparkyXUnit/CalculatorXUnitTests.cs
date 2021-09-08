using Sparky;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace SparkyNUnitTest
{
    public class CalculatorXUnitTests
    {
        [Fact]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            Calculator calc = new();

            // Act
            int result = calc.AddNumber(10, 20);

            // Assert
            Assert.Equal(30, result);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(100)]
        public void IsOddNumber_InputEvenNumber_ReturnFlase(int n)
        {
            // Arrange
            Calculator calc = new();

            // Act
            bool isOdd = calc.IsOddNumber(n);

            // Assert
            Assert.False(isOdd);
            // Assert.IsFalse(isOdd);
        }

        [Theory]
        [InlineData(11)]
        [InlineData(111)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int n)
        {
            // Arrange
            Calculator calc = new();

            // Act
            bool isOdd = calc.IsOddNumber(n);

            // Assert
            Assert.True(isOdd);
            // Assert.IsTrue(isOdd);
        }

        [Theory]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public void IsOddChecker_InputNumber_ReturnTrueIfOdd(int a, bool expectedResult)
        {
            Calculator calc = new();
            var result = calc.IsOddNumber(a);
            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData(5.4, 10.5)] //15.9
        [InlineData(5.43, 10.53)] // 15.93
        [InlineData(5.49, 10.59)] // 16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            // Arrange
            Calculator calc = new();

            // Act
            double result = calc.AddNumbersDouble(a, b);

            // Assert
            Assert.Equal(15.9, result, 2);
            //15.7-16.1
        }

        [Fact]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            // Arrange
            Calculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

            // Act
            List<int> result = calc.GetOddRange(5, 10);

            // Assert
            Assert.Equal(expectedOddRange, result);
            Assert.Contains(7, result);
            Assert.NotEmpty(result);
            Assert.Equal(3, result.Count);
            Assert.DoesNotContain(6, result);
            Assert.Equal(result.OrderBy(u => u), result);
        }
    }
}
