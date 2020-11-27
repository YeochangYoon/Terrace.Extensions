using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ByteArrayExtensionTests_ToUInt32
    {
        [Test]
        public void ToUInt32_ReturnsUInt32()
        {
            byte[] bytes = uint.MinValue.ToBytes();
            uint expected = uint.MinValue;
            
            uint actual = bytes.ToUInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUInt32_ReturnsUInt32_WithStartIndex()
        {
            byte[] bytes = uint.MinValue.ToBytes().Concat(uint.MaxValue.ToBytes()).ToArray();
            uint expected = uint.MaxValue;

            uint actual = bytes.ToUInt32(4);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}