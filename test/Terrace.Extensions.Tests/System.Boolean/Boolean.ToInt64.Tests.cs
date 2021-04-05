using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToInt64
    {
        [Test()]
        public void ToInt64_ReturnsZero_WhenFalse()
        {
            bool @bool = false;
            long expected = 0;

            long actual = @bool.ToInt64();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToInt64_ReturnsOne_WhenTrue()
        {
            bool @bool = true;
            long expected = 1;

            long actual = @bool.ToInt64();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}