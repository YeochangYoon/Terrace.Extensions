using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class Int32ExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            int @int = int.MaxValue;
            byte[] expected = BitConverter.GetBytes(int.MaxValue);

            byte[] actual = @int.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}