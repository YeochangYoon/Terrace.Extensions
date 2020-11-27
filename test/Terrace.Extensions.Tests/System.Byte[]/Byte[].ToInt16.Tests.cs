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
    public class ByteArrayExtensionTests_ToInt16
    {
        [Test]
        public void ToInt16_ReturnsInt16()
        {
            byte[] bytes = short.MinValue.ToBytes();
            short expected = short.MinValue;
            
            short actual = bytes.ToInt16();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToInt16_ReturnsInt16_WithStartIndex()
        {
            byte[] bytes = short.MinValue.ToBytes().Concat(short.MaxValue.ToBytes()).ToArray();
            short expected = short.MaxValue;

            short actual = bytes.ToInt16(2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}