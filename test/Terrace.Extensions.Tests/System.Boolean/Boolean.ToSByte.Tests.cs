using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToSByte
    {
        [Test()]
        public void ToSByte_ReturnZero_WhenFalse()
        {
            bool @bool = false;
            sbyte expected = 0x00;

            sbyte actual = @bool.ToSByte();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToSByte_ReturnOne_WhenTrue()
        {
            bool @bool = true;
            sbyte expected = 0x01;

            sbyte actual = @bool.ToSByte();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}