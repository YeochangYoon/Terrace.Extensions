using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ObjectExtensionTests_IsNotNullThen
    {
        [Test]
        public void IsNotNullThen_CallsAction_WhenNotNull()
        {
            object nullObject = new object();
            bool wasCalled = false;
            
            nullObject.IsNotNullThen(() => wasCalled = true);

            Assert.That(wasCalled, Is.True);
        }

        [Test]
        public void IsNotNullThen_NotCallsAction_WhenNull()
        {
            object nullObject = null;
            bool wasCalled = false;

            nullObject.IsNotNullThen(() => wasCalled = true);

            Assert.That(wasCalled, Is.False);
        }
    }
}