using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ByteArrayExtensionTests_ToSingle
    {
        [Test]
        public void ToSingle_ReturnsSingle()
        {
            byte[] bytes = float.MinValue.ToBytes();
            float expected = float.MinValue;
            
            float actual = bytes.ToSingle();

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ToSingle_ReturnsSingle_WithStartIndex()
        {
            byte[] bytes = float.MinValue.ToBytes().Concat(float.MaxValue.ToBytes()).ToArray();                        
            float expected = float.MaxValue;

            float actual = bytes.ToSingle(4);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}