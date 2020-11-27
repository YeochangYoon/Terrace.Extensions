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
    public class ByteArrayExtensionTests_ToASCIIString
    {
        [Test]
        public void ToASCIIString_ReturnsASCIIString()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("This is test");
            string expected = "This is test";
            
            string actual = bytes.ToASCIIString();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToASCIIString_ReturnsASCIIString_WithIndex()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("This is test");
            string expected = "is test";

            string actual = bytes.ToASCIIString(5);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToASCIIString_ReturnsASCIIString_WithIndexAndCount()
        {
            byte[] bytes = Encoding.ASCII.GetBytes("This is test");
            string expected = "is";

            string actual = bytes.ToASCIIString(5, 2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}