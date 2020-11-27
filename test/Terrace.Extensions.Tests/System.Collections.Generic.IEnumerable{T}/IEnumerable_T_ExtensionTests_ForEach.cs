using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public class IEnumerable_T_ExtensionTests_ForEach
    {
        [Test]
        public void ForEach_IterateAllElements()
        {
            int[] array = Enumerable.Range(1, 10).ToArray();
            int expected = 55;
            int sum = 0;
            
            array.ForEach((value) => sum += value);

            Assert.That(sum, Is.EqualTo(expected));
        }
    }
}