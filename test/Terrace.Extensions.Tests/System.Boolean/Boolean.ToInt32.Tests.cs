using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToInt32
    {
        [Test()]
        public void ToInt32_ReturnsZero_WhenFalse()
        {
            bool @bool = false;
            int expected = 0;

            int actual = @bool.ToInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToInt32_ReturnsOne_WhenTrue()
        {
            bool @bool = true;
            int expected = 1;

            int actual = @bool.ToInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}