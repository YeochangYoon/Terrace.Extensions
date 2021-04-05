using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToChar
    {
        [Test()]
        public void ToChar_ReturnsZeroChar_WhenFalse()
        {
            bool @bool = false;
            char expected = '0';

            char actual = @bool.ToChar();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToChar_ReturnsOneChar_WhenTrue()
        {
            bool @bool = true;
            char expected = '1';

            char actual = @bool.ToChar();
            
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}