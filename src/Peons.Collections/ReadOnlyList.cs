using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Peons.Collections
{
	public class ReadOnlyList<T> : IReadOnlyList<T>
	{
		private readonly T[] values;

		public ReadOnlyList(params T[] values)
		{
            this.values = values.ToArray();
		}

        public ReadOnlyList(IList<T> values)
        {
            this.values = values.ToArray();
        }

        public T this[int index]
        {
            get { return this.values[index]; }
        }

        public int IndexOf(T value)
        {
            return Array.IndexOf<T>(this.values, value);
        }

        public int Count
        {
            get { return this.values.Length; }
        }

        public bool Contains(T item)
        {
            return this.values.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.values.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)(this.values)).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.values.GetEnumerator();
        }
    }
}
