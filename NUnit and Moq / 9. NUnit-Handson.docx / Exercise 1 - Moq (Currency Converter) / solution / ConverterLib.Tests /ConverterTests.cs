using Moq;
using NUnit.Framework;
using ConverterLib;

namespace ConverterLib.Tests
{
    [TestFixture]
    public class ConverterTests
    {
        private Mock<IDollarToEuroExchangeRateFeed> exchangeRateFeedMock;
        private Converter converter;

        [SetUp]
        public void SetUp()
        {
            exchangeRateFeedMock = new Mock<IDollarToEuroExchangeRateFeed>();

            exchangeRateFeedMock
                .Setup(x => x.GetActualUSDValue())
                .Returns(0.85);

            converter = new Converter(exchangeRateFeedMock.Object);
        }

        [Test]
        public void USDToEuro_ValidDollarAmount_ReturnsExpectedEuroValue()
        {
            double usd = 100;

            double result = converter.USDToEuro(usd);

            Assert.That(result, Is.EqualTo(85));
        }

        [Test]
        public void USDToEuro_ZeroDollarAmount_ReturnsZero()
        {
            double result = converter.USDToEuro(0);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void USDToEuro_UsesExchangeRateFeedOnce()
        {
            converter.USDToEuro(200);

            exchangeRateFeedMock.Verify(
                x => x.GetActualUSDValue(),
                Times.Once);
        }
    }
}
