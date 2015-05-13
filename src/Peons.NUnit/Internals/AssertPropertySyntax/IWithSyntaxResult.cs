using System;

namespace Peons.NUnit.Internals.AssertPropertySyntax
{
	public interface IWithSyntaxResult<T>
	{
		ICanSetBySyntaxResult<T> CanSetBy(Action<T> setter);
	}
}
