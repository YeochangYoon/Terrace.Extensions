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
    public class ByteArrayExtensionTests_ToInt32
    {
        [Test]
        public void ToInt32_ReturnsInt32()
        {
            byte[] bytes = int.MinValue.ToBytes();
            int expected = int.MinValue;
            
            int actual = bytes.ToInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToInt32_ReturnsInt32_WithStartIndex()
        {
            byte[] bytes = int.MinValue.ToBytes().Concat(int.MaxValue.ToBytes()).ToArray();
            int expected = int.MaxValue;

            int actual = bytes.ToInt32(4);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}