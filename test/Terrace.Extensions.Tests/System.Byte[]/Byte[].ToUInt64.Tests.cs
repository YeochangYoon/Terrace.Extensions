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
    public class ByteArrayExtensionTests_ToUInt64
    {
        [Test]
        public void ToUInt64_ReturnsUInt64()
        {
            byte[] bytes = ulong.MinValue.ToBytes();
            ulong expected = ulong.MinValue;
            
            ulong actual = bytes.ToUInt64();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUInt64_ReturnsUInt64_WithStartIndex()
        {
            byte[] bytes = ulong.MinValue.ToBytes().Concat(ulong.MaxValue.ToBytes()).ToArray();
            ulong expected = ulong.MaxValue;

            ulong actual = bytes.ToUInt64(8);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}