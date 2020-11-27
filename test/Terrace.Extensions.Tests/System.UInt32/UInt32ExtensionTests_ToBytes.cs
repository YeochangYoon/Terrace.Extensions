using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class UInt32ExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            uint @uint = uint.MaxValue;
            byte[] expected = BitConverter.GetBytes(uint.MaxValue);

            byte[] actual = @uint.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}