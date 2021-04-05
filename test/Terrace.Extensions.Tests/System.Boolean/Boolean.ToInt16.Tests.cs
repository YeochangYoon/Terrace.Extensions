using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToInt16
    {
        [Test()]
        public void ToInt16_ReturnsZero_WhenFalse()
        {
            bool @bool = false;
            short expected = 0;

            short actual = @bool.ToInt16();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToInt16_ReturnsOne_WhenTrue()
        {
            bool @bool = true;
            short expected = 1;

            short actual = @bool.ToInt16();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}