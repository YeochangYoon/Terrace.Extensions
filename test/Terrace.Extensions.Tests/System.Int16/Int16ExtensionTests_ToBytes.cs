using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class Int16ExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            short @short = short.MaxValue;
            byte[] expected = BitConverter.GetBytes(short.MaxValue);

            byte[] actual = @short.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}