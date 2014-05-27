using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace Peons.NUnit
{
	[TestFixture]
	class IEnumerableValueTypeExtensionsTests
	{
		[Test]
		public void AndNull_AnyValueTypeEnumerable_ClonedEnumerableWithNull()
		{
			IEnumerable<int> input = new int[] { 42 };
			var output = input.AndNull();
			Assert.AreEqual(2, output.Count());
			Assert.IsTrue(output.Contains(42));
			Assert.IsTrue(output.Contains(null));
		}

		[Test]
		public void AndNull_AnyValueTypeEnumerable_AddsClonedEnumerableWithNullToCache()
		{
			IEnumerable<int> input = new int[] { 4, 8, 15, 16, 23, 42 };
			input.AndNull();
			object cacheOutput;
			IEnumerableValueTypeExtensions.Cache
					.TryGetValue(input, out cacheOutput);
			IEnumerable<int?> output = cacheOutput as IEnumerable<int?>;
			foreach (var item in input)
			{
				Assert.IsTrue(output.Contains(item));
			}
			Assert.IsTrue(output.Contains(null));
		}

		[Test]
		public void AndNull_AnyValueTypeEnumerableInCache_CachedClonedEnumerableWithNull()
		{
			IEnumerable<int> input = new int[] { };
			IEnumerable<int?> expected = new int?[] { };
			IEnumerableValueTypeExtensions.Cache.Add(input, expected);
			var output = input.AndNull();
			Assert.AreEqual(expected, output);
		}
	}
}
