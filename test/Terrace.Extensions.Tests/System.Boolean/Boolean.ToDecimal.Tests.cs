using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToDecimal
    {
        [Test()]
        public void ToDecimal_ReturnsZero_WhenFalse()
        {
            bool @bool = false;
            decimal expected = 0;

            decimal actual = @bool.ToDecimal();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToDecimal_ReturnsOne_WhenTrue()
        {
            bool @bool = true;
            decimal expected = 1;

            decimal actual = @bool.ToDecimal();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}