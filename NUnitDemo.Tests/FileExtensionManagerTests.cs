using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitDemo.Tests
{
    [TestFixture]
    public class FileExtensionManagerTests
    {
        private FileExtensionManager fileExtensionManager;

        [SetUp]
        public void setup()
        {
            fileExtensionManager = new FileExtensionManager();
        }

        [Test]
        public void IsValidFileName_ValidNameLower_ReturnTrue()
        {
            // Arrange

            // Act
            var actual = fileExtensionManager.ValidateFileExtensions("someFile.slf");

            // Assert
            Assert.That(actual);
        }

        [Test]
        public void IsValidFileName_ValidNameUpper_ReturnTrue()
        {
            // Arrange

            // Act
            var actual = fileExtensionManager.ValidateFileExtensions("someFile.SLF");

            // Assert
            Assert.That(actual);
        }
    }
}
