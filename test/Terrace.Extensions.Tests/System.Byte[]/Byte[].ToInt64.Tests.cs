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
    public class ByteArrayExtensionTests_ToInt64
    {
        [Test]
        public void ToInt64_ReturnsInt64()
        {
            byte[] bytes = long.MinValue.ToBytes();
            long expected = long.MinValue;
            
            long actual = bytes.ToInt64();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToInt64_ReturnsInt64_WithStartIndex()
        {
            byte[] bytes = long.MinValue.ToBytes().Concat(long.MaxValue.ToBytes()).ToArray();
            long expected = long.MaxValue;

            long actual = bytes.ToInt64(8);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}