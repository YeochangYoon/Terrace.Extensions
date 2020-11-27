using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ByteArrayExtensionTests_ToBoolean
    {
        [Test]
        public void ToBoolean_ReturnsBoolean()
        {
            byte[] bytes = new byte[] { 0x00, 0x01 };
            bool expected = false;

            bool actual = bytes.ToBoolean();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToBoolean_ReturnsBoolean_WithStartIndex()
        {
            byte[] bytes = new byte[] { 0x00, 0x01 };
            bool expected = true;

            bool actual = bytes.ToBoolean(1);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}