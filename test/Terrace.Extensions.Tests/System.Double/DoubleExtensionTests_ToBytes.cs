using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class DoubleExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            double @double = double.MaxValue;
            byte[] expected = BitConverter.GetBytes(double.MaxValue);

            byte[] actual = @double.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}