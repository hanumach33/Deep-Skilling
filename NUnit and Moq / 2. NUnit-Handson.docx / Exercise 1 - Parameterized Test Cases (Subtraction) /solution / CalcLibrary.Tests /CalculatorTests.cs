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

        [TestCase(10, 5, 5)]
        [TestCase(20, 10, 10)]
        [TestCase(15, 20, -5)]
        [TestCase(0, 0, 0)]
        [TestCase(-10, -5, -5)]
        public void Subtract_ShouldReturnExpectedResult(
            int firstNumber,
            int secondNumber,
            int expected)
        {
            int actual = calculator.Subtract(firstNumber, secondNumber);

            Assert.AreEqual(expected, actual);
        }
    }
}
