using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class Int64ExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            long @long = long.MaxValue;
            byte[] expected = BitConverter.GetBytes(long.MaxValue);

            byte[] actual = @long.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}