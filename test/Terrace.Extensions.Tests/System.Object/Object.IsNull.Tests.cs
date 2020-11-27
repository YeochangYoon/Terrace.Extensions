using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ObjectExtensionTests_IsNull
    {
        [Test]
        public void IsNull_ReturnsTrue_WhenNull()
        {
            object nullObject = null;
            
            bool actual = nullObject.IsNull();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNull_ReturnsFalse_WhenNotNull()
        {
            object nullObject = new object();

            bool actual = nullObject.IsNull();

            Assert.That(actual, Is.False);
        }
    }
}