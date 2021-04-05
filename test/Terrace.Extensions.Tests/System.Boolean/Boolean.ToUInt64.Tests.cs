using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToUInt64
    {
        [Test()]
        public void ToUInt64_ReturnZero_WhenFalse()
        {
            bool @bool = false;
            ulong expected = 0;

            ulong actual = @bool.ToUInt64();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToUInt64_ReturnOne_WhenTrue()
        {
            bool @bool = true;
            ulong expected = 1;

            ulong actual = @bool.ToUInt64();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}