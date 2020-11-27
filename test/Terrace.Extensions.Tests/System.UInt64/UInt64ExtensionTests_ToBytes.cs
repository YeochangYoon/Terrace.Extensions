using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class UInt64ExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            ulong @ulong = ulong.MaxValue;
            byte[] expected = BitConverter.GetBytes(ulong.MaxValue);

            byte[] actual = @ulong.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}