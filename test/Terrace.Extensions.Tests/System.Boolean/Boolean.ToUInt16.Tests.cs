using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToUInt16
    {
        [Test()]
        public void ToUInt16_ReturnZero_WhenFalse()
        {
            bool @bool = false;
            ushort expected = 0;

            ushort actual = @bool.ToUInt16();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToUInt16_ReturnOne_WhenTrue()
        {
            bool @bool = true;
            ushort expected = 1;

            ushort actual = @bool.ToUInt16();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}