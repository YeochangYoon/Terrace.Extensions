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
    public class ByteArrayExtensionTests_ToUnicodeString
    {
        [Test]
        public void ToUnicodeString_ReturnsUnicodeString()
        {
            byte[] bytes = Encoding.Unicode.GetBytes("This is test");
            string expected = "This is test";
            
            string actual = bytes.ToUnicodeString();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUnicodeString_ReturnsUnicodeString_WithIndex()
        {
            byte[] bytes = Encoding.Unicode.GetBytes("This is test");
            string expected = "is test";

            string actual = bytes.ToUnicodeString(10);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUnicodeString_ReturnsUnicodeString_WithIndexAndCount()
        {
            byte[] bytes = Encoding.Unicode.GetBytes("This is test");
            string expected = "is";

            string actual = bytes.ToUnicodeString(10, 4);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}