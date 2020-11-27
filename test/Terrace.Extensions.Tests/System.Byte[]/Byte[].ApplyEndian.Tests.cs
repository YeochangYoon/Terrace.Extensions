using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ByteArrayExtensionTests_ApplyEndian
    {
        [Test]
        public void ApplyEndian_ReturnsReversedByteArray()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            byte[] expected = BitConverter.IsLittleEndian ? new byte[] {0x03, 0x02, 0x01, 0x00 } : bytes;

            byte[] actual = bytes.ApplyEndian();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}