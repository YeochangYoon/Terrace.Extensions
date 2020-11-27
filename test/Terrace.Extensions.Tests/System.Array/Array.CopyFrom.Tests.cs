using NUnit.Framework;
using Terrace.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions.Tests
{
    [TestFixture]
    public partial class ArrayExtensionTests_CopyFrom
    {
        private int[] OriginalArray { get; set; }
        private int[] SourceArray { get; } = new int[3] { 1, 2, 3 };
        private int Source { get; } = 1;

        [SetUp]
        public void Setup()
        {
            OriginalArray = new int[5];
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithIndexAndSource()
        {
            int[] expected = new int[] { 0, 1, 0, 0, 0 };

            int[] actual = OriginalArray.CopyFrom(1, Source);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithIndexAndSourceArray()
        {
            int[] expected = new int[] { 0, 1, 2, 3, 0 };

            int[] actual = OriginalArray.CopyFrom(1, SourceArray);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithIndexAndSourceArrayAndSourceIndex()
        {
            int[] expected = new int[] { 0, 2, 3, 0, 0 };

            int[] actual = OriginalArray.CopyFrom(1, SourceArray, 1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithIndexAndSourceArrayAndSourceIndexAndCount()
        {
            int[] expected = new int[] { 0, 2, 0, 0, 0 };

            int[] actual = OriginalArray.CopyFrom(1, SourceArray, 1, 1);

            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithRefIndexAndSource()
        {
            int index = 1;
            int expectedIndex = index + 1;
            int[] expected = new int[] { 0, 1, 0, 0, 0 };

            int[] actual = OriginalArray.CopyFrom(ref index, Source);

            Assert.That(index, Is.EqualTo(expectedIndex));
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithRefIndexAndSourceArray()
        {
            int index = 1;
            int expectedIndex = index + SourceArray.Length;
            int[] expected = new int[] { 0, 1, 2, 3, 0 };            

            int[] actual = OriginalArray.CopyFrom(ref index, SourceArray);

            Assert.That(index, Is.EqualTo(expectedIndex));
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithRefIndexAndSourceArrayAndSourceIndex()
        {
            int index = 1;
            int expectedIndex = index + SourceArray.Length - 1;
            int[] expected = new int[] { 0, 2, 3, 0, 0 };

            int[] actual = OriginalArray.CopyFrom(ref index, SourceArray, 1);

            Assert.That(index, Is.EqualTo(expectedIndex));
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void CopyFrom_ReturnsCopiedArray_WithRefIndexAndSourceArrayAndSourceIndexAndCount()
        {
            int index = 1;
            int expectedIndex = index + 1;
            int[] expected = new int[] { 0, 2, 0, 0, 0 };            

            int[] actual = OriginalArray.CopyFrom(ref index, SourceArray, 1, 1);

            Assert.That(index, Is.EqualTo(expectedIndex));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}