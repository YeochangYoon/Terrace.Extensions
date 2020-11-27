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
    public class ByteArrayExtensionTests_ToUTF32String
    {
        [Test]
        public void ToUTF32String_ReturnsUTF32String()
        {
            byte[] bytes = Encoding.UTF32.GetBytes("This is test");
            string expected = "This is test";
            
            string actual = bytes.ToUTF32String();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUTF32String_ReturnsUTF32String_WithIndex()
        {
            byte[] bytes = Encoding.UTF32.GetBytes("This is test");
            string expected = "is test";

            string actual = bytes.ToUTF32String(20);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToUTF32String_ReturnsUTF32String_WithIndexAndCount()
        {
            byte[] bytes = Encoding.UTF32.GetBytes("This is test");
            string expected = "is";

            string actual = bytes.ToUTF32String(20, 8);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}