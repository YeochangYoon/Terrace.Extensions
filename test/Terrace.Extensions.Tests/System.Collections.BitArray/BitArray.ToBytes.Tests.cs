using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class BitArrayExtensionTests_ToBytes
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            byte[] bytes = { 0x00, 0x01, 0x02, 0x03 };
            BitArray bitArray = new BitArray(bytes);
            byte[] expected = bytes;

            byte[] actual = bitArray.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToBytes_ReturnsProperLengthOfByteArray_WhenRemainderOfLengthOfBitArrayDividedBy8IsZero()
        {
            BitArray bitArray = new BitArray(16);
            int expectedLength = 2;

            byte[] actual = bitArray.ToBytes();

            Assert.That(actual.Length, Is.EqualTo(expectedLength));

        }
        [Test]
        public void ToBytes_ReturnsProperLengthOfByteArray_WhenRemainderOfLengthOfBitArrayDividedBy8IsNotZero()
        {
            BitArray bitArray = new BitArray(17);
            int expectedLength = 3;

            byte[] actual = bitArray.ToBytes();

            Assert.That(actual.Length, Is.EqualTo(expectedLength));
        }
    }
}