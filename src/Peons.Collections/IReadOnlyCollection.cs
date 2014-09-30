using System.Collections.Generic;

namespace Peons.Collections
{
	public interface IReadOnlyCollection<T> : IEnumerable<T>
	{
		int Count { get; }
		bool Contains(T item);
		void CopyTo(T[] array, int arrayIndex);
	}
}
