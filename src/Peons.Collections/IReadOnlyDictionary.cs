using System.Collections.Generic;

namespace Peons.Collections
{
	public interface IReadOnlyDictionary<TKey, TValue> : IReadOnlyCollection<KeyValuePair<TKey, TValue>>
	{
		IReadOnlyCollection<TKey> Keys { get; }
		IReadOnlyCollection<TValue> Values { get; }
		TValue this[TKey key] { get; }
		bool ContainsKey(TKey key);
		bool TryGetValue(TKey key, out TValue value);
	}
}
