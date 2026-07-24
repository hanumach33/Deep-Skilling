using System;
using NUnit.Framework;
using CalcLibrary;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new Calculator();
        }

        [TearDown]
        public void TearDown()
        {
            calculator = null;
        }

        // Multiplication Test Cases

        [TestCase(5, 5, 25)]
        [TestCase(10, 2, 20)]
        [TestCase(-5, 4, -20)]
        [TestCase(0, 10, 0)]
        public void Multiply_ShouldReturnExpectedResult(
            int firstNumber,
            int secondNumber,
            int expected)
        {
            int actual = calculator.Multiply(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        // Division Test Cases

        [TestCase(20, 4, 5)]
        [TestCase(100, 10, 10)]
        [TestCase(25, 5, 5)]
        public void Divide_ShouldReturnExpectedResult(
            int firstNumber,
            int secondNumber,
            int expected)
        {
            int actual = calculator.Divide(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Divide_ByZero_ShouldThrowArgumentException()
        {
            try
            {
                calculator.Divide(10, 0);

                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual(
                    "Division by zero is not allowed.",
                    ex.Message);
            }
        }
    }
}
