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
    public class ByteArrayExtensionTests_ToDouble
    {
        [Test]
        public void ToDouble_ReturnsDouble()
        {
            byte[] bytes = double.MinValue.ToBytes();
            double expected = double.MinValue;
            
            double actual = bytes.ToDouble();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToDouble_ReturnsDouble_WithStartIndex()
        {
            byte[] bytes = double.MinValue.ToBytes().Concat(double.MaxValue.ToBytes()).ToArray();
            double expected = double.MaxValue;

            double actual = bytes.ToDouble(8);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}