using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class SingleExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            float @float = float.MaxValue;
            byte[] expected = BitConverter.GetBytes(float.MaxValue);

            byte[] actual = @float.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}