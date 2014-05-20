using System;

namespace Peons.NUnit.Internals
{
	public interface IWithInputsSyntaxResult<T>
	{
		ISetViaSyntaxResult<T> SetVia(Action<T> setter);
	}
}
