using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class BitArrayExtensionTests_ToInt32s
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToInt32s_ReturnsInt32Array()
        {
            int[] bytes = { 0, 1, 2, 3 };
            BitArray bitArray = new BitArray(bytes);
            int[] expected = bytes;

            int[] actual = bitArray.ToInt32s();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToInt32s_ReturnsProperLengthOfInt32Array_WhenRemainderOfLengthOfBitArrayDividedBy32IsZero()
        {
            BitArray bitArray = new BitArray(64);
            int expectedLength = 2;

            int[] actual = bitArray.ToInt32s();

            Assert.That(actual.Length, Is.EqualTo(expectedLength));

        }
        [Test]
        public void ToInt32s_ReturnsProperLengthOfInt32Array_WhenRemainderOfLengthOfBitArrayDividedBy32IsNotZero()
        {
            BitArray bitArray = new BitArray(65);
            int expectedLength = 3;

            int[] actual = bitArray.ToInt32s();

            Assert.That(actual.Length, Is.EqualTo(expectedLength));
        }
    }
}