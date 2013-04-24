using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;

namespace NUnitDemo.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        private LogAnalyzer analyzer;
        private Mock mock;

        [SetUp]
        public void Setup()
        {
            mock = new Mock<IFileExtensionManager>();
            mock.Setup(m => m.ValidateFileExtensions(It.IsAny<string>())).Returns(true);

            analyzer = new LogAnalyzer(mock.Object);
        }

        [Test]
        public void IsValidFileExtension_Calls_OnlyOnceWithCorrectFileName()
        {

            mock.Verify(m => m.ValidateFileExtensions(It.IsAny<string>), Times.AtLeastOnce());

        }

        [Test]
        public void CurrentVersion_v10_returnsv10()
        {
            // Arrange
            var expected = "v1.0";

            // Act
            var actual = analyzer.CurrentVersion;

            // Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CheckConfigFile_NonExistingFile_ShouldThrow()
        {
            // Arrange

            // Assert
            Assert.Throws(typeof(ArgumentException), analyzer.CheckConfigFile);
        }

        [Test]
        public void CheckConfigFile_EmptyStringFileName_ShouldThrow()
        {
            // Arrange
            var configFile = "";
            var version = "v1.0";

            // Assert
            Assert.Throws(Is.TypeOf<ArgumentException>(),
                            delegate { 
                                analyzer.CheckConfigFile(configFile, version); });
        }

        [Test]
        public void GenerateLogObject_ValidLog_ShoulBeOfTypeLogObject()
        {
            // Arrange

            // Act
            var actual = analyzer.GenerateLogObject();

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(DemoLogObject)));
        }

        [Test]
        [Category("NonEssential")]
        public void GenerateLogObject_ValidLog_NotNull()
        {
            // Arrange

            // Act
            var actual = analyzer.GenerateLogObject();

            // Assert
            Assert.That(actual, Is.Not.Null);
        }

        [Test]
        [Ignore]
        public void UnfinishedTest()
        {
            throw new Exception("This method should be ignored");
        }
    }
}
