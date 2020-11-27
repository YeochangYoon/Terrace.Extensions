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
    public class ByteArrayExtensionTests_ToHexadecimalString
    {
        [Test]
        public void ToHexadecimalString_ReturnsHexadecimalString()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            string expected = "00-01-02-03";
            
            string actual = bytes.ToHexadecimalString();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToHexadecimalString_ReturnsHexadecimalString_WithStartIndex()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            string expected = "01-02-03";

            string actual = bytes.ToHexadecimalString(1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToHexadecimalString_ReturnsHexadecimalString_WithStartIndexAndLength()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            string expected = "01-02";

            string actual = bytes.ToHexadecimalString(1, 2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}