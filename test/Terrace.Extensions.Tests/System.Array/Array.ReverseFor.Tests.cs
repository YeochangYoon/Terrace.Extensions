﻿using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public partial class ArrayExtensionTests_ReverseFor
    {
        [Test]
        public void ReverseFor_IterateAllElementsInReverse()
        {
            int[] array = Enumerable.Range(1, 10).ToArray();
            int[] expected = array.Select((value) => value * value).ToArray();
            int[] expectedIndex = Enumerable.Range(0, 10).Reverse().ToArray();
            List<int> actualIndex = new List<int>();

            int[] actual = array.ReverseFor((value, index) => 
            {
                array[index] = value * value;
                actualIndex.Add(index);
            });

            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actualIndex, Is.EqualTo(expectedIndex));
        }
    }
}