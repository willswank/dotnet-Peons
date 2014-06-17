using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Peons.Collections
{
	public class ReadOnlyDictionary<TKey, TValue> : IReadOnlyDictionary<TKey, TValue>, ISerializable, IDeserializationCallback
	{
		private readonly Dictionary<TKey, TValue> wrapped;
		private readonly ReadOnlyCollectionWrapper<TKey> keys;
		private readonly ReadOnlyCollectionWrapper<TValue> values;

		public ReadOnlyDictionary(IDictionary<TKey, TValue> dictionary)
		{
			this.wrapped = new Dictionary<TKey,TValue>(dictionary);
			this.keys = new ReadOnlyCollectionWrapper<TKey>(this.wrapped.Keys);
			this.values = new ReadOnlyCollectionWrapper<TValue>(this.wrapped.Values);
		}
		
		public IEqualityComparer<TKey> Comparer
		{
			get { return this.wrapped.Comparer; }
		}
		
		public int Count
		{
			get { return this.wrapped.Count; }
		}

		public TValue this[TKey key]
		{
			get { return this.wrapped[key]; }
		}

		public bool ContainsKey(TKey key)
		{
			return this.wrapped.ContainsKey(key);
		}

		public bool ContainsValue(TValue value)
		{
			return this.wrapped.ContainsValue(value);
		}
		
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			this.wrapped.GetObjectData(info, context);
		}
		
		public virtual void OnDeserialization(object sender)
		{
			this.wrapped.OnDeserialization(sender);
		}
		
		public bool TryGetValue(TKey key, out TValue value)
		{
			return this.wrapped.TryGetValue(key, out value);
		}

		public IReadOnlyCollection<TKey> Keys
		{
			get { return this.keys; }
		}

		public IReadOnlyCollection<TValue> Values
		{
			get { return this.values; }
		}

		public bool Contains(KeyValuePair<TKey, TValue> item)
		{
			return this.wrapped.Contains(item);
		}

		public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return this.wrapped.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return (this.wrapped as IEnumerable).GetEnumerator();
		}

		public class ReadOnlyCollectionWrapper<T> : IReadOnlyCollection<T>
		{
			private readonly ICollection<T> wrapped;

			public ReadOnlyCollectionWrapper(ICollection<T> wrapped)
			{
				this.wrapped = wrapped;
			}

			public int Count
			{
				get { return this.wrapped.Count; }
			}

			public bool Contains(T item)
			{
				return this.wrapped.Contains(item);
			}

			public void CopyTo(T[] array, int arrayIndex)
			{
				this.wrapped.CopyTo(array, arrayIndex);
			}

			public IEnumerator<T> GetEnumerator()
			{
				return this.wrapped.GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return (this.wrapped as IEnumerable).GetEnumerator();
			}
		}
	}
}
