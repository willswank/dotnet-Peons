using System;

namespace Peons.NUnit.Internals
{
	public interface ISetViaSyntaxResult<T>
	{
		void GotVia(Func<T> getter);
	}
}
