using System.Collections.Generic;

namespace Peons.Collections
{
	public interface IReadOnlyList<T> : IReadOnlyCollection<T>
	{
        T this[int index] { get; }
        int IndexOf(T value);
	}
}
