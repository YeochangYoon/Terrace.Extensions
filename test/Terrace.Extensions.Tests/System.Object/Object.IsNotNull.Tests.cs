using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ObjectExtensionTests_IsNotNull
    {
        [Test]
        public void IsNotNull_ReturnsTrue_WhenNotNull()
        {
            object nullObject = new object();
            
            bool actual = nullObject.IsNotNull();

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsNotNull_ReturnsFalse_WhenNull()
        {
            object nullObject = null;

            bool actual = nullObject.IsNotNull();

            Assert.That(actual, Is.False);
        }
    }
}