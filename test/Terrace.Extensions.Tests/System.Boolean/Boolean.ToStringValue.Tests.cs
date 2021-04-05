using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToStringValue
    {
        [Test()]
        public void ToStringValue_ReturnZeroString_WhenFalse()
        {
            bool @bool = false;
            string expected = "0";

            string actual = @bool.ToStringValue();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToStringValue_ReturnOneString_WhenTrue()
        {
            bool @bool = true;
            string expected = "1";

            string actual = @bool.ToStringValue();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}