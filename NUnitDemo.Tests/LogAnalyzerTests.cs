using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitDemo.Tests
{
    [TestFixture]
    public class LogAnalyzerTests
    {
        [Test]
        public void IsValidFileName_ValidNameLower_ReturnTrue()
        {
            // Arrange
            var analyzer = new LogAnalyzer();

            // Act
            var actual = analyzer.IsValidFileName("testfile.slf");

            // Assert
            Assert.That(actual);
        }

        [Test]
        public void IsValidFileName_ValidNameUpper_ReturnTrue()
        {
            // Arrange
            var analyzer = new LogAnalyzer();

            // Act
            var actual = analyzer.IsValidFileName("testfile.SLF");

            // Assert
            Assert.That(actual);
        }

        [Test]
        public void CurrentVersion_v10_returnsv10()
        {
            // Arrange
            var analyzer = new LogAnalyzer();
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
            var analyzer = new LogAnalyzer();

            // Assert
            Assert.Throws(typeof(ArgumentException), analyzer.CheckConfigFile);
        }

        [Test]
        public void CheckConfigFile_EmptyStringFileName_ShouldThrow()
        {
            // Arrange
            var analyzer = new LogAnalyzer();
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
            var analyzer = new LogAnalyzer();

            // Act
            var actual = analyzer.GenerateLogObject();

            // Assert
            Assert.That(actual, Is.TypeOf(typeof(DemoLogObject)));
        }

        [Test]
        public void GenerateLogObject_ValidLog_NotNull()
        {
            // Arrange
            var analyzer = new LogAnalyzer();

            // Act
            var actual = analyzer.GenerateLogObject();

            // Assert
            Assert.That(actual, Is.Not.Null);
        }
    }
}
