using NUnit.Framework;
using UserManagerLib;

namespace UserManagerLib.Tests
{
    [TestFixture]
    public class UserManagerTests
    {
        private UserManager userManager;

        [SetUp]
        public void SetUp()
        {
            userManager = new UserManager();
        }

        [Test]
        public void CreateUser_NullPanCard_ThrowsNullReferenceException()
        {
            Assert.That(
                () => userManager.CreateUser(null),
                Throws.TypeOf<NullReferenceException>());
        }

        [Test]
        public void CreateUser_EmptyPanCard_ThrowsNullReferenceException()
        {
            Assert.That(
                () => userManager.CreateUser(string.Empty),
                Throws.TypeOf<NullReferenceException>());
        }

        [Test]
        public void CreateUser_InvalidPanLength_ThrowsFormatException()
        {
            Assert.That(
                () => userManager.CreateUser("ABCDE123"),
                Throws.TypeOf<FormatException>());
        }

        [Test]
        public void CreateUser_ValidPan_ReturnsTrue()
        {
            bool result = userManager.CreateUser("ABCDE1234F");

            Assert.That(result, Is.True);
        }
    }
}
