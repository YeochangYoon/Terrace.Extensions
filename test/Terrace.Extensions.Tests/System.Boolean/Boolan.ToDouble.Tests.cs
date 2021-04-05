using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToDouble
    {
        [Test()]
        public void ToDouble_ReturnsZero_WhenFalse()
        {
            bool @bool = false;
            double expected = 0;

            double actual = @bool.ToDouble();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToDouble_ReturnsOne_WhenTrue()
        {
            bool @bool = true;
            double expected = 1;

            double actual = @bool.ToDouble();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}