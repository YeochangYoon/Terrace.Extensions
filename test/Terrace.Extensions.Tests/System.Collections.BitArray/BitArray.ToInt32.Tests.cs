using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class BitArrayExtensionTests_ToInt32
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToInt32_ReturnsInt32()
        {
            BitArray bitArray = new BitArray(new bool[] { true, false, true, true });
            int expected = 13;

            int actual = bitArray.ToInt32();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToInt32_ThrowsInvalidOperationException_WhenLengthIsGreaterThan32()
        {
            BitArray bitArray = new BitArray(33);

            TestDelegate action = () => bitArray.ToInt32();

            Assert.That(action, Throws.InvalidOperationException);
        }
    }
}