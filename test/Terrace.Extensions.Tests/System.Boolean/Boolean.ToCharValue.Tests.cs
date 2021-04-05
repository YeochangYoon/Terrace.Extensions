using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToCharValue
    {
        [Test()]
        public void ToCharValue_ReturnsZero_WhenFalse()
        {
            bool @bool = false;
            char expected = (char)0;

            char actual = @bool.ToCharValue();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToCharValue_ReturnsOne_WhenTrue()
        {
            bool @bool = true;
            char expected = (char)1;

            char actual = @bool.ToCharValue();
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}