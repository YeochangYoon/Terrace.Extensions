using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class BitArrayExtensionTests_GetRange
    {
        private BitArray OriginalBitArray { get; set; } = new BitArray(new bool[] { true, false, true, false, true });

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetRange_ReturnsSubBitArray_WithIndex()
        {
            BitArray expected = new BitArray(new bool[] { false, true, false, true });

            BitArray actual = OriginalBitArray.GetRange(1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetRange_ReturnsSubBitArray_WithIndexAndCount()
        {
            BitArray expected = new BitArray(new bool[] { false, true });

            BitArray actual = OriginalBitArray.GetRange(1, 2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}