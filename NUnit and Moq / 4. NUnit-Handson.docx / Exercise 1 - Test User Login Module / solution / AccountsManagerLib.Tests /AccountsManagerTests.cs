using System;
using NUnit.Framework;
using AccountsManagerLib;

namespace AccountsManagerLib.Tests
{
    [TestFixture]
    public class AccountsManagerTests
    {
        private AccountsManager accountsManager;

        [SetUp]
        public void SetUp()
        {
            accountsManager = new AccountsManager();
        }

        [Test]
        public void Login_ValidCredentials_ReturnsWelcomeMessage()
        {
            string result = accountsManager.Login(
                "user_1",
                "secret@user11");

            Assert.That(result, Is.EqualTo("Welcome user_1!!!"));
        }

        [Test]
        public void Login_InvalidCredentials_ReturnsErrorMessage()
        {
            string result = accountsManager.Login(
                "user_1",
                "wrongpassword");

            Assert.That(result, Is.EqualTo("Invalid user id/password"));
        }

        [Test]
        public void Login_EmptyUserId_ThrowsArgumentException()
        {
            Assert.That(
                () => accountsManager.Login("", "secret@user11"),
                Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Login_EmptyPassword_ThrowsArgumentException()
        {
            Assert.That(
                () => accountsManager.Login("user_1", ""),
                Throws.TypeOf<ArgumentException>());
        }
    }
}
