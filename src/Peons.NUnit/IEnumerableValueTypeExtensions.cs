using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Peons.NUnit
{
	public static class IEnumerableValueTypeExtensions
	{
		public static ConditionalWeakTable<object, object> Cache
		{
			get
			{
				return cache;
			}
		}
		private static readonly ConditionalWeakTable<object, object> cache
				= new ConditionalWeakTable<object, object>();

		public static IEnumerable<T?> AndNull<T>(this IEnumerable<T> values) where T : struct
		{
			object cacheOutput;
			Cache.TryGetValue(values, out cacheOutput);
			IEnumerable<T?> enumerable = cacheOutput as IEnumerable<T?>;
			if (enumerable == null)
			{
				enumerable = values.Select(i => (T?)i).Concat(new T?[] { null });
				Cache.Add(values, enumerable);
			}
			return enumerable;
		}
	}
}
