﻿using NUnit.Framework;
using Sparky;
using System;
using System.Collections.Generic;

namespace SparkyNUnitTest
{
    [TestFixture]
    public class CalculatorNUnitTests
    {
        [Test]
        public void AddNumbers_InputTwoInt_GetCorrectAddition()
        {
            // Arrange
            Calculator calc = new();

            // Act
            int result = calc.AddNumber(10, 20);

            // Assert
            Assert.AreEqual(30, result);
        }

        [Test]
        [TestCase(10)]
        [TestCase(100)]
        public void IsOddNumber_InputEvenNumber_ReturnFlase(int n)
        {
            // Arrange
            Calculator calc = new();

            // Act
            bool isOdd = calc.IsOddNumber(n);

            // Assert
            Assert.That(isOdd, Is.EqualTo(false));
            // Assert.IsFalse(isOdd);
        }

        [Test]
        [TestCase(11)]
        [TestCase(111)]
        public void IsOddNumber_InputOddNumber_ReturnTrue(int n)
        {
            // Arrange
            Calculator calc = new();

            // Act
            bool isOdd = calc.IsOddNumber(n);

            // Assert
            Assert.That(isOdd, Is.EqualTo(true));
            // Assert.IsTrue(isOdd);
        }

        [Test]
        [TestCase(10, ExpectedResult = false)]
        [TestCase(11, ExpectedResult = true)]
        public bool IsOddChecker_InputNumber_ReturnTrueIfOdd(int a)
        {
            Calculator calc = new();
            return calc.IsOddNumber(a);
        }

        [Test]
        [TestCase(5.4, 10.5)] //15.9
        [TestCase(5.43, 10.53)] // 15.93
        [TestCase(5.49, 10.59)] // 16.08
        public void AddNumbersDouble_InputTwoDouble_GetCorrectAddition(double a, double b)
        {
            // Arrange
            Calculator calc = new();

            // Act
            double result = calc.AddNumbersDouble(a, b);

            // Assert
            Assert.AreEqual(15.9, result, .2);
            //15.7-16.1
        }

        [Test]
        public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
        {
            // Arrange
            Calculator calc = new();
            List<int> expectedOddRange = new() { 5, 7, 9 }; //5-10

            // Act
            List<int> result = calc.GetOddRange(5, 10);

            // Assert
            Assert.That(result, Is.EquivalentTo(expectedOddRange));
            //Assert.AreEqual( expectedOddRange, result);
            //Assert.Contains(7, result);
            Assert.That(result, Does.Contain(7));
            Assert.That(result, Is.Not.Empty);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result, Has.No.Member(6));
            Assert.That(result, Is.Ordered);
            Assert.That(result, Is.Unique);
        }
    }
}
