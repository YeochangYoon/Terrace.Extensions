using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture()]
    public class BooleanExtensionTests_ToSingle
    {
        [Test()]
        public void ToSingle_ReturnZero_WhenFalse()
        {
            bool @bool = false;
            float expected = 0;

            float actual = @bool.ToSingle();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test()]
        public void ToSingle_ReturnOne_WhenTrue()
        {
            bool @bool = true;
            float expected = 1;

            float actual = @bool.ToSingle();

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}