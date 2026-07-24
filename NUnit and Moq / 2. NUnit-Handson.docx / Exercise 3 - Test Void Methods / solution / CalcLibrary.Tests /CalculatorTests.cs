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

        [Test]
        public void TestAddAndClear()
        {
            calculator.Add(20, 30);

            Assert.AreEqual(50, calculator.GetResult);

            calculator.AllClear();

            Assert.AreEqual(0, calculator.GetResult);
        }
    }
}
