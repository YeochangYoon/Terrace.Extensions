using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ByteArrayExtensionTests_ToBitArray
    {
        [Test]
        public void ToBitArray_ReturnsBitArray()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            BitArray expected = new BitArray(bytes);

            BitArray actual = bytes.ToBitArray();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToBitArray_ReturnsBitArray_WithBitIndex()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            BitArray expected = new BitArray(new bool[] {
                false, true, true, false, false, false, false, false, false
            });

            BitArray actual = bytes.ToBitArray(23);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToBitArray_ReturnsBitArray_WithBitIndexAndBitCount()
        {
            byte[] bytes = new byte[] { 0x00, 0x01, 0x02, 0x03 };
            BitArray expected = new BitArray(new bool[] { false, true, true });

            BitArray actual = bytes.ToBitArray(23, 3);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}