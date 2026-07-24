using MagicFilesLib;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;

namespace DirectoryExplorer.Tests
{
    [TestFixture]
    public class DirectoryExplorerTests
    {
        private Mock<IDirectoryExplorer> _directoryExplorerMock;

        private readonly string _file1 = "file.txt";
        private readonly string _file2 = "file2.txt";

        [OneTimeSetUp]
        public void Init()
        {
            _directoryExplorerMock = new Mock<IDirectoryExplorer>();

            _directoryExplorerMock
                .Setup(x => x.GetFiles(It.IsAny<string>()))
                .Returns(new List<string>
                {
                    _file1,
                    _file2
                });
        }

        [TestCase]
        public void GetFiles_ShouldReturnMockedFiles()
        {
            ICollection<string> files =
                _directoryExplorerMock.Object.GetFiles("C:\\Temp");

            Assert.That(files, Is.Not.Null);
            Assert.That(files.Count, Is.EqualTo(2));
            Assert.That(files, Does.Contain(_file1));
        }
    }
}
