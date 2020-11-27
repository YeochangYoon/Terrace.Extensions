using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class BitArrayExtensionTests_ToByte
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToByte_ReturnsByte()
        {
            BitArray bitArray = new BitArray(new bool[] { true, false, true, true });
            byte expected = 13;

            byte actual = bitArray.ToByte();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToByte_ThrowsInvalidOperationException_WhenLengthIsGreaterThan8()
        {
            BitArray bitArray = new BitArray(9);

            TestDelegate action = () => bitArray.ToByte();

            Assert.That(action, Throws.InvalidOperationException);
        }
    }
}