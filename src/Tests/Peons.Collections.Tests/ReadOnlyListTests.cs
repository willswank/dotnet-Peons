using NUnit.Framework;
using System.Collections.Generic;

namespace Peons.Collections
{
    [TestFixture]
    class ReadOnlyListTests
    {
        ReadOnlyList<object> unit;

        [Test]
        public void indexer_ParamsCtorValues_CanGet()
        {
            var expected1 = new object();
            var expected2 = new object();
            unit = new ReadOnlyList<object>(expected1, expected2);
            Assert.AreEqual(2, unit.Count);
            Assert.AreEqual(expected1, unit[0]);
            Assert.AreEqual(expected2, unit[1]);
        }

        [Test]
        public void indexer_ArrayCtorValues_CanGet()
        {
            var expected = new object[]
            {
                new object(),
                new object(),
                new object()
            };
            unit = new ReadOnlyList<object>(expected);
            Assert.AreEqual(3, unit.Count);
            for (var i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], unit[i]);
            }
        }

        [Test]
        public void indexer_ListCtorValues_CanGet()
        {
            var expected = new List<object>
            {
                new object(),
                new object(),
                new object()
            };
            unit = new ReadOnlyList<object>(expected);
            Assert.AreEqual(3, unit.Count);
            for (var i = 0; i < expected.Count; i++)
            {
                Assert.AreEqual(expected[i], unit[i]);
            }
        }
    }
}
