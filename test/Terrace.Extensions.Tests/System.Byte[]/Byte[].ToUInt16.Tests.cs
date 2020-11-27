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
    public class ByteArrayExtensionTests_ToUInt16
    {
        [Test]
        public void ToUInt16_ReturnsUInt16()
        {
            byte[] bytes = ushort.MinValue.ToBytes();
            ushort expected = ushort.MinValue;
            
            ushort actual = bytes.ToUInt16();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUInt16_ReturnsUInt16_WithStartIndex()
        {
            byte[] bytes = ushort.MinValue.ToBytes().Concat(ushort.MaxValue.ToBytes()).ToArray();
            ushort expected = ushort.MaxValue;

            ushort actual = bytes.ToUInt16(2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}