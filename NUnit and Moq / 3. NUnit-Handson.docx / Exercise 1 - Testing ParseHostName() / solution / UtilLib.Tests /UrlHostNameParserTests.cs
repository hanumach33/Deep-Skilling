using NUnit.Framework;
using UtilLib;

namespace UtilLib.Tests
{
    [TestFixture]
    public class UrlHostNameParserTests
    {
        private UrlHostNameParser parser;

        [SetUp]
        public void SetUp()
        {
            parser = new UrlHostNameParser();
        }

        [Test]
        public void ParseHostName_ValidUrl_ReturnsHostName()
        {
            string result = parser.ParseHostName("https://www.google.com/search");

            Assert.That(result, Is.EqualTo("www.google.com"));
        }

        [Test]
        public void ParseHostName_InvalidUrl_ReturnsEmptyString()
        {
            string result = parser.ParseHostName("InvalidURL");

            Assert.That(result, Is.EqualTo(string.Empty));
        }
    }
}
