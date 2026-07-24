using System.Collections;
using NUnit.Framework;
using FourSeasonsLib;

namespace FourSeasonsLib.Tests
{
    [TestFixture]
    public class FourSeasonsTests
    {
        private FourSeasons season;

        [SetUp]
        public void SetUp()
        {
            season = new FourSeasons();
        }

        public static IEnumerable SeasonTestData
        {
            get
            {
                yield return new TestCaseData("February", "Spring");
                yield return new TestCaseData("March", "Spring");
                yield return new TestCaseData("April", "Summer");
                yield return new TestCaseData("May", "Summer");
                yield return new TestCaseData("June", "Summer");
                yield return new TestCaseData("July", "Monsoon");
                yield return new TestCaseData("August", "Monsoon");
                yield return new TestCaseData("September", "Autumn");
                yield return new TestCaseData("October", "Autumn");
                yield return new TestCaseData("November", "Autumn");
                yield return new TestCaseData("December", "Winter");
                yield return new TestCaseData("January", "Winter");
            }
        }

        [Test]
        [TestCaseSource(nameof(SeasonTestData))]
        public void GetSeason_ValidMonth_ReturnsExpectedSeason(
            string month,
            string expectedSeason)
        {
            string actualSeason = season.GetSeason(month);

            Assert.That(actualSeason, Is.EqualTo(expectedSeason));
        }
    }
}
