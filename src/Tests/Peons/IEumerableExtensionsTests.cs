using NUnit.Framework;
using System.Collections.Generic;

namespace Peons
{
	[TestFixture]
	class IEnumerableExtensionsTests
	{
		[Test]
		public void IsNullOrEmpty_Null_True()
		{
            IEnumerable<object> input = null;
            var output = input.IsNullOrEmpty();
            Assert.IsTrue(output);
		}

        [Test]
        public void IsNullOrEmpty_Empty_True()
        {
            var input = new object[] { };
            var output = input.IsNullOrEmpty();
            Assert.IsTrue(output);
        }

        [Test]
        public void IsNullOrEmpty_NonEmpty_False()
        {
            var input = new object[] { new object() };
            var output = input.IsNullOrEmpty();
            Assert.IsFalse(output);
        }

        [Test]
        public void IsEmpty_Empty_True()
        {
            var input = new object[] { };
            var output = input.IsEmpty();
            Assert.IsTrue(output);
        }

        [Test]
        public void IsEmpty_NonEmpty_False()
        {
            var input = new object[] { new object() };
            var output = input.IsEmpty();
            Assert.IsFalse(output);
        }
	}
}
