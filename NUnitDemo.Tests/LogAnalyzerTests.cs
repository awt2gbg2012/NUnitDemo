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
        public void IsValidFileName_ValidName_ReturnTrue()
        {
            // Arrange
            var analyzer = new LogAnalyzer();

            // Act
            var actual = analyzer.IsValidFileName("testfile.SLF");

            // Assert
            Assert.That(actual);
        }
    }
}
