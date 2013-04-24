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
        public void first_test()
        {
            Assert.That(2 + 2, Is.EqualTo(4));
        }
    }
}
