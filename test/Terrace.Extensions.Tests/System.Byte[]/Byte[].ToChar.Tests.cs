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
    public class ByteArrayExtensionTests_ToChar
    {
        [Test]
        public void ToChar_ReturnsChar()
        {
            byte[] bytes = char.MinValue.ToBytes();
            char expected = char.MinValue;

            char actual = bytes.ToChar();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToChar_ReturnsChar_WithStartIndex()
        {
            byte[] bytes = char.MinValue.ToBytes().Concat(char.MaxValue.ToBytes()).ToArray();
            char expected = char.MaxValue;

            char actual = bytes.ToChar(2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}