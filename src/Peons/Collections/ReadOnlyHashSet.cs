using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Peons.Collections
{
	public class ReadOnlyHashSet<T> : IReadOnlySet<T>, ISerializable, IDeserializationCallback
	{
		private readonly HashSet<T> wrapped;

		public ReadOnlyHashSet(IEnumerable<T> collection)
		{
			this.wrapped = new HashSet<T>(collection);
		}
		
		public ReadOnlyHashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
		{
			this.wrapped = new HashSet<T>(collection, comparer);
		}

		public ReadOnlyHashSet(HashSet<T> hashSet)
		{
			this.wrapped = new HashSet<T>(hashSet);
		}

		public bool IsProperSubsetOf(IEnumerable<T> other)
		{
			return this.wrapped.IsProperSubsetOf(other);
		}

		public bool IsProperSupersetOf(IEnumerable<T> other)
		{
			return this.wrapped.IsProperSupersetOf(other);
		}

		public bool IsSubsetOf(IEnumerable<T> other)
		{
			return this.wrapped.IsSubsetOf(other);
		}

		public bool IsSupersetOf(IEnumerable<T> other)
		{
			return this.wrapped.IsSupersetOf(other);
		}

		public bool Overlaps(IEnumerable<T> other)
		{
			return this.wrapped.Overlaps(other);
		}

		public bool SetEquals(IEnumerable<T> other)
		{
			return this.wrapped.SetEquals(other);
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this.wrapped.GetEnumerator();
		}

		public IEqualityComparer<T> Comparer
		{
			get { return this.wrapped.Comparer; }
		}

		public int Count
		{
			get { return this.wrapped.Count; }
		}

		public bool Contains(T item)
		{
			return this.wrapped.Contains(item);
		}

		public void CopyTo(T[] array)
		{
			this.wrapped.CopyTo(array);
		}
		
		public void CopyTo(T[] array, int arrayIndex)
		{
			this.wrapped.CopyTo(array, arrayIndex);
		}

		public void CopyTo(T[] array, int arrayIndex, int count)
		{
			this.wrapped.CopyTo(array, arrayIndex, count);
		}
		
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.wrapped.GetObjectData(info, context);
		}

		public virtual void OnDeserialization(object sender)
		{
			this.wrapped.OnDeserialization(sender);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (this.wrapped as IEnumerable).GetEnumerator();
		}
	}
}
