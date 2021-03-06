﻿using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class BooleanExtensionTests_ToBytes
    {
        [Test]
        public void ToBytes_ReturnsByteArray_WhenFalse()
        {
            bool @bool = false;
            byte[] expected = { 0x00 };

            byte[] actual = @bool.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToBytes_ReturnsByteArray_WhenTrue()
        {
            bool @bool = true;
            byte[] expected = { 0x01 };

            byte[] actual = @bool.ToBytes();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}