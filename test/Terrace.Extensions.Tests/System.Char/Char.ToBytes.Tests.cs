using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class CharExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray()
        {
            char @char = char.MaxValue;
            byte[] expected = BitConverter.GetBytes(char.MaxValue);

            byte[] actual = @char.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}