using Moq;
using NUnit.Framework;
using PlayersManagerLib;

namespace PlayerManager.Tests
{
    [TestFixture]
    public class PlayerTests
    {
        private Mock<IPlayerMapper> _playerMapperMock;

        [OneTimeSetUp]
        public void Init()
        {
            _playerMapperMock = new Mock<IPlayerMapper>();

            _playerMapperMock
                .Setup(x => x.IsPlayerNameExistsInDb(It.IsAny<string>()))
                .Returns(false);
        }

        [TestCase]
        public void RegisterNewPlayer_ShouldCreatePlayer()
        {
            Player player = Player.RegisterNewPlayer(
                "Virat",
                _playerMapperMock.Object);

            Assert.That(player.Name, Is.EqualTo("Virat"));
            Assert.That(player.Age, Is.EqualTo(23));
            Assert.That(player.Country, Is.EqualTo("India"));
            Assert.That(player.NoOfMatches, Is.EqualTo(30));

            _playerMapperMock.Verify(
                x => x.AddNewPlayerIntoDb(It.IsAny<string>()),
                Times.Once);
        }
    }
}
