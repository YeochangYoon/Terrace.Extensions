using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public partial class ArrayExtensionTests_GetRange
    {
        private int[] OriginalArray { get; set; } = new int[] { 1, 2, 3, 4, 5 };

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetRange_ReturnsSubArray_WithIndex()
        {
            int[] expected = new int[] { 3, 4, 5 };
            
            int[] actual = OriginalArray.GetRange(2);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void GetRange_ReturnsSubArray_WithIndexAndCount()
        {
            int[] expected = new int[] { 3, 4 };

            int[] actual = OriginalArray.GetRange(2, 2);

            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}