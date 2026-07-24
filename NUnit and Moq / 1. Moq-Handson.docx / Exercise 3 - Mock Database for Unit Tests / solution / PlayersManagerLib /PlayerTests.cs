using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> playerMapperMock;

        [SetUp]
        public void SetUp()
        {
            playerMapperMock = new Mock<IPlayerMapper>();

            playerMapperMock
                .Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>()))
                .Returns(false);
        }

        [Test]
        public void RegisterNewPlayer_ShouldCreatePlayer()
        {
            Player player = Player.RegisterNewPlayer(
                "Virat",
                playerMapperMock.Object);

            Assert.That(player.Name, Is.EqualTo("Virat"));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));

            playerMapperMock.Verify(
                x => x.AddNewPlayerIntoDb(It.IsAny<string>()),
                Times.Once);
        }
    }
}
