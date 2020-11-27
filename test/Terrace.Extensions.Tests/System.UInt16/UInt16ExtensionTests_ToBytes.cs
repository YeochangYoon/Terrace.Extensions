using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class UInt16ExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            ushort @ushort = ushort.MaxValue;
            byte[] expected = BitConverter.GetBytes(ushort.MaxValue);

            byte[] actual = @ushort.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}