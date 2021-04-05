using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToUInt32
    {
        [Test()]
        public void ToUInt32_ReturnZero_WhenFalse()
        {
            bool @bool = false;
            uint expected = 0;

            uint actual = @bool.ToUInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToUInt32_ReturnOne_WhenTrue()
        {
            bool @bool = true;
            uint expected = 1;

            uint actual = @bool.ToUInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}