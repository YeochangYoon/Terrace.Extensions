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
    public class ByteArrayExtensionTests_ToUTF8String
    {
        [Test]
        public void ToUTF8String_ReturnsUTF8String()
        {
            byte[] bytes = Encoding.UTF8.GetBytes("This is test");
            string expected = "This is test";
            
            string actual = bytes.ToUTF8String();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUTF8String_ReturnsUTF8String_WithIndex()
        {
            byte[] bytes = Encoding.UTF8.GetBytes("This is test");
            string expected = "is test";

            string actual = bytes.ToUTF8String(5);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUTF8String_ReturnsUTF8String_WithIndexAndCount()
        {
            byte[] bytes = Encoding.UTF8.GetBytes("This is test");
            string expected = "is";

            string actual = bytes.ToUTF8String(5, 2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}