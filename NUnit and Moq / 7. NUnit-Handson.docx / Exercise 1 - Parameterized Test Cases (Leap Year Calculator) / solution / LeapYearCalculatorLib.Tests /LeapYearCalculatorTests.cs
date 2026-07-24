using NUnit.Framework;
using LeapYearCalculatorLib;

namespace LeapYearCalculatorLib.Tests
{
    [TestFixture]
    public class LeapYearCalculatorTests
    {
        private LeapYearCalculator calculator;

        [SetUp]
        public void SetUp()
        {
            calculator = new LeapYearCalculator();
        }

        [TestCase(2000, 1)]
        [TestCase(2024, 1)]
        [TestCase(2023, 0)]
        [TestCase(1900, 0)]
        [TestCase(1752, -1)]
        [TestCase(10000, -1)]
        public void CheckLeapYear_ValidInput_ReturnsExpectedResult(
            int year,
            int expected)
        {
            int actual = calculator.CheckLeapYear(year);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
