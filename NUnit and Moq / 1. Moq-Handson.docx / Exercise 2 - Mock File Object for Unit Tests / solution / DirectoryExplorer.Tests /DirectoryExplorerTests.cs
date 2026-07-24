using System.Collections.Generic;
using MagicFilesLib;
using Moq;
using NUnit.Framework;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> directoryExplorerMock;

        [SetUp]
        public void SetUp()
        {
            directoryExplorerMock = new Mock<IDirectoryExplorer>();

            directoryExplorerMock
                .Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns(new List<string>
                {
                    "File1.txt",
                    "File2.txt"
                });
        }

        [Test]
        public void GetFiles_ShouldReturnMockedFileCollection()
        {
            ICollection<string> files =
                directoryExplorerMock.Object.GetFiles(@"C:\Temp");

            Assert.That(files, Is.Not.Null);
            Assert.That(files.Count, Is.EqualTo(2));
            Assert.That(files, Does.Contain("File1.txt"));
            Assert.That(files, Does.Contain("File2.txt"));
        }
    }
}
