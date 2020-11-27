using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class ObjectExtensionTests_IsNullThen
    {
        [Test]
        public void IsNullThen_CallsAction_WhenNull()
        {
            object nullObject = null;
            bool wasCalled = false;
            
            nullObject.IsNullThen(() => wasCalled = true);

            Assert.That(wasCalled, Is.True);
        }

        [Test]
        public void IsNullThen_NotCallsAction_WhenNotNull()
        {
            object nullObject = new object();
            bool wasCalled = false;

            nullObject.IsNullThen(() => wasCalled = true);

            Assert.That(wasCalled, Is.False);
        }
    }
}